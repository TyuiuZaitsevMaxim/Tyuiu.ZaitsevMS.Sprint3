using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZaitsevMS.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string result = "";
            foreach (char chr in value)
            {
                if (char.IsDigit(chr))
                {
                    result += item;
                }
                else
                {
                    result += chr;
                }
            }
            return result;
        }
    }
}