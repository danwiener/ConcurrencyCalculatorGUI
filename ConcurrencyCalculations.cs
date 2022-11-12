using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Drawing;
using ConcurrencyCalculatorGUI;

//Created by Henrik Wiener : 11/3/2023
public class Concurrency : ILineEngine
{
	// Data components
	private object myLock = new object(); // for locking _sum

	Brush RedBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(242, 80, 34));
	Brush BlueBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(127, 186, 0));
	Brush GreenBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(0, 164, 239));
	Brush YellowBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 185, 0));

	// Data Fields
	private const double OneHundredMillion = 100_000_000;
	private const double TenBillion = 10_000_000_000;

	private double _sum; // sum of values

	private int maxVal;

	private bool done = false;

	private int[] theArray;

	private Graphics g;


	// Properties
	public TimeSpan ConcurrentTimeElapsed { get; set; }

	public void DoWork(int[] theArrayInp, Graphics gInp, int maxValInp, double sumParameter, Action<double> method)
	{
		done = false;
		Random rand = new Random();
		theArray = theArrayInp;
		g = gInp;
		maxVal = maxValInp;
		Task t = Task.Factory.StartNew(() => method(sumParameter));
		Task next = Task.Factory.StartNew(() =>
		{
			while (!done)
			{
				for (int i = 0; i < theArray.Length; i++)
				{
					if (i == theArray.Length - 1)
					{
						i = 0;
					}
					if (theArray[i] < maxVal - 3)
					{
						theArray[i] += rand.Next(0, 3);
					}
					else
					{
						theArray[i] = 4;
					}
					int j = 3;

					if (j == 1)
					{
						g.FillRectangle(RedBrush, i, theArray[i], 1, maxVal);
						j++;
					}
					else if (j == 2)
					{
						g.FillRectangle(BlueBrush, i, theArray[i], 1, maxVal);
						j++;
					}
					else if (j == 3)
					{
						g.FillRectangle(GreenBrush, i, theArray[i], 1, maxVal);
						j++;
					}
					else if (j == 4)
					{
						g.FillRectangle(YellowBrush, i, theArray[i], 1, maxVal);
						j = 1;
					}
				}

				if (t.IsCompleted)
				{
					done = true;
				}
			}
		});
	}

	// This method will concurrently run 8 threads each summing userSpecifiedSum/8 numbers to userSpecifiedSum
	public async void AddConcurrently(double sumTo)
	{
		if (sumTo % 8 != 0)
		{
			sumTo = sumTo + (sumTo % 8);
		} // ensure that sumTo number is divisible by 8

		Thread[] taskList = new Thread[8];

		double start = 1;
		double end = OneHundredMillion;

		Stopwatch sw = Stopwatch.StartNew();

		// Sum in increments of 100 million 100 times concurrently up to 10 billion
		for (int i = 0; i < 8; i++)
		{
			int index = i;
			taskList[index] = new Thread(() => AddToOneHundredMillion(start, end));
			taskList[index].Name = $"Thread({index})"; // Name thread

			// Optional parameterized Thread constructor:
			//taskList[index] = new Thread((begin) => AddToOneHundredMillion(start:(double)begin, end:(start + OneHundredMillion) - 1));
			//taskList[index].Start(start);

			// Ensure that thread starts before continuation of program
			Task task = Task.Factory.StartNew(() => taskList[index].Start());
			task.Wait();

			start += OneHundredMillion; // add 100 million
			end += OneHundredMillion; // add 100 million
		}
		// Wait for collection of tasks to finish running before stopping the stopwatch. 
		foreach (Thread t in taskList)
		{
			t.Join();
		}
		sw.Stop();

		ConcurrentTimeElapsed += sw.Elapsed;
		Console.WriteLine("Time elapsed: " + ConcurrentTimeElapsed);
		Console.WriteLine("Total sum: " + this._sum);
	} // end method

	// This method will add the sum of each number from 0 to 100 million
	public void AddToOneHundredMillion(double start, double end)
	{
		double sum = 0;
		//Stopwatch sw = Stopwatch.StartNew();
		for (double i = start; i <= end; i++)
		{
			sum += i;
		}

		//sw.Stop();
		//ConcurrentTimeElapsed += sw.Elapsed;
		//Console.WriteLine("Time elapsed: " + ConcurrentTimeElapsed);

		lock (myLock)
		{
			_sum += sum;
		}
		//Interlocked.Add(ref _sum, sum);
	} // end method 

	// This method syncrhonously sums to 10 billion.
	public void SumSynchronously(double sumTo)
	{
		double sum = 0;
		//double sum = (TenBillion * (TenBillion + 1)) / 2;     // Using Gauss Summation
		for (double i = 1; i <= sumTo; i++)
		{
			sum += i;
		}
		lock (myLock)
		{
			_sum += sum;
		}
	} // end method
} // end class