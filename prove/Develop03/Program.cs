using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Load all scriptures from the text file
        string[] scriptureLines = File.ReadAllLines("bom-scripture.txt");

        // Create a list to store Scripture objects
        List<Scripture> scriptures = new List<Scripture>();

        // Parse each scripture line and create a Scripture object
        foreach (string scriptureLine in scriptureLines)
        {
            string[] parts = scriptureLine.Split('|');
            string referenceText = parts[0];
            string passageText = parts[1];
            Reference reference = new Reference(referenceText);
            Passage passage = new Passage(passageText);
            scriptures.Add(new Scripture(reference, passage));
        }

        // Display the list of available scriptures for the user to choose from
        Console.WriteLine("Available Scriptures:");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].Reference}");
        }

        // Prompt the user to choose a scripture
        int choice;
        do
        {
            Console.Write("Enter the number of the scripture you want to display: ");
        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > scriptures.Count);

        // Display the chosen scripture
        Scripture chosenScripture = scriptures[choice - 1];
        Console.WriteLine($"You've chosen: {chosenScripture.Reference}");

        // Display the scripture passage
        Console.WriteLine(chosenScripture.Passage);

        Console.WriteLine("Press Enter to hide a random word (or type 'quit' to exit):");

        // Continue hiding random words until all words are replaced
        while (!chosenScripture.AllWordsReplaced())
        {
            string input = Console.ReadLine().Trim();
            if (input.ToLower() == "quit")
                break;

            chosenScripture.HideRandomWord();
            Console.WriteLine(chosenScripture.Passage); // Display the updated scripture passage
        }

        Console.WriteLine("All words have been replaced. Press any key to exit.");
        Console.ReadKey();
    }
}
