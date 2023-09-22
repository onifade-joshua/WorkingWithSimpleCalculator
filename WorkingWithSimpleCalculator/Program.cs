using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumNumber1;
            int sumNumber2;

            int result;

            string userAnswer;


            Console.WriteLine("Hello, welcome to the calculator app");
            Console.WriteLine("Please enter your first number");
            sumNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's your second number");
            sumNumber2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation will you like to do?");
            Console.WriteLine("Please enter a for addition, enter m for multiplication, enter d for division, enter s for subtraction");

            userAnswer = Console.ReadLine();    

            if(userAnswer == "a")
            {
                result = sumNumber1 + sumNumber2;

            }else if(userAnswer == "m")
            {
                result = sumNumber1 * sumNumber2;

            }else if(userAnswer == "d") {

                result = sumNumber1 / sumNumber2;
            }
            else
            {
                result = sumNumber1 - sumNumber2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using the calculator.");
            
            
            Console.ReadKey();
        }
    }
}
