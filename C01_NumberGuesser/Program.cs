﻿using System;

namespace C01_NumberGuesser
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a number guessing game
            // The user will get a prompt from which numbers he can choose (i.e.: number between 0 and 100)
            // A number will get randomly chosen
            // The user has to input a number he thinks might be correct
            // If the number is lower than the input, give the user a message
            // If the number is higher than the input, give the user a message
            // If the number is the input, give the user a message and ask for a retry
            // If the user types in a number out of range, provide the user a message and catch the crash

            Console.Title = "NumberGuesser.Console | by RayuDW";

            int randomNumber = GenerateRandomNumber();
            bool hasGuessedNumber = false;

            while (!hasGuessedNumber)
            {
                string numberGuess = AskForNumberInput();
                var conversionResult = Int16.TryParse(numberGuess, out short number);
                Console.Clear();
                
                if (conversionResult)
                {
                    if (number < randomNumber)
                    {
                        Console.WriteLine("Try a higher number!");
                    }

                    else if (number > randomNumber)
                    {
                        Console.WriteLine("Try a lower number!");
                    }

                    else
                    {
                        Console.WriteLine("That's the number!!");
                        hasGuessedNumber = true;
                        Console.WriteLine("> Press any key to exit!");
                    }
                }

                else
                {
                    // Fallback if input cannot be converted into a number
                    Console.WriteLine($"ERROR: Could not convert '{numberGuess}'!");
                }
            }
            
            Console.ReadKey();
            Environment.Exit(0);
        }

        private static int GenerateRandomNumber()
        {
            // Generate a random number between 0 and 100
            Random rng = new Random();
            int randomNumber = rng.Next(0, 101);
            Console.WriteLine($"DEBUG: The drawn number is {randomNumber}!!");

            return randomNumber;
        }

        private static string AskForNumberInput()
        {
            Console.WriteLine("Enter a number between 0 and 100:");
            Console.Write("> ");

            string numberGuess = Console.ReadLine();
            return numberGuess;
        }
    }
}