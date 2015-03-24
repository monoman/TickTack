using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TickTack
{
	public partial class FormLembrete : Form
	{
		public FormLembrete()
		{
			InitializeComponent();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			timer.Interval = ((int)numericUpDownTempoEmMinutos.Value) * 60000;
			timer.Enabled = true;
			Hide();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			timer.Enabled = false;
			Show();
			buttonOk.Focus();
		}
	}
}