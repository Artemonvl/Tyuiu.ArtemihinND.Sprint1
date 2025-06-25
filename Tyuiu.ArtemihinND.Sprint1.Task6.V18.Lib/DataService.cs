using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ArtemihinND.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public string CheckNumber(string num1, string num2)
        {
            string cleanNum1 = num1.Replace("*", "");
            string cleanNum2 = num2.Replace("*", "");

            if (!IsDigitsOnly(cleanNum1) || !IsDigitsOnly(cleanNum2))
            {
                return "Invalid input";
            }

            return $"{cleanNum1}, {cleanNum2}";
        }

        public bool CheckNumber(string value)
        {

            string cleanValue = value.Replace("*", "");
            return IsDigitsOnly(cleanValue) && cleanValue.Length > 0;
        }

        private bool IsDigitsOnly(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
