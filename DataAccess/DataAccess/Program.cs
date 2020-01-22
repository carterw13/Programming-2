//Carter Williams
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            double val1, val2, val3;
            val1 = 28;
            val2 = 482.2;
            val3 = 382.222;
            double result = Add(5, 17.5);
            Console.WriteLine($"5 + 17.5 = {result.ToString("N2")}");
            result = Add(val1, val2);
            Console.WriteLine($"{val1} + {val2} = {result.ToString("N2")}");

            double[] nums = { val1, val2, val3 };
            nums = new double[3];
            nums[0] = val1;
            nums[1] = val2;
            nums[2] = val3;

            Console.ReadKey();
        }


        static double Add(double[] numbersToAddUp)
        {
            double r = 0;
            int counter = 0;
            while (counter < numbersToAddUp.Length)
            {
                var number = numbersToAddUp[counter];
                r += number;
                //r = r + number
                counter++;
            }

            for (counter = 0; counter < numbersToAddUp.Length; counter++)
            {
                var number = numbersToAddUp[counter];
                r += number;
            }

            foreach (var number in numbersToAddUp)
            {
                r += number;
            }
            
            return r;
        }



        //Red line at first means there is no return double
        //Calling the method: type method name, input parameters
        //Sums up two numbers and provides the result
        static double Add(double num1, double num2)
        {
            //if (num1 ==2)
            //{
            double sum = 0;
            sum = num1 + num2;
                
            //}
            //else
            //{
            //    sum = 3;
            //}
            return sum;
            
        }
    }
}
