using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string Name = UserName();
        int Number = FavoriteNumber();

        int NewNumber = CalculateSquared(Number);

        string NewSentence = DisplaySentence(NewNumber,Name);
    
    }


        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");

        }
        
        static string UserName()
        {
            Console.Write("What is your name?");
            string InputName = Console.ReadLine();

            return InputName;
        }

        static int FavoriteNumber()
        {
            Console.Write("What is your favorite number?");
            int UserNumber = int.Parse(Console.ReadLine());

            return UserNumber;
        }

        static int CalculateSquared(int Number)
        {
            int SquaredNumber = Number*Number;

            return SquaredNumber;
        }

        static string DisplaySentence(int NewNumber, string Name)
        {
            Console.WriteLine($"{Name}, your favorite number squared is {NewNumber}.");
            string Sentence = Console.ReadLine();

            return Sentence;
        }


    
}