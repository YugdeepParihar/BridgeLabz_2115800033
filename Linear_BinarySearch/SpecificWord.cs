using System;

class Program
{
    static string FindSentenceWithWord(string[] sentences, string word)
    {
        // Iterate through each sentence
        foreach (string sentence in sentences)
        {
            // Check if the sentence contains the given word
            if (sentence.Contains(word))
            {
                return sentence; // Return the first sentence containing the word
            }
        }
        return "Not found"; // Return message if no sentence contains the word
    }

    static void Main()
    {
        string[] sentences = { "Hello Sir", "C# is", "Good language" };
        string word = "C#";
        Console.WriteLine("Sentence containing word: " + FindSentenceWithWord(sentences, word));
    }
}
