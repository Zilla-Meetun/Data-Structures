using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string input;
            Console.WriteLine("Enter 1st Number :");
            input = Console.ReadLine();  //waits for user to hit return
            num1 = Convert.ToInt32(input);
            Console.WriteLine("Enter 2nd Number :");
            input = Console.ReadLine();
            num2 = Convert.ToInt32(input);
            Console.WriteLine("Sum is : {0}", sum(num1, num2));
            Console.WriteLine("{0} to the Power of {1} : {2}",num1, num2, power(num1, num2));
            average();

            //{0} takes 1st argument and substitutes into string
            Console.ReadKey();  //waits for a key to press before ending
        }

        static int sum(int x, int y)
        {
            return x + y;
        }

        static int power(int x, int y)
        {
            int power = 1;
            while (y!=0)
            {
                power = power * x;
                y--;
            }
            return power;
        }

        static int average()
        {
            int average = 0;
            int cocunt = 0;
            
            while (input != 0)
            {
                Console.WriteLine("Enter a number");
                input = Console.ReadLine();  //waits for user to hit return
                average = average + Convert.ToInt32(input);
                count++;
            }
            average = average / count;
            Console.WriteLine("the average is {0}", average);

            return average;

        }
    }
}

