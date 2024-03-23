 
public class ReflectionActivity: Activity
{
    private string[] _prompts = {
        "What are three things that went well today?",
        "What is one thing you learned about yourself recently?",
        "What are you grateful for in your life right now?",
        "What is a challenge you've faced recently, and how did you handle it?",
        "Describe a moment when you felt proud of yourself.",
        "Reflect on a mistake you made recently. What did you learn from it?",
        "What is something you'd like to improve about yourself, and how do you plan to work on it?",
        "Describe a person who has had a positive impact on your life and why.",
        "What are your top priorities at the moment, and how are you working towards them?",
        "Reflect on a recent accomplishment and the effort it took to achieve it.",
        "How do you typically deal with stress, and is there a healthier way you could manage it?",
        "Describe a moment when you felt at peace with yourself and your surroundings.",
        "Reflect on a difficult decision you've had to make recently. How did you arrive at your decision?",
        "What is something you've been avoiding that you know you need to address? How can you take steps towards addressing it?",
        "Describe a time when you helped someone else and how it made you feel."
    };

    public ReflectionActivity() : base("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Starting reflection activity...");
        Random random = new Random();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < DurationInSeconds)
        {
           string prompt = _prompts[random.Next(_prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(10000); 
            // Ask reflection questions (not implemented here)
        }
    }
}













