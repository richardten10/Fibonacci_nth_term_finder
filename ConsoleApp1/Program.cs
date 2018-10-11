﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Which element n of the fibonacci sequence do you want?");
          String input = Console.ReadLine();
          int element;
          bool checkInt = false;

            do {
                try
                {
                    int test = int.Parse(input);
                    checkInt = true;
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("Please enter an integer");
                    input = Console.ReadLine();
                }
            } while (checkInt == false);

            element = int.Parse(input);
            var result = -1; // negative output means something went wrong
            result = functions.fib(element);
            Console.WriteLine("The nth number in the fibonacci sequence (for n = " + element + ") is: " + result);
        }

        class functions
        {
            public static int fib(int input)
            {
                var nToReturn = -1;
                int x = 0;
                int y = 1;
                int counter = input - 2;

                if (input - 1 == 0)
                {
                    return 0;
                }
                else if (input - 1 == 1)
                {
                    return 1;
                }
                else
                {
                    for (int j = 0; j < counter; j++)
                    {
                        nToReturn = y + x;
                        x = y;
                        y = nToReturn;
                    }
                    return nToReturn;
                }
            }
            public static void setUp()
            {
                
            }
        }
    }
}