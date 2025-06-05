using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ArtemihinND.Sprint1.Task2.V15.Lib
{
    public class DataService : ISprint1Task2V15
    {
        public int CalculateCubeVolume(int value)
        {
            return value * value * value;
        }
    }
}
