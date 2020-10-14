using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace Lab4PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueAnswer = true;
            while (continueAnswer == true)
            {
                Console.WriteLine($"Welcome to Powers Table");
                Console.WriteLine("Please input an integer...");
                string inputInteger = (Console.ReadLine());
                Console.WriteLine("\n");

                int valid;
                bool parseSucces = int.TryParse(inputInteger, out valid);

                if (parseSucces)
                {
                    NumberTable(Convert.ToInt32(inputInteger)); SquaredTable(Convert.ToInt32(inputInteger)); CubedTable(Convert.ToInt32(inputInteger));

                    Console.WriteLine("Continue? y/n");
                    string answer = Console.ReadLine();

                    if (answer == "y")
                    {
                        continueAnswer = true;
                    }

                    if (answer == "n")
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Goodbye");
                        continueAnswer = false;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect input\n");
                    }
                }

                else
                { 
                    Console.WriteLine("This is not a number\n"); 
                }
            }
        }

        static void NumberTable(int Number)
        {
            Console.WriteLine("Number");
            Console.WriteLine("======");

            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }

        static void SquaredTable(int Square)
        {
            Console.WriteLine("Squared");
            Console.WriteLine("======");

            for (int i = 1; i <= Square; i++)
            {
                int squared = (i * i);
                Console.WriteLine(squared);
            }
            Console.WriteLine("\n");
        }

        static void CubedTable(int Cube)
        {
            Console.WriteLine("Cubed");
            Console.WriteLine("======");

            for (int i = 1; i <= Cube; i++)
            {
                int cubed = (i * i * i);
                Console.WriteLine(cubed);
            }
            Console.WriteLine("\n");
        }
    }
}
