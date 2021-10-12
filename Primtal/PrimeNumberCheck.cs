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
                Console.WriteLine("To end prog put in 0");
                Console.WriteLine("Hello, put in number to check if it's a Prime.");
                Int32.TryParse(Console.ReadLine(), out int inputNumber);
                bool nullcheck = string.IsNullOrEmpty(inputNumber.ToString());
                if (inputNumber == 0)
                {
                    run = false;
                }
                if (nullcheck || inputNumber > 2)
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
            bool isPrime = false;



        }
    }
}
