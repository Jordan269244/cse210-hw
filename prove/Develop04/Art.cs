using System;


public class ArtActivity : Activity{

    private string[] _prompts = {
        //art includes drawing, painting, sculpting, and music
        "Abstract Emotional Art",
        "Base your Art off of nature",
        "Self Portrait- Art that reminds you of yourself",
        "Art that represents the milestones you have reached in life",
        "Fantasy world, let your imagination go wild",
        "A piece of Unity, something that unifed by their differences",
        "The beauty of relationships/connection",
        "The unseen forces in our lives, guiding angels",
        "Where is you happy or safe place",
        "A memory and the emotion that is assosaited with that memory"
     };

     public ArtActivity() : base("This activity will allow you to release emotion through the expression of art whether that be music or drawing! Don't think about it to much, just let your emotion flow into your art.")
    {
    }

     protected override void PerformActivity()
    {
        Console.WriteLine("Starting art activity...");
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(5000); 
        Console.WriteLine ($"Go ahead and follow the prompt. The sentence will disappear in {DurationInSeconds} seconds.");

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < DurationInSeconds)
        {
        }
        Console.WriteLine("Activity completed.");
        
    }

}