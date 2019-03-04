using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Real Calculator          
            Console.WriteLine("Enter first number: ");
            string firstNum = Console.ReadLine();
            int firstNumParsed = int.Parse(firstNum);
            Console.WriteLine("Enter second number: ");
            string secondNum = Console.ReadLine();
            int secondNumParsed = int.Parse(secondNum);
            Console.WriteLine("Enter an operation: ");
            string oper = Console.ReadLine();
            char operatorParsed = char.Parse(oper);
            switch (operatorParsed)
            {
                case '+':
                    Console.WriteLine(firstNumParsed + " + " + secondNumParsed + " = " + (firstNumParsed + secondNumParsed));
                    break;
                case '-':
                    Console.WriteLine(firstNumParsed + " - " + secondNumParsed + " = " + (firstNumParsed - secondNumParsed));
                    break;
                case '*':
                    Console.WriteLine(firstNumParsed + " * " + secondNumParsed + " = " + (firstNumParsed * secondNumParsed));
                    break;
                case '/':
                    Console.WriteLine(firstNumParsed + " / " + secondNumParsed + " = " + (firstNumParsed / secondNumParsed));
                    break;
                default:
                    Console.WriteLine("Wrong operation entered");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
            #endregion
            #region Average of Four Numbers
            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a number: ");
                string num = Console.ReadLine();
                int numParsed = int.Parse(num);
                sum += numParsed;
            }
            Console.WriteLine("The average of the numbers entered is: " + (sum / 4));
            Console.WriteLine("Press any key");
            Console.ReadLine();
            #endregion
            #region Swap Numbers
            Console.WriteLine("Enter first number: ");
            string firstNumSwap = Console.ReadLine();
            // int firstNumSwapParsed = int.Parse(firstNumSwap);
            Console.WriteLine("Enter second number: ");
            string secondNumSwap = Console.ReadLine();
            // int secondNumSwapParsed = int.Parse(secondNumSwap);
            string temp = secondNumSwap;
            // Console.WriteLine("Temp is: " + temp);
            Console.WriteLine("First number before swapping is: " + firstNumSwap);
            Console.WriteLine("Second number before swapping is: " + secondNumSwap);
            secondNumSwap = firstNumSwap;
            Console.WriteLine("First number after swapping is: " + temp);
            Console.WriteLine("Second number after swapping is: " + secondNumSwap);
            Console.WriteLine("Press any key");
            Console.ReadLine();
            #endregion            
        }
    }
}