// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************

namespace TickTack;

public partial class FormReminder : Form
{
    public FormReminder() => InitializeComponent();

    private void timer_Tick(object sender, EventArgs e) {
        timer.Enabled = false;
        Show();
    }

    private void buttonHide_Click(object sender, EventArgs e) {
        timer.Interval = ((int)numericUpDownMinutesToReappear.Value) * 60000;
        timer.Enabled = true;
        Hide();
    }

    private void FormReminder_Shown(object sender, EventArgs e) => textBoxMessage.Focus();
}