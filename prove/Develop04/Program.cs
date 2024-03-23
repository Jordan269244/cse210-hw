using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
         bool exit = false;
        
        while (!exit)
        {
            Console.WriteLine("Relaxation Activities Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Art Prompt Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option: ");

            // Read user input
            string choice = Console.ReadLine();

            // Process user choice
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Starting Breathing Activity...");
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    break;
                case "2":
                    Console.WriteLine("Starting Listing Activity...");
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    break;
                case "3":
                    Console.WriteLine("Starting Reflection Activity...");
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start();
                    break;
                case "4":
                    Console.WriteLine("Starting Art Actvitiy...");
                    ArtActivity artActivity = new ArtActivity();
                    artActivity.Start(); 
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }

        }
    }
}
    
