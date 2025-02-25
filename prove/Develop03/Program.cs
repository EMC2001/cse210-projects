using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture(new Reference("Alma", 26, 11, 12), "But Ammon said unto him: I do not boast in my own strength, nor in my own wisdom; but behold, my joy is full, yea, my heart is brim with joy, and I will rejoice in my God.Yea, I know that I am nothing; as to my strength I am weak; therefore I will not boast of myself, but I will boast of my God, for in his strength I can do all things; yea, behold, many mighty miracles we have wrought in this land, for which we will praise his name forever.");
        
        while (!scripture.Hidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            break;

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine("Program finished");
  


    }
}