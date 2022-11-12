using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics.Eventing.Reader;

namespace ConcurrencyCalculatorGUI
{
	public partial class ConcurrencyCalculatorGUI : Form
	{
		// Data components
		Concurrency c = new Concurrency();

		Graphics g;

		System.Timers.Timer timer;

		// Data fields

		double sumParameter;

		int h, m, s, ms;

		int[] theArray;

		int maxVal;

		public ConcurrencyCalculatorGUI()
		{
			InitializeComponent();
			Task timerTask = Task.Factory.StartNew(() =>
			{
				timer = new System.Timers.Timer();
				timer.Interval = 1;
				timer.Elapsed += timerTick;
			});
		}
		private void timerTick(object sender, ElapsedEventArgs e)
		{
			Task t = Task.Factory.StartNew(() =>
			{
				Invoke(new Action(() =>
				{
					ms++;
					if (ms == 1000)
					{
						s++;
						ms = 0;
					}
					if (s == 60)
					{
						m++;
						s = 0;
					}
					if (m == 60)
					{
						h++;
						m = 0;
					}
					SynchLabel.Text = string.Format("Time Elapsed: {0:00}:{1:00}:{2:00}:{3:00}", h, m, s, ms / 10);
				}));
			});
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			SynchLabel.Text = "Time Elapsed: 00:00:00:00";
			AsynchLabel.Text = "Time Elapsed: 00:00:00:00";

		}


		// SynchSum Button eventhandler method
		private async void button1_Click(object sender, EventArgs e)
		{
			try
			{
				graphicsDo();
				SynchLabel.ResetText();
				sumParameter = Double.Parse($"{SynchTextBox.Text}");
				c.DoWork(theArray, g, maxVal, sumParameter, c.SumSynchronously);
			}
			catch (FormatException fe)
			{
				this.Alert();
				SynchTextBox.ResetText();
			}
			finally
			{
				h = 0; m = 0; s = 0; ms = 0;
				timer.Start();
				Task t = Task.Factory.StartNew(() => timer.Start());
				await Task.Run(() => c.SumSynchronously(sumParameter));
				timer.Stop();
			}
		}


		// Alert for invalid format inputted into textbox
		public void Alert()
		{
			Alert frm = new Alert(); // New alert window
			frm.showAlert();
		}

		// Exit button in menu bar
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}
		public void graphicsDo()
		{
			g = panel1.CreateGraphics(); // Create new graphics panel
			int numEntries = panel1.Width;
			maxVal = panel1.Height;
			g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(115, 115, 115)), 0, 0, numEntries, maxVal);
			Random rand = new Random();
			theArray = new int[numEntries];
			int current = maxVal - 50;
			for (int i = 0; i < numEntries; i++)
			{
				int j = 1;

				if (j == 1)
				{
					g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(242, 80, 34)), i, current, 1, maxVal);
					j++;
				}
				else if (j == 2)
				{
					g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(0, 164, 239)), i, current, 1, maxVal);
					j++;
				}
				else if (j == 3)
				{
					g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(127, 86, 0)), i, current, 1, maxVal);
					j++;
				}
				else if (j == 4)
				{
					g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 185, 0)), i, current, 1, maxVal);
					j = 1;
				}
				if (i % 4 == 0)
				{
					current -= rand.Next(0, 4);
				}
				theArray[i] = current;
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			graphicsDo();
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
