using _7ShiftTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7ShiftTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorService cal = new CalculatorService();

            Console.Write("Enter input string: ");
           
            string input = Console.ReadLine();
           
            cal.Add(input);

        }
    }
}
