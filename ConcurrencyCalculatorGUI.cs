using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyCalculatorGUI
{
	public partial class ConcurrencyCalculatorGUI : Form
	{
		// Data components
		Concurrency c = new Concurrency();

		object myLock = new object();

		// Data fields

		double sumParameter;

		public ConcurrencyCalculatorGUI()
		{
			InitializeComponent();
			//Binding binding = new Binding(c.timeElapsedStr, c, "Text", true, DataSourceUpdateMode.OnPropertyChanged, ControlUpdateMode.Never);
			//textBox4.DataBindings.Add(binding);

		}


		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		public void Alert()
		{
			Alert frm = new Alert(); // New alert window
			frm.showAlert();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			
			Stopwatch sw = new Stopwatch();
			try
			{
				sumParameter = Double.Parse($"{textBox1.Text}");
				c.SumSynchronously(sumParameter);
				
			}
			catch (FormatException fe)
			{
				this.Alert();
				textBox1.ResetText();
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

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
