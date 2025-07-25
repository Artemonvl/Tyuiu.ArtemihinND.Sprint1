﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ArtemihinND.Sprint1.Task4.V18.Lib
{
    public class DataService : ISprint1Task4V18
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Sqrt(3 + x);
            double denominator = Math.Pow(x * y, 2);
            double result = numerator / denominator;

            return Math.Round(result, 3);
        }
    }
}
