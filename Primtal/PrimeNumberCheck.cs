using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Primtal
{
    class PrimeNumberCheck
    {
        public static List<int> primeList = new List<int>();

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
                Console.WriteLine("1. Enter number to check if prime.");
                Console.WriteLine("2. Print list of prime numbers.");
                Console.WriteLine("3. Add next prime from highest in the list");
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
                    default:
                        {
                            Console.WriteLine("Wrong input.");
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
                Console.WriteLine("Enter number to check if it's a Prime.");
                Int32.TryParse(Console.ReadLine(), out int input);
                if (input > 1)
                {
                    CheckPrimeNumber(input);
                    run = false;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again!");
                }

            }
        }

        public void CheckPrimeNumber(int input)
        {
            bool isPrime = true;
            for (int i = 2; i <= input / 2; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Number is Prime and was added to list.");
                primeList.Add(input);
            }
            else
            {
                Console.WriteLine("Number is not Prime.");
            }
        }
    }
}
