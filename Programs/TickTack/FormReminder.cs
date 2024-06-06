// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************


using System.Collections;

using static System.Net.Mime.MediaTypeNames;

namespace TickTack;

public partial class FormReminder : Form
{
    public FormReminder() {
        _contentFile = new ContentFile(_appDataFolder.Value);
        _historyFile = new HistoryFile(_appDataFolder.Value);
        InitializeComponent();
        if (_historyFile.Exists)
            _historyItems.AddRange(_historyFile.ReadHistory());
        if (_contentFile.Exists)
            textBoxMessage.Text = _contentFile.ReadContent();
        TopMost = true;
    }

    private ListBox.ObjectCollection _historyItems => listBoxHistory.Items;

    private static readonly Lazy<string> _appDataFolder = new(() => {
        var _appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nameof(TickTack));
        Directory.CreateDirectory(_appDataFolder);
        return _appDataFolder;
    });


    private readonly ContentFile _contentFile;
    private readonly HistoryFile _historyFile;

    private void timer_Tick(object sender, EventArgs e) {
        timer.Enabled = false;
        TopMost = true;
        Show();
    }

    private void buttonHide_Click(object sender, EventArgs e) {
        timer.Interval = ((int)numericUpDownMinutesToReappear.Value) * 60000;
        timer.Enabled = true;
        Hide();
        string? text = textBoxMessage.Text;
        if (text?.Length > 0 && !_historyItems.Contains(text)) {
            _historyItems.Insert(0, text);
            _historyFile.UpdateHistory(_historyItems);
            UpdateHistorySelections(text);
        }
    }

    private void FormReminder_Shown(object sender, EventArgs e) => textBoxMessage.Focus();

    private void textBoxMessage_TextChanged(object sender, EventArgs e) {
        string text = textBoxMessage.Text;
        _contentFile.UpdateContent(text);
        UpdateHistorySelections(text);
    }


    private void listBoxHistory_DoubleClick(object sender, EventArgs e) {
        if (e is MouseEventArgs me) {
            int clickedItem = listBoxHistory.IndexFromPoint(me.Location);
            SetFromHistory(clickedItem);
        }
    }

    private void textBoxMessage_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.PageDown && listBoxHistory.SelectedIndices.Count > 0)
            SetFromHistory(listBoxHistory.SelectedIndex);
    }

    private void SetFromHistory(int index) {
        string? text = _historyItems[index]?.ToString();
        textBoxMessage.Text = text;
        textBoxMessage.Focus();
    }
    private void UpdateHistorySelections(string text) {
        for (int i = 0; i < _historyItems.Count; i++) {
            string value = _historyItems[i]?.ToString() ?? "\t";
            listBoxHistory.SetSelected(i, string.IsNullOrWhiteSpace(text) || value.StartsWith(text, StringComparison.OrdinalIgnoreCase));
        };
    }

    private void buttonClearHistory_Click(object sender, EventArgs e) {
        DialogResult dialogResult = MessageBox.Show("Do you really want to clear history?", "Please confirm", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes) {
            _historyItems.Clear();
            _historyFile.UpdateHistory(_historyItems);
        }
    }
}
