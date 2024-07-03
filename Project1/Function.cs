using System;
using System.Collections.Generic;
using Newtonsoft.Json; // Add this directive for JSON serialization
using System.IO;

namespace Project1
{
    internal class Function
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public void AddEnglishWord()
        {
            Console.Write("Enter the English word: ");
            string? englishWord = Console.ReadLine();
            Console.Write("Enter the Khmer Word: ");
            string? khmerWord = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(englishWord) && !string.IsNullOrWhiteSpace(khmerWord))
            {
                dictionary[englishWord] = khmerWord; // Add to dictionary

                //Serialize dictionary to JSON
                string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);

                //Save JSON to file
                string filePath = @"D:\C#\Project1.json";
                //System.IO.File.WriteAllText(@"D:\C#\Project1.json", json);
                try  
                {
                    System.IO.File.WriteAllText(filePath, json);
                    Console.WriteLine("Word added successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
                }

            }
            else
            {
                Console.WriteLine("Invalid input. Word not added.");
            }
        }

        public void ReplaceWord()
        {
            Console.Write("Enter the English word to replace: ");
            string? khmerWord = Console.ReadLine();
            if (dictionary.ContainsKey(khmerWord))
            {
                Console.Write("Enter the new new Khmer Word: ");
                string? newKhmerWord = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newKhmerWord))
                {
                    dictionary[khmerWord] = newKhmerWord; // Replace in dictionary
                    Console.WriteLine("Word replaced successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Word not replaced.");
                }
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }

        public void DeleteWord()
        {
            Console.Write("Enter the English word to delete: ");
            string? khmerWord = Console.ReadLine();
            if (dictionary.Remove(khmerWord)) // Remove from dictionary
            {
                Console.WriteLine("Word deleted successfully.");
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }

        public void SearchWord()
        {
            Console.Write("Enter the English word to search for: ");
            string? englishWord = Console.ReadLine();
            if (dictionary.TryGetValue(englishWord, out string? khmerWord))
            {
                Console.WriteLine($"The Khmer Word of {englishWord} is {khmerWord}.");
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }

        public void ViewAllWords()
        {
            if (dictionary.Count > 0)
            {
                Console.WriteLine("English words and Khmer Word:");
                foreach (var pair in dictionary)
                {
                    Console.WriteLine($"{pair.Key} - {pair.Value}");
                }
            }
            else
            {
                Console.WriteLine("No words in the dictionary.");
            }
        }
    }
}
