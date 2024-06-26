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
        (Text, numericUpDownMinutesToReappear.Value) = _contentFile.ReadContent();
        TopMost = true;
    }

    public static string DataFolder => _appDataFolder.Value;

    private static readonly Lazy<string> _appDataFolder = new(() => {
        var _appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nameof(TickTack));
        Directory.CreateDirectory(_appDataFolder);
        return _appDataFolder;
    });


    private readonly HistoryFile _historyFile;
    private readonly ContentFile _contentFile;

    private void TrackCell(DataGridViewCellEventArgs e) => ProcessChange(dataGridViewHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, (int)numericUpDownMinutesToReappear.Value, hide: false);
    private void HideWith(object? value) => ProcessChange(value, (int)numericUpDownMinutesToReappear.Value, hide: true);
    private void ProcessChange(object? content, int minutes, bool hide) {
        if (content is string text && !string.IsNullOrWhiteSpace(text)) {
            (Text, numericUpDownMinutesToReappear.Value) = _contentFile.UpdateContent(text, minutes);
            if (hide) {
                timer.Interval = minutes * 60000;
                timer.Enabled = true;
                WindowState = FormWindowState.Minimized;
            }
        } else
            dataGridViewHistory.Focus();
    }
    private void ShowAgain() {
        timer.Enabled = false;
        TopMost = true;
        WindowState = FormWindowState.Normal;
        Show();
    }

    private void timer_Tick(object sender, EventArgs e) =>
        ShowAgain();

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
