using System;

namespace Project1
{
    internal class Application : Function
    {
        public void DisplayMenu()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(" \tWelcome to Dictionary ");
                Console.WriteLine("\t=====================");
                Console.WriteLine();
                Console.WriteLine();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("<<< Main Menu: ");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("1. English - Khmer");
                Console.WriteLine("2. Khmer - English");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string userOption = Console.ReadLine();

                switch (userOption)
                {
                    case "1":
                        DisplayEnglishMenu();
                        break;
                    case "2":
                        DisplayKhmerMenu();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number.");
                        Pause();
                        break;
                }
            }
        }

        private void DisplayEnglishMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("\tEnglish - Khmer Menu:");
                Console.WriteLine("\t====================");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1. Add English word");
                Console.WriteLine("2. Replace a word");
                Console.WriteLine("3. Delete a word");
                Console.WriteLine("4. Search for translation of a word");
                Console.WriteLine("5. View all English words");
                Console.WriteLine("0. Back to main menu");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                int enterNumber;

                if (int.TryParse(choice, out enterNumber))
                {
                    switch (enterNumber)
                    {
                        case 1:
                            AddEnglishWord();
                            Pause();
                            break;
                        case 2:
                            ReplaceEnglishWord();
                            Pause();
                            break;
                        case 3:
                            DeleteEnglishWord();
                            Pause();
                            break;
                        case 4:
                            SearchEnglishWord();
                            Pause();
                            break;
                        case 5:
                            ViewAllEnglishWords();
                            Pause();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            Pause();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Pause();
                }
            }
        }

        private void DisplayKhmerMenu()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\tKhmer - English Menu:");
                Console.WriteLine("\t====================");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1. Add Khmer word");
                Console.WriteLine("2. Replace a word");
                Console.WriteLine("3. Delete a word");
                Console.WriteLine("4. Search for translation of a word");
                Console.WriteLine("5. View all Khmer words");
                Console.WriteLine("0. Back to main menu");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                int enterNumber;

                if (int.TryParse(choice, out enterNumber))
                {
                    switch (enterNumber)
                    {
                        case 1:
                            AddKhmerWord();
                            Pause();
                            break;
                        case 2:
                            ReplaceKhmerWord();
                            Pause();
                            break;
                        case 3:
                            DeleteKhmerWord();
                            Pause();
                            break;
                        case 4:
                            SearchKhmerWord();
                            Pause();
                            break;
                        case 5:
                            ViewAllKhmerWords();
                            Pause();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            Pause();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Pause();
                }
            }
        }

        private void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
