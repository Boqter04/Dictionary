using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Application : Function
    {
        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Add English word");
                Console.WriteLine("2. Replace a word");
                Console.WriteLine("3. Delete a word");
                Console.WriteLine("4. Search for translation of a word");
                Console.WriteLine("5. View all English words");
                Console.WriteLine("0. Back to main menu");
                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();
                int enterNumber;
                if (int.TryParse(choice, out enterNumber))
                {
                    switch (enterNumber)
                    {
                        case 0:
                            return;
                        case 1:
                            AddEnglishWord();
                            break;
                        case 2:
                            ReplaceWord();
                            break;
                        case 3:
                            DeleteWord();
                            break;
                        case 4:
                            SearchWord();
                            break;
                        case 5:
                            ViewAllWords();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
