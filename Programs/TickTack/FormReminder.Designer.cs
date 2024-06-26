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
        protected override void Dispose(bool disposing) {
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
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            timer = new System.Windows.Forms.Timer(components);
            panelHistory = new Panel();
            dataGridViewHistory = new DataGridView();
            panelTop = new Panel();
            panelConfig = new Panel();
            labelShowUpAgain = new Label();
            labelMinutes = new Label();
            numericUpDownMinutesToReappear = new NumericUpDown();
            buttonClearHistory = new Button();
            buttonStart = new Button();
            panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            panelTop.SuspendLayout();
            panelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutesToReappear).BeginInit();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // panelHistory
            // 
            panelHistory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHistory.BackColor = Color.OrangeRed;
            panelHistory.Controls.Add(dataGridViewHistory);
            panelHistory.Dock = DockStyle.Bottom;
            panelHistory.Location = new Point(0, 58);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(677, 366);
            panelHistory.TabIndex = 8;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistory.BackgroundColor = Color.NavajoWhite;
            dataGridViewHistory.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Dock = DockStyle.Fill;
            dataGridViewHistory.GridColor = Color.DeepPink;
            dataGridViewHistory.Location = new Point(0, 0);
            dataGridViewHistory.MultiSelect = false;
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewCellStyle2.BackColor = Color.PapayaWhip;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Crimson;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewHistory.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHistory.Size = new Size(677, 366);
            dataGridViewHistory.StandardTab = true;
            dataGridViewHistory.TabIndex = 11;
            dataGridViewHistory.CellDoubleClick += dataGridViewHistory_CellDoubleClick;
            dataGridViewHistory.CellValueChanged += dataGridViewHistory_CellValueChanged;
            dataGridViewHistory.UserDeletingRow += dataGridViewHistory_UserDeletingRow;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(panelConfig);
            panelTop.Controls.Add(buttonStart);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(677, 59);
            panelTop.TabIndex = 9;
            // 
            // panelConfig
            // 
            panelConfig.BackColor = SystemColors.GradientActiveCaption;
            panelConfig.Controls.Add(labelShowUpAgain);
            panelConfig.Controls.Add(labelMinutes);
            panelConfig.Controls.Add(numericUpDownMinutesToReappear);
            panelConfig.Controls.Add(buttonClearHistory);
            panelConfig.Dock = DockStyle.Fill;
            panelConfig.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            panelConfig.Location = new Point(0, 0);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(578, 59);
            panelConfig.TabIndex = 4;
            // 
            // labelShowUpAgain
            // 
            labelShowUpAgain.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            labelShowUpAgain.Location = new Point(250, 16);
            labelShowUpAgain.Name = "labelShowUpAgain";
            labelShowUpAgain.Size = new Size(84, 21);
            labelShowUpAgain.TabIndex = 5;
            labelShowUpAgain.Text = "Duration";
            labelShowUpAgain.TextAlign = ContentAlignment.TopRight;
            // 
            // labelMinutes
            // 
            labelMinutes.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            labelMinutes.Location = new Point(409, 16);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(76, 21);
            labelMinutes.TabIndex = 4;
            labelMinutes.Text = "minutes";
            // 
            // numericUpDownMinutesToReappear
            // 
            numericUpDownMinutesToReappear.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            numericUpDownMinutesToReappear.Location = new Point(339, 13);
            numericUpDownMinutesToReappear.Margin = new Padding(4, 3, 4, 3);
            numericUpDownMinutesToReappear.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownMinutesToReappear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMinutesToReappear.Name = "numericUpDownMinutesToReappear";
            numericUpDownMinutesToReappear.Size = new Size(63, 26);
            numericUpDownMinutesToReappear.TabIndex = 3;
            numericUpDownMinutesToReappear.TextAlign = HorizontalAlignment.Right;
            numericUpDownMinutesToReappear.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // buttonClearHistory
            // 
            buttonClearHistory.AutoSize = true;
            buttonClearHistory.BackColor = Color.Khaki;
            buttonClearHistory.Dock = DockStyle.Left;
            buttonClearHistory.FlatStyle = FlatStyle.Popup;
            buttonClearHistory.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            buttonClearHistory.ForeColor = Color.DarkGreen;
            buttonClearHistory.Location = new Point(0, 0);
            buttonClearHistory.Name = "buttonClearHistory";
            buttonClearHistory.Padding = new Padding(10, 0, 10, 0);
            buttonClearHistory.Size = new Size(157, 59);
            buttonClearHistory.TabIndex = 11;
            buttonClearHistory.Text = "Clear history";
            buttonClearHistory.UseVisualStyleBackColor = false;
            buttonClearHistory.Click += buttonClearHistory_Click;
            // 
            // buttonStart
            // 
            buttonStart.AutoSize = true;
            buttonStart.BackColor = Color.Indigo;
            buttonStart.Dock = DockStyle.Right;
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            buttonStart.ForeColor = Color.LightGray;
            buttonStart.Location = new Point(578, 0);
            buttonStart.Name = "buttonStart";
            buttonStart.Padding = new Padding(10, 0, 10, 0);
            buttonStart.Size = new Size(99, 59);
            buttonStart.TabIndex = 6;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // FormReminder
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Bisque;
            ClientSize = new Size(677, 424);
            Controls.Add(panelTop);
            Controls.Add(panelHistory);
            Font = new Font("Calibri", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormReminder";
            Opacity = 0.85D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reminder";
            Shown += FormReminder_Shown;
            panelHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelConfig.ResumeLayout(false);
            panelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutesToReappear).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Panel panelHistory;
        private Panel panelTop;
        private Button buttonStart;
        private Panel panelConfig;
        private Label labelShowUpAgain;
        private Label labelMinutes;
        private NumericUpDown numericUpDownMinutesToReappear;
        private DataGridView dataGridViewHistory;
        private Button buttonClearHistory;
    }
}

