namespace TickTack
{
	partial class FormReminder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReminder));
			this.buttonOk = new System.Windows.Forms.Button();
			this.panelConfig = new System.Windows.Forms.Panel();
			this.labelShowUpAgain = new System.Windows.Forms.Label();
			this.labelMinutes = new System.Windows.Forms.Label();
			this.numericUpDownMinutesToReappear = new System.Windows.Forms.NumericUpDown();
			this.textBoxMessage = new System.Windows.Forms.TextBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.panelConfig.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesToReappear)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			resources.ApplyResources(this.buttonOk, "buttonOk");
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// panelConfig
			// 
			this.panelConfig.BackColor = System.Drawing.SystemColors.Info;
			this.panelConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelConfig.Controls.Add(this.labelShowUpAgain);
			this.panelConfig.Controls.Add(this.labelMinutes);
			this.panelConfig.Controls.Add(this.numericUpDownMinutesToReappear);
			resources.ApplyResources(this.panelConfig, "panelConfig");
			this.panelConfig.Name = "panelConfig";
			// 
			// labelShowUpAgain
			// 
			resources.ApplyResources(this.labelShowUpAgain, "labelShowUpAgain");
			this.labelShowUpAgain.Name = "labelShowUpAgain";
			// 
			// labelMinutes
			// 
			resources.ApplyResources(this.labelMinutes, "labelMinutes");
			this.labelMinutes.Name = "labelMinutes";
			// 
			// numericUpDownMinutesToReappear
			// 
			resources.ApplyResources(this.numericUpDownMinutesToReappear, "numericUpDownMinutesToReappear");
			this.numericUpDownMinutesToReappear.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownMinutesToReappear.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDownMinutesToReappear.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownMinutesToReappear.Name = "numericUpDownMinutesToReappear";
			this.numericUpDownMinutesToReappear.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.AcceptsReturn = true;
			resources.ApplyResources(this.textBoxMessage, "textBoxMessage");
			this.textBoxMessage.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.textBoxMessage.Name = "textBoxMessage";
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// FormReminder
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.panelConfig);
			this.Controls.Add(this.buttonOk);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormReminder";
			this.Opacity = 0.95D;
			this.ShowInTaskbar = false;
			this.panelConfig.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesToReappear)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Panel panelConfig;
		private System.Windows.Forms.Label labelMinutes;
		private System.Windows.Forms.NumericUpDown numericUpDownMinutesToReappear;
		private System.Windows.Forms.Label labelShowUpAgain;
		private System.Windows.Forms.TextBox textBoxMessage;
		private System.Windows.Forms.Timer timer;
	}
}

