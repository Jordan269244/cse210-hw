using System;
using System.Collections.Generic;
using System.Linq;

class Passage
{
    public List<Word> Words { get; } 

    private Random _random; 
    private HashSet<int> _hiddenIndices; // Set to keep track of hidden word indices

    public Passage(string passageText)
    {
        Words = new List<Word>(); 
        _random = new Random(); 
        _hiddenIndices = new HashSet<int>(); 
        string[] wordArray = passageText.Split(' ');
        foreach (string wordText in wordArray)
        {
            Words.Add(new Word(wordText)); 
        }
    }

    // Method to hide a random word
    public void _HideRandomWord()
    {
        // Generate a random index
        int randomIndex;
        do
        {
            randomIndex = _random.Next(0, Words.Count);
        } while (_hiddenIndices.Contains(randomIndex)); // Ensure the word hasn't already been hidden
        // Mark the word at the random index as hidden
        Words[randomIndex]._hide();
        // Add the index to the set of hidden indices
        _hiddenIndices.Add(randomIndex);
    }

    // Method to check if all words in the passage have been replaced with underscores
    public bool _AllWordsReplaced()
    {
        return Words.All(word => word._isHidden);
    }

    public override string ToString()
    {
        // Construct the passage text by joining the words with spaces
        return string.Join(" ", Words.Select(word => word._isHidden ? new string('_', word.Text.Length) : word.Text));
    }
}