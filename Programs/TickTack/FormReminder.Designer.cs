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
            dataGridViewHistory = new DataGridView();
            panelTop = new Panel();
            progressBar = new ProgressBar();
            buttonEditHistory = new Button();
            buttonStart = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistory.BackgroundColor = Color.NavajoWhite;
            dataGridViewHistory.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 9F);
            dataGridViewCellStyle1.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Dock = DockStyle.Fill;
            dataGridViewHistory.GridColor = Color.DeepPink;
            dataGridViewHistory.Location = new Point(0, 34);
            dataGridViewHistory.MultiSelect = false;
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewCellStyle2.BackColor = Color.PapayaWhip;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Crimson;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewHistory.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHistory.Size = new Size(588, 538);
            dataGridViewHistory.StandardTab = true;
            dataGridViewHistory.TabIndex = 11;
            dataGridViewHistory.CellDoubleClick += dataGridViewHistory_CellDoubleClick;
            dataGridViewHistory.CellValueChanged += dataGridViewHistory_CellValueChanged;
            dataGridViewHistory.UserDeletingRow += dataGridViewHistory_UserDeletingRow;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.GradientActiveCaption;
            panelTop.Controls.Add(progressBar);
            panelTop.Controls.Add(buttonEditHistory);
            panelTop.Controls.Add(buttonStart);
            panelTop.Dock = DockStyle.Top;
            panelTop.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(588, 34);
            panelTop.TabIndex = 4;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Fill;
            progressBar.Location = new Point(85, 0);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(346, 34);
            progressBar.Step = 1;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 12;
            // 
            // buttonEditHistory
            // 
            buttonEditHistory.AutoSize = true;
            buttonEditHistory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEditHistory.BackColor = Color.Khaki;
            buttonEditHistory.Dock = DockStyle.Right;
            buttonEditHistory.FlatStyle = FlatStyle.Popup;
            buttonEditHistory.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            buttonEditHistory.ForeColor = Color.DarkGreen;
            buttonEditHistory.Location = new Point(431, 0);
            buttonEditHistory.Name = "buttonClearHistory";
            buttonEditHistory.Padding = new Padding(10, 0, 10, 0);
            buttonEditHistory.Size = new Size(157, 34);
            buttonEditHistory.TabIndex = 11;
            buttonEditHistory.Text = "Edit history";
            buttonEditHistory.UseVisualStyleBackColor = false;
            buttonEditHistory.Click += buttonEditHistory_Click;
            // 
            // buttonStart
            // 
            buttonStart.AutoSize = true;
            buttonStart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonStart.BackColor = Color.Indigo;
            buttonStart.Dock = DockStyle.Left;
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            buttonStart.ForeColor = Color.LightGray;
            buttonStart.Location = new Point(0, 0);
            buttonStart.Name = "buttonStart";
            buttonStart.Padding = new Padding(10, 0, 10, 0);
            buttonStart.Size = new Size(85, 34);
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
            ClientSize = new Size(588, 572);
            Controls.Add(dataGridViewHistory);
            Controls.Add(panelTop);
            Font = new Font("Calibri", 9F);
            MaximizeBox = false;
            Name = "FormReminder";
            Opacity = 0.85D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reminder";
            Shown += FormReminder_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Panel panelTop;
        private Button buttonStart;
        private DataGridView dataGridViewHistory;
        private Button buttonEditHistory;
        private ProgressBar progressBar;
    }
}

