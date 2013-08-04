using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace EratosthenesAlgorithm
{
    class EratosthenesAlgorithm
    {
        static void Main(string[] args)
        {
            /*
            Write a program that finds all prime numbers in the range [1...10 000 000]. 
            Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
            */

            int maxNumber = 100000;

            List<int> primeNumbers = new List<int>();
            int PrimesCount;

            initializeList(primeNumbers, maxNumber);
            PrimeNumbers(maxNumber, primeNumbers, out PrimesCount);
            WriteIntArr(primeNumbers, PrimesCount);
        }

        static void initializeList(List<int> primeNumbers, int maxNumber)
        {
            for (int i = 0; i <= maxNumber; i++)
            {
                primeNumbers.Add(i);
            }
        }

        static void PrimeNumbers(int maxNumber, List<int> primeNumbers, out int PrimesCount)
        {         
            PrimesCount = 0;

            for (int i = 2; i < maxNumber; i++)
                if (PrimeNum(primeNumbers[i]))
                {
                    for (int j = i * 2; j <= maxNumber; j += i)
                    {
                        primeNumbers[j] = 0;
                    }
                }

            foreach (int num in primeNumbers)
            {
                if (num != 0)
                {
                    PrimesCount++;
                }                
            }            
        }        

        static void WriteIntArr(List<int> primeNumbers, int PrimesCount)
        {
            Console.Out.WriteLine("Primes numbers are {0}: ", PrimesCount);
            foreach (int num in primeNumbers)
            {
                if (num != 0)
                {
                    Console.Write("{0}  ", num);
                }                
            }
            Console.WriteLine();
        }

        static bool PrimeNum(int Number)
        {
            bool prime = true;
            int divider = 2;
            while (divider <= Math.Sqrt(Number))
            {
                if (Number % 2 == 0)
                {
                    prime = false;
                    break;
                }
                divider++;
            }
            return prime;
        }


    }
}
