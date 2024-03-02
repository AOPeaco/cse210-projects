using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        //  Console.WriteLine("What is the magic Number?");
        //  string numberString = Console.ReadLine();
        //  int number = int.Parse(numberString);

        Random randomNumberGenerator = new Random();
        int number = randomNumberGenerator.Next(1, 101);

        int guessNumber = -1;

        while (guessNumber != number)
        {
            Console.WriteLine("What is your guess?");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber == number)
            {
                Console.WriteLine("That's it! You got the magic number!");
            }
            else if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }

        } // This is the end of the loop
    }
}