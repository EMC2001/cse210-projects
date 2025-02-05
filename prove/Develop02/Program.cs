using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        List<Prompt> prompts = new List<Prompt>
        {

        new Prompt("What was the best part of my day?"),
        new Prompt("Who made an impact in me today and why?"),
        new Prompt("Who did I helped today and how?"),
        new Prompt("How did I see the hand of the Lord in my life today?"),
        new Prompt("If I had one thing I could do over today, what would it be?")
        
        };
       
       Journal journal = new Journal();
       Random random = new Random();

        while (true)
        {
            Menu.DisplayMenu();
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                int index = random.Next(prompts.Count);
                string randomPrompt = prompts[index]._promptIdea;

                Console.WriteLine($"{randomPrompt}");
                Console.Write("Your response:");
                string response = Console.ReadLine();

                journal.addEntry(randomPrompt, response);
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nJournal Entries:");
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if(choice == "5") 
            {
                Console.WriteLine("Exiting Program");
                break;
            }
        }
    }    
}
