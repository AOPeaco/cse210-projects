using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What score did you get?");
        string gradeString = Console.ReadLine();
        int gradePercentage = int.Parse(gradeString);

        string letterGrade = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else if (gradePercentage <= 59)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"You got a {letterGrade}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else if (gradePercentage <= 69)
        {
            Console.WriteLine("Better luck next semester!");
        }
    }
}