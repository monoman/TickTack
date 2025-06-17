// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************

using System.ComponentModel;
using System.Diagnostics;


namespace TickTack;

public partial class FormReminder : Form
{
    public FormReminder() {
        _contentFile = new ContentFile(DataFolder);
        InitializeComponent();
        AdjustDataGridToData();
        SetStatus(_contentFile.ReadContent());
        TopMost = true;
    }
    public static string DataFolder => _appDataFolder.Value;

    public int TotalMinutes => (int)_interval.TotalMinutes;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Title { get; private set; } = "Reminder";
    private readonly ContentFile _contentFile;
    private TimeSpan _interval = TimeSpan.FromMinutes(25);
    private HistoryFile? _historyFile;
    private static readonly Lazy<string> _appDataFolder = new(CreateAppDataFolder);

    private void UpdateText() => Text = $"{Title}  [{FormatTimeSpan(progressBar.Value)} of {TotalMinutes:0}min]";
    private static string FormatTimeSpan(int timeInSeconds) => $"{timeInSeconds / 60:0}:{timeInSeconds % 60:00}";
    private static string CreateAppDataFolder() {
        var appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nameof(TickTack));
        Directory.CreateDirectory(appDataFolder);
        return appDataFolder;
    }
    private void AdjustDataGridToData() {
        _historyFile?.Dispose();
        _historyFile = new HistoryFile(DataFolder);
        dataGridViewHistory.DataSource = _historyFile;
        dataGridViewHistory.ClearSelection();
        var minutesColumn = dataGridViewHistory.Columns[1];
        minutesColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        minutesColumn.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleRight };
    }
    private void SelectRow(DataGridViewRow? row, bool hide = false) {
        if (row is not null && (!timer.Enabled || hide)) {
            string? text = row?.Cells[0].Value as string;
            int minutes = (row?.Cells[1].Value as int?) ?? ContentFile.DefaultPeriodInMinutes;
            if (!string.IsNullOrWhiteSpace(text) && minutes >= 1) {
                timer.Enabled = false;
                SetStatus(_contentFile.UpdateContent(text, minutes));
                if (hide) {
                    timer.Interval = 1000;
                    timer.Enabled = true;
                    WindowState = FormWindowState.Minimized;
                }
                return;
            }
        }
        dataGridViewHistory.Focus();
    }
    private void SetStatus((string Title, int Minutes) value) {
        Title = value.Title;
        _interval = TimeSpan.FromMinutes(value.Minutes);
        progressBar.Maximum = (int)_interval.TotalSeconds;
        progressBar.Value = 0;
        UpdateText();
    }
    private void ShowAgain() {
        timer.Enabled = false;
        progressBar.Value = progressBar.Maximum;
        UpdateText();
        TopMost = true;
        WindowState = FormWindowState.Normal;
        Show();
    }
    private void timer_Tick(object sender, EventArgs e) {
        if (progressBar.Value < progressBar.Maximum) {
            progressBar.Value++;
            UpdateText();
        } else
            ShowAgain();
    }
    private void FormReminder_Shown(object sender, EventArgs e) {
        timer.Enabled = false;
        dataGridViewHistory.Focus();
    }
    private void buttonEditHistory_Click(object sender, EventArgs e) {
        if (_historyFile is null)
            return;
        _historyFile.EditUsingEditorFromEnvironment();
        AdjustDataGridToData();
    }


    private void dataGridViewHistory_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) =>
        e.Cancel = MessageBox.Show($"Do you really want to remove '{e.Row?.Cells[0].Value}'?", "Please confirm", MessageBoxButtons.YesNo) == DialogResult.No;
    private void buttonStart_Click(object sender, EventArgs e) => SelectRow(dataGridViewHistory.CurrentCell?.OwningRow, hide: true);
    private void dataGridViewHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => SelectRow(dataGridViewHistory.Rows[e.RowIndex], hide: true);
    private void dataGridViewHistory_CellValueChanged(object sender, DataGridViewCellEventArgs e) => SelectRow(dataGridViewHistory.Rows[e.RowIndex]);

    protected override void OnClosed(EventArgs e) {
        base.OnClosed(e);
        _historyFile?.Dispose();
    }
}
