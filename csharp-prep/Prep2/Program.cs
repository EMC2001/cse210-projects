using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input your grade percentage:");
        string textPercentage = Console.ReadLine();
        int percentage = int.Parse(textPercentage);

        string letter =  "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if( percentage >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (percentage >=70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class, you can do it next time!");
        }
    }
}