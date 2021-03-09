using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter numbers: ");
                string inputString = Console.ReadLine();
                string[] numberStrings = inputString.Split(new char[] { ' ' });

                int sum = 0;
                foreach (string tempString in numberStrings)
                {
                    int tempNumber = 0;
                    if (Int32.TryParse(tempString, out tempNumber) == true)
                    {
                        sum += tempNumber;
                    }
                }

                Console.WriteLine("The sum is " + sum);
                Console.ReadKey();
            }
        }
    }
}
