using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Answer to the first exercise:
            int height_cm;
            Console.WriteLine("Please enter your height in centimeters:");
            height_cm = int.Parse(Console.ReadLine());
            double height_m = (double) height_cm / 100;
            Console.WriteLine("The measurement of your height in meters is:"+height_m);
            double height_inches = (double)height_cm / 2.54;
            Console.WriteLine("The measurement for your height in inches is:"+height_inches);
            // Answer to the second exercise:
            Console.WriteLine("Please, enter the first number here:");
            int first_int_num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second number here:");
            int second_int_num = int.Parse(Console.ReadLine());
            int sum = first_int_num + second_int_num;
            Console.WriteLine("The sum of the two numbers is:"+sum);
            Console.WriteLine("From which number would you like to subtract the other number? From the first number (1) or from the second number (2)?");
            byte question = byte.Parse(Console.ReadLine());
            if (question == 1)
            {
                int sub = first_int_num - second_int_num;
                Console.WriteLine("The difference between the two numbers is:"+sub);
            }
            else if (question == 2)
            {
                int sub = second_int_num - first_int_num;
                Console.WriteLine("The difference between the two numbers is:" + sub);
            }
            else{
                Console.WriteLine(false);
            }
            int mul = first_int_num * second_int_num;
            Console.WriteLine("The product of the two numbers is:"+mul);
            double the_exact_division_result;
            the_exact_division_result = (double)first_int_num / second_int_num;
            Console.WriteLine("The exact division result is:" + the_exact_division_result);
            double the_inaccurate_division_result;
            the_inaccurate_division_result = first_int_num / second_int_num;
            Console.WriteLine("The inaccurate division result is:" + the_inaccurate_division_result);
            Console.ReadKey();
        }
    }
}
