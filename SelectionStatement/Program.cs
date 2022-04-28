using System;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess my favorite number!");
            Console.WriteLine("What is your upper limit for the range of number?");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);
            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Take your guess!");

            var guess = int.Parse(Console.ReadLine());
            do 
            if (guess > number) 
            {
                Console.WriteLine(" Your number is too high.");
            }

            else if (guess < number)
            {
                Console.WriteLine("Your number is too low.");

            }

            else (guess)

            {
                Console.WriteLine("Great job! Your guess is correct!");

            }
               
         
            while(guess != number)
            {
                Console.WriteLine("Nevermind.");
            }
  
    