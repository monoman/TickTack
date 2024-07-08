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
        get => (_title, (int)numericUpDownMinutesToReappear.Value);
        set {
            _title = value.Title;
            numericUpDownMinutesToReappear.Value = value.Minutes;
            progressBar.Value = progressBar.Maximum = value.Minutes * 60;
            UpdateText();
        }
    }

    private void UpdateText() => Text = _running ? $"{_title} {progressBar.Value}s" : _title;

    private static readonly Lazy<string> _appDataFolder = new(() => {
        var _appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nameof(TickTack));
        Directory.CreateDirectory(_appDataFolder);
        return _appDataFolder;
    });


    private readonly HistoryFile _historyFile;
    private readonly ContentFile _contentFile;
    private string _title = "Reminder";
    private bool _running = false;

    private void TrackCell(DataGridViewCellEventArgs e) => ProcessChange(dataGridViewHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
    private void HideWith(object? value) => ProcessChange(value, hide: true);
    private void ProcessChange(object? content, int? minutes = null, bool hide = false) {
        if (content is string text && !string.IsNullOrWhiteSpace(text)) {
            Status = _contentFile.UpdateContent(text, minutes ?? Status.Minutes);
            if (hide) {
                _running = true;
                timer.Interval = 1000;
                timer.Enabled = true;
                WindowState = FormWindowState.Minimized;
            }
        } else
            dataGridViewHistory.Focus();
    }
    private void ShowAgain() {
        timer.Enabled = false;
        _running = false;
        progressBar.Value = progressBar.Maximum;
        UpdateText();
        TopMost = true;
        WindowState = FormWindowState.Normal;
        Show();
    }

    private void timer_Tick(object sender, EventArgs e) {
        if (progressBar.Value > 0) {
            progressBar.Value--;
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

    private void buttonStart_Click(object sender, EventArgs e) => HideWith(dataGridViewHistory.CurrentCell?.Value);
    private void dataGridViewHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => HideWith(dataGridViewHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
    private void dataGridViewHistory_CellValueChanged(object sender, DataGridViewCellEventArgs e) => TrackCell(e);
}
