
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7ShiftTest.Services
{
    class CalculatorService
    {
        public int Add(string input)
        {

            //string input = "“//***\ndsada1fds***2***10”,3,4,2000,-3,--4";
            if (input.Length==0)
            {
                Console.WriteLine("Sum : " + input.Length.ToString());

                Console.Read();
            }
            int resultVal = 0;
            string pattern = @"-?\d+";
            List<int> negativeInt = new List<int>();

            var matches = Regex.Matches(input, pattern);

            StringBuilder negativeNumberList = new StringBuilder("Negative numbers in the string:");
            for (int i = 0; i < matches.Count; i++)
            {
                int result = 0;

                if (!string.IsNullOrEmpty(matches[i].ToString()) && int.TryParse(matches[i].ToString(), out result) && result > 0 && result <= 1000)
                {
                    resultVal = resultVal + result;
                }
                if (result < 0)
                {
                    negativeNumberList.Append(result.ToString() + ",");
                    negativeInt.Add(result);
                }


            }
            if (negativeInt.Count > 0)
            {

                Console.WriteLine(new Exception("Negatives not allowed."));
                Console.WriteLine(negativeNumberList.ToString().TrimEnd(','));
                Console.Read();

            }


            Console.WriteLine("Sum : " + resultVal.ToString());

            Console.Read();
            return resultVal;
        }
    }
}
