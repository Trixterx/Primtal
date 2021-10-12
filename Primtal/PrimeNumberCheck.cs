using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Primtal
{
    class PrimeNumberCheck
    {

        public void Run()
        {
            Menu();
        }

        public void Menu()
        {
            bool run = true;
            do
            {
                Console.WriteLine("Write 0 to end program.");
                Console.WriteLine("Put in number to check if it's a Prime.");
                Int32.TryParse(Console.ReadLine(), out int inputNumber);
                if (inputNumber > 1)
                {
                    CheckPrimeNumber(inputNumber);
                }
                else
                {
                    Console.WriteLine("Wrong input, try again!");
                }

            } while (run);
        }

        public void CheckPrimeNumber(int inputNumber)
        {
            bool IsPrime = true;
            for (int i = 2; i <= inputNumber / 2; i++)
            {
                if (inputNumber % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.Write("Number is not Prime.");
            }
        }
    }
}
