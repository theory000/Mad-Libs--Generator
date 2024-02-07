using System;

public class MadLibs
{
    public static void Main(string[] args)
    {
        // Story template with placeholders
        string story = "Once upon a time, there was a(n) {adjective} {noun} who lived in a {adjective} {noun}. " +
                      "One day, the {noun} decided to go on a {adjective} adventure. " +
                      "They encountered a {noun} and had to {verb} it. " +
                      "In the end, the {noun} learned a valuable {noun}.";

        // List of prompts and word types
        List<string> prompts = new List<string>()
        {
            "Adjective",
            "Noun",
            "Adjective",
            "Noun",
            "Noun",
            "Adjective",
            "Noun",
            "Verb",
            "Noun",
            "Noun"
        };

        // Get user input for each prompt
        List<string> words = new List<string>();
        foreach (string prompt in prompts)
        {
            Console.Write($"Enter a(n) {prompt}: ");
            words.Add(Console.ReadLine());
        }

        // Replace placeholders with user words
        for (int i = 0; i < prompts.Count; i++)
        {
            story = story.Replace("{" + prompts[i] + "}", words[i]);
        }

        // Print the completed story
        Console.WriteLine("\nYour Mad Libs story:\n");
        Console.WriteLine(story);
    }
}
