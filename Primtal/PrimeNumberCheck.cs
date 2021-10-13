using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Primtal
{
    internal class PrimeNumberCheck
    {
        /// <summary>
        /// List to add prime numbers to.
        /// </summary>
        private static List<int> primeList = new List<int>();

        /// <summary>
        /// Main menu
        /// </summary>
        public void MainMenu()
        {
            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Enter number to check if prime.");
                Console.WriteLine("2. Print list of prime numbers.");
                Console.WriteLine("3. Add next prime from highest in the list");
                Console.WriteLine("0. End program.");
                if (Int32.TryParse(Console.ReadLine(), out int input))
                {
                    switch (input)
                    {
                        case 1:
                            {
                                CheckPrimeNumberMenu();
                                Thread.Sleep(2000);
                                break;
                            }
                        case 2:
                            {
                                PrintAll();
                                Thread.Sleep(2000);
                                break;
                            }
                        case 3:
                            {
                                AddNextPrime();
                                Thread.Sleep(2000);
                                break;
                            }
                        case 0:
                            {
                                Console.WriteLine("Bye bye..");
                                run = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong input, try again!");
                                Thread.Sleep(2000);
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input, try again!");
                    Thread.Sleep(2000);
                }
            }
        }

        /// <summary>
        /// Method for adding next prime number from the list.
        /// </summary>
        private void AddNextPrime()
        {
            if (primeList.Count >= 1)
            {
                primeList.Sort();
                var lastPrime = primeList.Last<int>();
                if (lastPrime >= 2147483647)
                {
                    Console.WriteLine("The last number in the list is to big and cannot be calculated. This program is built using 32bit integers and can only handle 2147483647 numbers on the positive scale.");
                    Thread.Sleep(4000);
                }
                else
                {
                    primeList.Add(CheckLastPrime(lastPrime));
                }
            }
            else
            {
                Console.WriteLine("List is empty.");
                Thread.Sleep(2000);
            }
        }

        /// <summary>
        /// Method to print all the prime numbers that have been added to the list.
        /// </summary>
        private void PrintAll()
        {
            if (primeList.Count >= 1)
            {
                foreach (var prime in primeList)
                {
                    Console.WriteLine(prime);
                }
            }
            else
            {
                Console.WriteLine("List is empty.");
                Thread.Sleep(2000);
            }
        }

        /// <summary>
        /// Menu for checking if it's a prime number.
        /// </summary>
        private void CheckPrimeNumberMenu()
        {
            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("Enter number to check if it's a Prime.");
                if (Int32.TryParse(Console.ReadLine(), out int input))
                {
                    if (input <= 1)
                    {
                        Console.WriteLine("To low number. Only positive numbers over 2 is acceptable. Try again!");
                        Thread.Sleep(2000);
                    }
                    else if (input > 1)
                    {
                        if (CheckPrimeNumber(input))
                        {
                            Console.WriteLine("Number is Prime and was added to list.");
                            primeList.Add(input);
                        }
                        else
                        {
                            Console.WriteLine("Number is not Prime.");
                        }
                        Thread.Sleep(2000);
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, try again!");
                        Thread.Sleep(2000);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input, try again!");
                    Thread.Sleep(2000);
                }
            }
        }

        /// <summary>
        /// Method that checks if the input number is a prime number or not and returns a bool.
        /// </summary>
        /// <param name="input"></param>
        public bool CheckPrimeNumber(int input)
        {
            for (int i = 2; i <= input / 2; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Method uses the last prime number to get the next prime number and returns it.
        /// </summary>
        /// <param name="lastPrime"></param>
        /// <returns></returns>
        public int CheckLastPrime(int lastPrime)
        {
            for (int i = lastPrime + 1; i < 2 * lastPrime; i++)
            {
                if (CheckPrimeNumber(i))
                {
                    return i;
                }
            }
            return 0;
        }
    }
}