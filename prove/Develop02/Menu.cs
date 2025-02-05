using System;

class Menu
{
    public static void DisplayMenu()
    {
        Console.WriteLine("1.- Write a new journal entry");
        Console.WriteLine("2.- View past entries");
        Console.WriteLine("3.- Save journal to file");
        Console.WriteLine("4.- Load journal from file");
        Console.WriteLine("5.- Exit");
        Console.Write("Choose an option: ");
    }
}
