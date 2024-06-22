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

    private void HideForSomeTime(object? content, int minutes) {
        (Text, numericUpDownMinutesToReappear.Value) = _contentFile.UpdateContent(content as string, minutes);
        timer.Interval = minutes * 60000;
        timer.Enabled = true;
        WindowState = FormWindowState.Minimized;
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
    private void buttonStart_Click(object sender, EventArgs e) =>
        HideForSomeTime(From(dataGridViewHistory.CurrentCell?.Value), (int)numericUpDownMinutesToReappear.Value);

    private void dataGridViewHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) =>
        HideForSomeTime(From(dataGridViewHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value), (int)numericUpDownMinutesToReappear.Value);

    private static string From(object? content) {
        string? value = content as string;
        return string.IsNullOrWhiteSpace(value) ? "?" : value;
    }
}
