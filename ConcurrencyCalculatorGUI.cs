using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

		double sumParameter;

		public ConcurrencyCalculatorGUI()
		{
			InitializeComponent();
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

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				sumParameter = Double.Parse(textBox1.Text);
				c.SumSynchronously(sumParameter);
				

			}
			catch (FormatException fe)
			{
				Console.WriteLine("Invalid input. Please enter a valid number up to 100 billion.");
				textBox1.Text = "Invalid input. Please enter a valid number up to 100 billion.";

				var formPopup = new Form();
				formPopup.Show(this);
				formPopup.Text = "Invalid input.";
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}


	}
}
