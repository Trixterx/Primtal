﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Primtal
{
    class PrimeNumberCheck
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
                                run = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong input.");
                                Thread.Sleep(2000);
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }

        private void AddNextPrime()
        {
            primeList.Sort();
            var lastPrime = primeList.Last<int>();
            Console.WriteLine(lastPrime);
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Method to print all the prime numbers that have been added to the list.
        /// </summary>
        private void PrintAll()
        {
            foreach(var prime in primeList)
            {
                Console.WriteLine(prime);
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
                        Console.WriteLine("To low! Only numbers over 2 is possible prime numbers. Try again!");
                        Thread.Sleep(2000);
                    }
                    else if (input > 1)
                    {
                        CheckPrimeNumber(input);
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
                }
            }
        }

        /// <summary>
        /// Method that checks if the input number is a prime number or not.
        /// </summary>
        /// <param name="input"></param>
        public void CheckPrimeNumber(int input)
        {
            bool prime = true;
            for (int i = 2; i <= input / 2; i++)
            {
                if (input % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
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
