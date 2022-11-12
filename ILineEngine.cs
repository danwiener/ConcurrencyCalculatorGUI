﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyCalculatorGUI
{
	public interface ILineEngine
	{
		void DoWork(int[] theArray, Graphics g, int maxVal, double sumParameter, Action<double> method);
	}
}
