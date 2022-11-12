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
			this.components = new System.ComponentModel.Container();
			this.SynchButton = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.AsynchTextBox = new System.Windows.Forms.TextBox();
			this.AsynchButton = new System.Windows.Forms.Button();
			this.SynchLabel = new System.Windows.Forms.Label();
			this.AsynchLabel = new System.Windows.Forms.Label();
			this.SumToLabel = new System.Windows.Forms.Label();
			this.SynchTextBox = new System.Windows.Forms.TextBox();
			this.SynchTimer = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.ResetButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SynchButton
			// 
			this.SynchButton.AccessibleName = "Synch";
			this.SynchButton.BackColor = System.Drawing.Color.LightGray;
			this.SynchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.SynchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SynchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SynchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.SynchButton.Location = new System.Drawing.Point(604, 26);
			this.SynchButton.Name = "SynchButton";
			this.SynchButton.Size = new System.Drawing.Size(165, 34);
			this.SynchButton.TabIndex = 3;
			this.SynchButton.Text = "Sum Synchronously";
			this.SynchButton.UseVisualStyleBackColor = false;
			this.SynchButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// AsynchTextBox
			// 
			this.AsynchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(239)))));
			this.AsynchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AsynchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AsynchTextBox.ForeColor = System.Drawing.Color.LightGray;
			this.AsynchTextBox.Location = new System.Drawing.Point(303, 65);
			this.AsynchTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.AsynchTextBox.Multiline = true;
			this.AsynchTextBox.Name = "AsynchTextBox";
			this.AsynchTextBox.Size = new System.Drawing.Size(296, 34);
			this.AsynchTextBox.TabIndex = 5;
			this.AsynchTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// AsynchButton
			// 
			this.AsynchButton.AccessibleName = "Synch";
			this.AsynchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.AsynchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.AsynchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AsynchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AsynchButton.ForeColor = System.Drawing.Color.LightGray;
			this.AsynchButton.Location = new System.Drawing.Point(604, 65);
			this.AsynchButton.Name = "AsynchButton";
			this.AsynchButton.Size = new System.Drawing.Size(165, 34);
			this.AsynchButton.TabIndex = 6;
			this.AsynchButton.Text = "Sum Asynchronously";
			this.AsynchButton.UseVisualStyleBackColor = false;
			this.AsynchButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// SynchLabel
			// 
			this.SynchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
			this.SynchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.SynchLabel.Location = new System.Drawing.Point(774, 26);
			this.SynchLabel.Name = "SynchLabel";
			this.SynchLabel.Size = new System.Drawing.Size(296, 34);
			this.SynchLabel.TabIndex = 7;
			this.SynchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SynchLabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// AsynchLabel
			// 
			this.AsynchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
			this.AsynchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.AsynchLabel.Location = new System.Drawing.Point(774, 65);
			this.AsynchLabel.Name = "AsynchLabel";
			this.AsynchLabel.Size = new System.Drawing.Size(296, 34);
			this.AsynchLabel.TabIndex = 8;
			this.AsynchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SumToLabel
			// 
			this.SumToLabel.AutoSize = true;
			this.SumToLabel.BackColor = System.Drawing.Color.LightGray;
			this.SumToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.SumToLabel.Location = new System.Drawing.Point(198, 45);
			this.SumToLabel.Margin = new System.Windows.Forms.Padding(0);
			this.SumToLabel.Name = "SumToLabel";
			this.SumToLabel.Size = new System.Drawing.Size(192, 57);
			this.SumToLabel.TabIndex = 9;
			this.SumToLabel.Text = "Sum To:";
			this.SumToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SynchTextBox
			// 
			this.SynchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(80)))), ((int)(((byte)(34)))));
			this.SynchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SynchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SynchTextBox.ForeColor = System.Drawing.Color.LightGray;
			this.SynchTextBox.Location = new System.Drawing.Point(303, 26);
			this.SynchTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.SynchTextBox.Multiline = true;
			this.SynchTextBox.Name = "SynchTextBox";
			this.SynchTextBox.Size = new System.Drawing.Size(296, 34);
			this.SynchTextBox.TabIndex = 2;
			this.SynchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// SynchTimer
			// 
			this.SynchTimer.Enabled = true;
			this.SynchTimer.Interval = 10;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Location = new System.Drawing.Point(25, 150);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1289, 578);
			this.panel1.TabIndex = 10;
			// 
			// ResetButton
			// 
			this.ResetButton.BackColor = System.Drawing.Color.LightGray;
			this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ResetButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResetButton.Location = new System.Drawing.Point(1075, 45);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(100, 34);
			this.ResetButton.TabIndex = 11;
			this.ResetButton.Text = "Reset";
			this.ResetButton.UseVisualStyleBackColor = false;
			this.ResetButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// ConcurrencyCalculatorGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 57F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1344, 740);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.SumToLabel);
			this.Controls.Add(this.AsynchLabel);
			this.Controls.Add(this.SynchLabel);
			this.Controls.Add(this.AsynchButton);
			this.Controls.Add(this.AsynchTextBox);
			this.Controls.Add(this.SynchButton);
			this.Controls.Add(this.SynchTextBox);
			this.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "ConcurrencyCalculatorGUI";
			this.Text = "Concurrency Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button SynchButton;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox AsynchTextBox;
		private System.Windows.Forms.Button AsynchButton;
		private System.Windows.Forms.Label AsynchLabel;
		private System.Windows.Forms.Label SumToLabel;
		private System.Windows.Forms.TextBox SynchTextBox;
		internal System.Windows.Forms.Label SynchLabel;
		private System.Windows.Forms.Timer SynchTimer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button ResetButton;
	}
}

