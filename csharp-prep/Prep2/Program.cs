using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What score did you get?");
        string gradeString = Console.ReadLine();
        int gradePercentage = int.Parse(gradeString);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("You got a B!");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("You got a C!");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("You got a D!");
        }
        else if (gradePercentage <= 59)
        {
            Console.WriteLine("You got a F!");
        }
    }
}