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
            while (run)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Enter number to check if Prime.");
                Console.WriteLine("2. Print the whole datastructure.");
                Console.WriteLine("3. Add next prime from highest in datastructure.");
                Console.WriteLine("0. End program.");
                Int32.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        {
                            CheckPrimeNumberMenu();
                            break;
                        }
                    case 2:
                        {
                            PrintAll();
                            break;
                        }
                    case 3:
                        {
                            AddNextPrime();
                            break;
                        }
                    case 0:
                        {
                            run = false;
                            break;
                        }
                }
            }
        }

        private void AddNextPrime()
        {
            throw new NotImplementedException();
        }

        private void PrintAll()
        {
            throw new NotImplementedException();
        }

        private void CheckPrimeNumberMenu()
        {
            bool run = true;
            
            while (run)
                {
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

            }
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
