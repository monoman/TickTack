// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************

namespace TickTack;

public partial class FormReminder : Form
{
    public FormReminder() {
        _historyFile = new HistoryFile(DataFolder);
        _contentFile = new ContentFile(DataFolder);
        InitializeComponent();
        dataGridViewHistory.DataSource = _historyFile;
        dataGridViewHistory.ClearSelection();
        Status = _contentFile.ReadContent();
        TopMost = true;
    }

    public static string DataFolder => _appDataFolder.Value;

    public (string Title, int Minutes) Status {
        get => (_title, _totalMinutes);
        set {
            _title = value.Title;
            _interval = TimeSpan.FromMinutes(value.Minutes);
            progressBar.Maximum = (int)_interval.TotalSeconds;
            progressBar.Value = 0;
            UpdateText();
        }
    }

    private int _totalMinutes => (int)_interval.TotalMinutes;
    private void UpdateText() => Text = $"{_title}  [{FormatTimeSpan(progressBar.Value)} of {_totalMinutes:0}min]";

    private static string FormatTimeSpan(int timeInSeconds) {
        var ts = TimeSpan.FromSeconds(timeInSeconds);
        return ts.ToString("mm\\:ss");
    }

    private static readonly Lazy<string> _appDataFolder = new(() => {
        var _appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nameof(TickTack));
        Directory.CreateDirectory(_appDataFolder);
        return _appDataFolder;
    });


    private readonly HistoryFile _historyFile;
    private readonly ContentFile _contentFile;
    private string _title = "Reminder";
    private TimeSpan _interval = TimeSpan.FromMinutes(25);

    private void SelectRow(DataGridViewRow? row, bool hide = false) {
        if (row is not null && (!timer.Enabled || hide)) {
            string? text = row?.Cells[0].Value as string;
            int minutes = (int)(row?.Cells[1].Value ?? ContentFile.DefaultPeriodInMinutes);
            if (!string.IsNullOrWhiteSpace(text) && minutes >= 1) {
                timer.Enabled = false;
                Status = _contentFile.UpdateContent(text, minutes);
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

    private void buttonClearHistory_Click(object sender, EventArgs e) {
        var dialogResult = MessageBox.Show("Do you really want to clear history?", "Please confirm", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
            _historyFile.Clear();
    }

    private void dataGridViewHistory_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) =>
        e.Cancel = MessageBox.Show($"Do you really want to remove '{e.Row?.Cells[0].Value}'?", "Please confirm", MessageBoxButtons.YesNo) == DialogResult.No;

    private void buttonStart_Click(object sender, EventArgs e) => SelectRow(dataGridViewHistory.CurrentCell?.OwningRow, hide: true);
    private void dataGridViewHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => SelectRow(dataGridViewHistory.Rows[e.RowIndex], hide: true);
    private void dataGridViewHistory_CellValueChanged(object sender, DataGridViewCellEventArgs e) => SelectRow(dataGridViewHistory.Rows[e.RowIndex]);
}
