using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskMenu
{
    class TaskMenu
    {
        static void Main(string[] args)
        {
            /* 
             13. Write a program that can solve these tasks:
                       - Reverses the digits of a number
                       - Calculates the average of a sequence of integers
                       - Solves a linear equation a * x + b = 0
                  Create appropriate methods.
                  Provide a simple text-based menu for the user to choose which task to solve.
                  Validate the input data:
                       - The decimal number should be non-negative
                       - The sequence should not be empty
                       - a should not be equal to 0
            */
            Console.WriteLine("Choose an action from the menu and press ENTER:");
            Console.WriteLine("1 - Reverses the digits of a number;");
            Console.WriteLine("2 - Calculates the average of a sequence of integers;");
            Console.WriteLine("3 - Solves a linear equation a * x + b = 0.");
            Console.WriteLine();
            int menuChoice = int.Parse(Console.ReadLine());

            try
            {
                switch (menuChoice)
                {
                    case 1: ReverseDigits(); break;
                    case 2: CalculateAvarage(); break;
                    case 3: SolveLinearEquation(); break;
                    default: Console.WriteLine("Choose a correct action from the menu!"); break;
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static bool IsNonNegative(int number)
        {
            return number >= 0;
        }

        static bool IsNotEmpty(int[] numberArray)
        {
            return numberArray.Length > 0;
        }

        static bool IsNonZero(float number)
        {
            return number != 0;
        }

        static void ReverseDigits()
        {

            Console.WriteLine("Insert a whole number to reverse: ");
            int numberToReverse = int.Parse(Console.ReadLine());

            if (IsNonNegative(numberToReverse))
            {
                Console.WriteLine("The reversed number is: {0}", ReverseNumberM(numberToReverse));
            }
            else
            {
                Console.WriteLine("Wrong data! Insert a non negative number!");
            }

        }

        static void CalculateAvarage()
        {
            Console.WriteLine("How much numbers do you want to calculate?");
            int[] numberArray;
            int length;
            if
            (
                int.TryParse(Console.ReadLine(), out length)
            )
            {
                numberArray = new int[length];
            }
            else
            {
                throw new Exception("Error!");
            }

            ReadArrayNumbers(numberArray);
            double avarageSum = GetAvarage(numberArray);

            if (IsNotEmpty(numberArray))
            {
                Console.WriteLine("The avarage amount of the numbers is: {0}", avarageSum);
            }
            else
            {
                Console.WriteLine("You have to insert some numbers!");
            }
        }

        static void SolveLinearEquation()
        {
            Console.WriteLine("Insert two values for the equation (a * x + b = 0):");
            Console.WriteLine("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            float b = float.Parse(Console.ReadLine());

            if (IsNonZero(a))
            {
                Console.WriteLine("The solution of the equation ({0} * x + {1} = 0) is: {2}", a, b, CalculateEquation(a, b));
            }
            else
            {
                Console.WriteLine("Wrong data! 'a' can't be 0!");
            }
        }

        static int ReverseNumberM(int num)
        {
            int reversedNumber = 0;

            while (num > 0)
            {
                reversedNumber = reversedNumber * 10 + num % 10;
                num /= 10;
            }
            return reversedNumber;

        }

        static double GetAvarage(int[] numberArray)
        {
            double Sum = 0;
            foreach (int num in numberArray)
            {
                Sum += num;
            }
            return (Sum / numberArray.Length);
        }

        static float CalculateEquation(float a, float b)
        {
            return -b / a;  //a * x + b = 0
        }

        static void ReadArrayNumbers(int[] numberArray)
        {
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine("number {0} = ", i + 1);
                numberArray[i] = int.Parse(Console.ReadLine());
            }
        }

    }
}
