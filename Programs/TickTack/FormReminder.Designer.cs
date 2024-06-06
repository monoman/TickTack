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
            buttonHide = new Button();
            timer = new System.Windows.Forms.Timer(components);
            textBoxMessage = new TextBox();
            listBoxHistory = new ListBox();
            buttonClearHistory = new Button();
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
            panelConfig.Controls.Add(buttonHide);
            panelConfig.Dock = DockStyle.Top;
            panelConfig.Location = new Point(0, 0);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(491, 37);
            panelConfig.TabIndex = 3;
            // 
            // labelShowUpAgain
            // 
            labelShowUpAgain.Font = new Font("Cascadia Code", 12F);
            labelShowUpAgain.Location = new Point(17, 9);
            labelShowUpAgain.Name = "labelShowUpAgain";
            labelShowUpAgain.Size = new Size(176, 21);
            labelShowUpAgain.TabIndex = 5;
            labelShowUpAgain.Text = "Show up again in";
            labelShowUpAgain.TextAlign = ContentAlignment.TopRight;
            // 
            // labelMinutes
            // 
            labelMinutes.Font = new Font("Cascadia Code", 12F);
            labelMinutes.Location = new Point(284, 9);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(76, 21);
            labelMinutes.TabIndex = 4;
            labelMinutes.Text = "minutes";
            // 
            // numericUpDownMinutesToReappear
            // 
            numericUpDownMinutesToReappear.Font = new Font("Cascadia Code", 12F);
            numericUpDownMinutesToReappear.Location = new Point(200, 6);
            numericUpDownMinutesToReappear.Margin = new Padding(4, 3, 4, 3);
            numericUpDownMinutesToReappear.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownMinutesToReappear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMinutesToReappear.Name = "numericUpDownMinutesToReappear";
            numericUpDownMinutesToReappear.Size = new Size(77, 27);
            numericUpDownMinutesToReappear.TabIndex = 3;
            numericUpDownMinutesToReappear.TextAlign = HorizontalAlignment.Right;
            numericUpDownMinutesToReappear.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // buttonHide
            // 
            buttonHide.AutoSize = true;
            buttonHide.BackColor = Color.Indigo;
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatStyle = FlatStyle.Popup;
            buttonHide.Font = new Font("Candara", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHide.ForeColor = Color.LightGray;
            buttonHide.Location = new Point(397, 0);
            buttonHide.Name = "buttonHide";
            buttonHide.Padding = new Padding(10, 0, 10, 0);
            buttonHide.Size = new Size(94, 37);
            buttonHide.TabIndex = 5;
            buttonHide.Text = "Hide";
            buttonHide.UseVisualStyleBackColor = true;
            buttonHide.Click += buttonHide_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // textBoxMessage
            // 
            textBoxMessage.AcceptsTab = true;
            textBoxMessage.BackColor = Color.FromArgb(255, 192, 255);
            textBoxMessage.Dock = DockStyle.Top;
            textBoxMessage.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMessage.ForeColor = Color.MidnightBlue;
            textBoxMessage.Location = new Point(0, 37);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.PlaceholderText = "Type here your message...";
            textBoxMessage.Size = new Size(491, 26);
            textBoxMessage.TabIndex = 0;
            textBoxMessage.TextChanged += textBoxMessage_TextChanged;
            textBoxMessage.KeyDown += textBoxMessage_KeyDown;
            // 
            // listBoxHistory
            // 
            listBoxHistory.BackColor = Color.LemonChiffon;
            listBoxHistory.Dock = DockStyle.Left;
            listBoxHistory.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxHistory.ForeColor = Color.DarkGreen;
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.IntegralHeight = false;
            listBoxHistory.ItemHeight = 21;
            listBoxHistory.Location = new Point(0, 63);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.SelectionMode = SelectionMode.MultiSimple;
            listBoxHistory.Size = new Size(399, 144);
            listBoxHistory.TabIndex = 6;
            listBoxHistory.DoubleClick += listBoxHistory_DoubleClick;
            // 
            // buttonClearHistory
            // 
            buttonClearHistory.BackColor = Color.Crimson;
            buttonClearHistory.Dock = DockStyle.Right;
            buttonClearHistory.FlatStyle = FlatStyle.Popup;
            buttonClearHistory.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClearHistory.ForeColor = Color.Gold;
            buttonClearHistory.Location = new Point(397, 63);
            buttonClearHistory.Name = "buttonClearHistory";
            buttonClearHistory.Padding = new Padding(10, 0, 10, 0);
            buttonClearHistory.Size = new Size(94, 144);
            buttonClearHistory.TabIndex = 7;
            buttonClearHistory.Text = "Clear";
            buttonClearHistory.UseVisualStyleBackColor = false;
            buttonClearHistory.Click += buttonClearHistory_Click;
            // 
            // FormReminder
            // 
            AcceptButton = buttonHide;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Bisque;
            ClientSize = new Size(491, 207);
            Controls.Add(buttonClearHistory);
            Controls.Add(listBoxHistory);
            Controls.Add(textBoxMessage);
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
            panelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutesToReappear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutesToReappear;
        private System.Windows.Forms.Label labelShowUpAgain;
        private System.Windows.Forms.Timer timer;
        private Button buttonHide;
        private TextBox textBoxMessage;
        private ListBox listBoxHistory;
        private Button buttonClearHistory;
    }
}

