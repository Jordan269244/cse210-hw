using System;

// A code template for the category of things known as Journal Prompts
public class JournalPrompt
{
    // The C# convention is to start member variables with an underscore _

    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "If you could become an expert in any subject or activity, what would it be?",
            "What would you buy today if money were no object?",
            "How did you procrastinate on important tasks today?",
            "Who made your day better today?",
            "What is one thing you want to remember from today?",
            "What steps did you take today towards a goal you’re working on?",
            "How can you make tomorrow (even) better than today?",
            "What went well today?",
            "What was your magic power today?",
            "Identify three times that you felt challenged today.",
            "What do I need to let go of today?",
            "What do you need the most right now?",
            "If you could only accomplish three things tomorrow, what would they be?",
            "What was the most peaceful moment during the day?",
            "Did you watch a TV show today? If so what?"
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public JournalPrompt()
    {

    }
    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        
        return journalPrompt;
    }
}
