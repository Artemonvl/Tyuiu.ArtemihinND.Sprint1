using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ArtemihinND.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            double term1 = Math.Sin(Math.Sqrt(x * x));
            double term2 = Math.Cos(x * x) / (3 * x * x * x);
            double term3 = Math.Sin(Math.Sqrt(x * x - 1));

            double result = term1 + term2 - term3;
            return Math.Round(result, 3);
        }
    }
}
