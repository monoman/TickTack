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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            panelConfig = new Panel();
            labelShowUpAgain = new Label();
            labelMinutes = new Label();
            numericUpDownMinutesToReappear = new NumericUpDown();
            textBoxMessage = new TextBox();
            timer = new System.Windows.Forms.Timer(components);
            buttonHide = new Button();
            panelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutesToReappear).BeginInit();
            SuspendLayout();
            // 
            // panelConfig
            // 
            panelConfig.BackColor = SystemColors.GradientActiveCaption;
            panelConfig.Controls.Add(labelShowUpAgain);
            panelConfig.Controls.Add(labelMinutes);
            panelConfig.Controls.Add(numericUpDownMinutesToReappear);
            panelConfig.Dock = DockStyle.Top;
            panelConfig.Location = new Point(0, 0);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(380, 37);
            panelConfig.TabIndex = 3;
            // 
            // labelShowUpAgain
            // 
            labelShowUpAgain.Font = new Font("Tahoma", 12F);
            labelShowUpAgain.Location = new Point(25, 9);
            labelShowUpAgain.Name = "labelShowUpAgain";
            labelShowUpAgain.Size = new Size(152, 21);
            labelShowUpAgain.TabIndex = 5;
            labelShowUpAgain.Text = "Show up again in";
            labelShowUpAgain.TextAlign = ContentAlignment.TopRight;
            // 
            // labelMinutes
            // 
            labelMinutes.Font = new Font("Tahoma", 12F);
            labelMinutes.Location = new Point(268, 9);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(67, 21);
            labelMinutes.TabIndex = 4;
            labelMinutes.Text = "minutes";
            // 
            // numericUpDownMinutesToReappear
            // 
            numericUpDownMinutesToReappear.Font = new Font("Tahoma", 12F);
            numericUpDownMinutesToReappear.Location = new Point(184, 6);
            numericUpDownMinutesToReappear.Margin = new Padding(4, 3, 4, 3);
            numericUpDownMinutesToReappear.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownMinutesToReappear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMinutesToReappear.Name = "numericUpDownMinutesToReappear";
            numericUpDownMinutesToReappear.Size = new Size(77, 27);
            numericUpDownMinutesToReappear.TabIndex = 3;
            numericUpDownMinutesToReappear.TextAlign = HorizontalAlignment.Right;
            numericUpDownMinutesToReappear.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // textBoxMessage
            // 
            textBoxMessage.AcceptsReturn = true;
            textBoxMessage.BackColor = SystemColors.ButtonFace;
            textBoxMessage.Dock = DockStyle.Fill;
            textBoxMessage.Font = new Font("Calibri", 12F);
            textBoxMessage.ForeColor = Color.DarkSlateBlue;
            textBoxMessage.Location = new Point(0, 37);
            textBoxMessage.Margin = new Padding(7);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.PlaceholderText = "Type your message here...";
            textBoxMessage.Size = new Size(287, 48);
            textBoxMessage.TabIndex = 4;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // buttonHide
            // 
            buttonHide.AutoSize = true;
            buttonHide.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonHide.BackColor = Color.Indigo;
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatStyle = FlatStyle.Popup;
            buttonHide.Font = new Font("Calibri", 19F, FontStyle.Bold);
            buttonHide.ForeColor = Color.LightGray;
            buttonHide.Location = new Point(287, 37);
            buttonHide.Name = "buttonHide";
            buttonHide.Padding = new Padding(10, 0, 10, 0);
            buttonHide.Size = new Size(93, 48);
            buttonHide.TabIndex = 5;
            buttonHide.Text = "Hide";
            buttonHide.UseVisualStyleBackColor = true;
            buttonHide.Click += buttonHide_Click;
            // 
            // FormReminder
            // 
            AcceptButton = buttonHide;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Bisque;
            ClientSize = new Size(380, 85);
            Controls.Add(textBoxMessage);
            Controls.Add(buttonHide);
            Controls.Add(panelConfig);
            Font = new Font("Calibri", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormReminder";
            Opacity = 0.85D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reminder";
            Shown += FormReminder_Shown;
            panelConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutesToReappear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutesToReappear;
        private System.Windows.Forms.Label labelShowUpAgain;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Timer timer;
        private Button buttonHide;
    }
}

