namespace TickTack
{
	partial class FormLembrete
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
			this.buttonOk = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelMinutos = new System.Windows.Forms.Label();
			this.numericUpDownTempoEmMinutos = new System.Windows.Forms.NumericUpDown();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelOrientação = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempoEmMinutos)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonOk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOk.Location = new System.Drawing.Point(0, 210);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(307, 45);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Info;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.labelOrientação);
			this.panel1.Controls.Add(this.labelMinutos);
			this.panel1.Controls.Add(this.numericUpDownTempoEmMinutos);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(307, 34);
			this.panel1.TabIndex = 3;
			// 
			// labelMinutos
			// 
			this.labelMinutos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMinutos.Location = new System.Drawing.Point(233, 5);
			this.labelMinutos.Name = "labelMinutos";
			this.labelMinutos.Size = new System.Drawing.Size(67, 20);
			this.labelMinutos.TabIndex = 4;
			this.labelMinutos.Text = "minutos";
			// 
			// numericUpDownTempoEmMinutos
			// 
			this.numericUpDownTempoEmMinutos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownTempoEmMinutos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownTempoEmMinutos.Location = new System.Drawing.Point(157, 3);
			this.numericUpDownTempoEmMinutos.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDownTempoEmMinutos.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownTempoEmMinutos.Name = "numericUpDownTempoEmMinutos";
			this.numericUpDownTempoEmMinutos.Size = new System.Drawing.Size(72, 27);
			this.numericUpDownTempoEmMinutos.TabIndex = 3;
			this.numericUpDownTempoEmMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDownTempoEmMinutos.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
			// 
			// textBox1
			// 
			this.textBox1.AcceptsReturn = true;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.textBox1.Location = new System.Drawing.Point(0, 34);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(307, 176);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Digite a mensagem aqui...";
			// 
			// labelOrientação
			// 
			this.labelOrientação.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOrientação.Location = new System.Drawing.Point(3, 6);
			this.labelOrientação.Name = "labelOrientação";
			this.labelOrientação.Size = new System.Drawing.Size(152, 20);
			this.labelOrientação.TabIndex = 5;
			this.labelOrientação.Text = "Volte a aparecer em";
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// FormLembrete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 255);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonOk);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLembrete";
			this.Opacity = 0.95;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lembrete";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempoEmMinutos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelMinutos;
		private System.Windows.Forms.NumericUpDown numericUpDownTempoEmMinutos;
		private System.Windows.Forms.Label labelOrientação;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Timer timer;
	}
}

