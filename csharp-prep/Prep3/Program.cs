using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        int number = int.Parse(Console.ReadLine());

        int guess = 0;
    
        while (guess != number)
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if(number > guess)
            Console.WriteLine("Higher");

            else if(number < guess)
            Console.WriteLine("Lower");

            else
            Console.WriteLine("You guessed it!");

        } 
    }
}