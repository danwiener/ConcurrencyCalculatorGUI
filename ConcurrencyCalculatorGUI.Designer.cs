namespace ConcurrencyCalculatorGUI
{
	partial class ConcurrencyCalculatorGUI
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
			if (disposing && (components != null))
			{
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SynchButton = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.AsynchButton = new System.Windows.Forms.Button();
			this.SynchLabel = new System.Windows.Forms.Label();
			this.AsynchLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(26, 9, 0, 9);
			this.menuStrip1.Size = new System.Drawing.Size(1344, 54);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 44);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// SynchButton
			// 
			this.SynchButton.AccessibleName = "Synch";
			this.SynchButton.BackColor = System.Drawing.Color.LightGray;
			this.SynchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.SynchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SynchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SynchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.SynchButton.Location = new System.Drawing.Point(604, 76);
			this.SynchButton.Name = "SynchButton";
			this.SynchButton.Size = new System.Drawing.Size(165, 34);
			this.SynchButton.TabIndex = 3;
			this.SynchButton.Text = "Solve Synchronously";
			this.SynchButton.UseVisualStyleBackColor = false;
			this.SynchButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(239)))));
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.textBox2.Location = new System.Drawing.Point(201, 115);
			this.textBox2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(398, 34);
			this.textBox2.TabIndex = 5;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// AsynchButton
			// 
			this.AsynchButton.AccessibleName = "Synch";
			this.AsynchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.AsynchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.AsynchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AsynchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AsynchButton.ForeColor = System.Drawing.Color.LightGray;
			this.AsynchButton.Location = new System.Drawing.Point(604, 115);
			this.AsynchButton.Name = "AsynchButton";
			this.AsynchButton.Size = new System.Drawing.Size(165, 34);
			this.AsynchButton.TabIndex = 6;
			this.AsynchButton.Text = "Solve Asynchronously";
			this.AsynchButton.UseVisualStyleBackColor = false;
			this.AsynchButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// SynchLabel
			// 
			this.SynchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
			this.SynchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.SynchLabel.Location = new System.Drawing.Point(774, 76);
			this.SynchLabel.Name = "SynchLabel";
			this.SynchLabel.Size = new System.Drawing.Size(398, 34);
			this.SynchLabel.TabIndex = 7;
			this.SynchLabel.Text = "Time Elapsed: ";
			this.SynchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SynchLabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// AsynchLabel
			// 
			this.AsynchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
			this.AsynchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.AsynchLabel.Location = new System.Drawing.Point(774, 115);
			this.AsynchLabel.Name = "AsynchLabel";
			this.AsynchLabel.Size = new System.Drawing.Size(398, 34);
			this.AsynchLabel.TabIndex = 8;
			this.AsynchLabel.Text = "Time Elapsed: ";
			this.AsynchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.LightGray;
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.label4.Location = new System.Drawing.Point(96, 95);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(192, 57);
			this.label4.TabIndex = 9;
			this.label4.Text = "Sum To:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(80)))), ((int)(((byte)(34)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.LightGray;
			this.textBox1.Location = new System.Drawing.Point(201, 76);
			this.textBox1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(398, 34);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// ConcurrencyCalculatorGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 57F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1344, 740);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.AsynchLabel);
			this.Controls.Add(this.SynchLabel);
			this.Controls.Add(this.AsynchButton);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.SynchButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "ConcurrencyCalculatorGUI";
			this.Text = "Concurrency Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Button SynchButton;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button AsynchButton;
		private System.Windows.Forms.Label SynchLabel;
		private System.Windows.Forms.Label AsynchLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
	}
}

