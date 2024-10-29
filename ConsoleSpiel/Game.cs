using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSpiel
{
    //namespace ConsoleSpiel
    //{
    //    internal class Game
    //    {
    //        static string hobby;
    //        static void Main()
    //        {
    //            string name = GetUserInput("What's your name?", ConsoleColor.Green);
    //            string surname = GetUserInput("What's your surname?", ConsoleColor.Green);
    //            Console.WriteLine($"\nNice to meet you, {name} {surname}. Welcome to my World!!");

    //            int age = GetValidatedAge();
    //            DisplayAgeMessage(age);

    //            string food = GetUserInput("What's your favorite food?", ConsoleColor.Green);
    //            RespondToFoodChoice(food);

    //            hobby = GetUserInput("What's your favorite hobby?", ConsoleColor.Green);
    //            RespondToHobbyChoice(hobby);

    //            StartQuiz();
    //        }

    //        static string GetUserInput(string prompt, ConsoleColor color)
    //        {
    //            PrintColored(prompt, color);
    //            return Console.ReadLine();
    //        }

    //        static int GetValidatedAge()
    //        {
    //            while (true)
    //            {
    //                PrintColored("\nHow old are you?\n", ConsoleColor.Green);
    //                if (int.TryParse(Console.ReadLine(), out int age))
    //                {
    //                    return age;
    //                }
    //                PrintColored("Please enter a valid age.", ConsoleColor.Red);
    //            }
    //        }

    //        static void DisplayAgeMessage(int age)
    //        {
    //            if (age < 18)
    //            {
    //                PrintColored("\nWow, there's a little baby sitting right in front of me!", ConsoleColor.White);
    //                Thread.Sleep(1000);
    //                PrintColored("Well, let's see what you're capable of, cutie.", ConsoleColor.White);
    //            }
    //            else
    //            {
    //                PrintColored("\nWow, are you dad?!", ConsoleColor.White);
    //                Thread.Sleep(1000);
    //                PrintColored("\nYou should be enjoying your retirement by now, but oh well.", ConsoleColor.White);
    //            }
    //        }

    //        static void RespondToFoodChoice(string food)
    //        {
    //            var fastFoods = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "burger", "hamburger", "nuggets" };
    //            var commonFoods = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "pizza", "sushi", "pasta", "chicken", "salad" };

    //            if (fastFoods.Contains(food))
    //            {
    //                PrintColored("\nWow! Are you trying to summon an ancient deity with your food choice?", ConsoleColor.White);
    //                Thread.Sleep(2000);
    //                PrintColored("I hope it's not too hungry!", ConsoleColor.White);
    //            }
    //            else if (commonFoods.Contains(food))
    //            {
    //                PrintColored("\nWow! Are you really hungry?", ConsoleColor.White);
    //            }
    //        }

    //        static void RespondToHobbyChoice(string hobby)
    //        {
    //            var hobbyCategories = new Dictionary<string, string[]>
    //        {
    //            {"magic", new[] { "magic", "singing", "dancing", "playing guitar", "guitar", "music", "swimming", "games", "gaming" }},
    //            {"common", new[] { "sleeping", "reading", "playing football" }},
    //            {"extreme", new[] { "skydiving", "rock climbing", "surfing", "bungee jumping", "parkour" }},
    //            {"creative", new[] { "writing", "photography", "sculpting", "knitting", "drawing" }},
    //            {"tech", new[] { "programming", "robotics", "3d printing", "electronics", "coding" }}
    //        };

    //            foreach (var category in hobbyCategories)
    //            {
    //                if (category.Value.Contains(hobby.ToLower()))
    //                {
    //                    switch (category.Key)
    //                    {
    //                        case "magic":
    //                            PrintColored("\nHa! Your hobby sounds like a spell from Harry Potter!", ConsoleColor.White);
    //                            Thread.Sleep(2000);
    //                            PrintColored("\nJust don't turn me into a toad, please!", ConsoleColor.White);
    //                            return;
    //                        case "common":
    //                            PrintColored("\nAWESOME! That's a great way to relax and enjoy life.", ConsoleColor.Green);
    //                            return;
    //                        case "extreme":
    //                            PrintColored("\nWow, you're quite the adrenaline junkie! Stay safe out there!", ConsoleColor.White);
    //                            return;
    //                        case "creative":
    //                            PrintColored("\nAh, an artist at heart! The world needs more creative souls like you.", ConsoleColor.White);
    //                            return;
    //                        case "tech":
    //                            PrintColored("\nA tech enthusiast! You're building the future, one project at a time.", ConsoleColor.White);
    //                            return;
    //                    }
    //                }
    //            }

    //            PrintColored($"\n{hobby}? That's an interesting hobby! I'd love to hear more about it sometime.", ConsoleColor.White);
    //        }

    //        static void StartQuiz()
    //        {
    //            PrintColored("\nLet's take a little Quiz", ConsoleColor.White);
    //            for (int i = 0; i < 10; i++)
    //            {
    //                PrintColored(".", ConsoleColor.Cyan);
    //                Thread.Sleep(1000);
    //            }

    //            int noCount = 0;
    //            while (true)
    //            {
    //                PrintColored("\nAre you ready?", ConsoleColor.White);
    //                string readyResponse = Console.ReadLine().ToLower();

    //                if (readyResponse == "yes")
    //                {
    //                    RunQuiz();
    //                    return;
    //                }
    //                else if (readyResponse == "no")
    //                {
    //                    noCount++;
    //                    HandleNoResponse(noCount);
    //                    if (noCount == 15) return;
    //                }
    //                else
    //                {
    //                    PrintColored("Please answer with yes or no.", ConsoleColor.White);
    //                }
    //            }
    //        }

    //        static void RunQuiz()
    //        {
    //            PrintColored("\nOk, let's go.", ConsoleColor.Green);
    //            Thread.Sleep(1000);
    //            PrintColored("\nBut!...?", ConsoleColor.White);
    //            Thread.Sleep(2000);
    //            PrintColored("\nWait!...", ConsoleColor.White);
    //            Thread.Sleep(2000);
    //            for (int i = 0; i < 10; i++)
    //            {
    //                PrintColored(".", ConsoleColor.Cyan);
    //                Thread.Sleep(2000);
    //            }

    //            while (true)
    //            {
    //                PrintColored("\n\nYou are in the middle of a forest.", ConsoleColor.Green);
    //                Thread.Sleep(3000);
    //                PrintColored("\nThere are three paths in front of you.", ConsoleColor.White);
    //                Thread.Sleep(3000);
    //                PrintColored("\nChoose a path: left, middle, right?", ConsoleColor.Green);

    //                string choice = Console.ReadLine().ToLower();

    //                switch (choice)
    //                {
    //                    case "left":
    //                        HandleLeftPath();
    //                        return;
    //                    case "middle":
    //                        HandleMiddlePath();
    //                        return;
    //                    case "right":
    //                        PrintColored("\nWrong path", ConsoleColor.Red);
    //                        break;
    //                    default:
    //                        PrintColored("\nWrong path", ConsoleColor.Red);
    //                        break;
    //                }
    //            }
    //        }

    //        static void HandleLeftPath()
    //        {
    //            Console.WriteLine("You find yourself at a crossroads.");
    //            Thread.Sleep(2000);
    //            PrintColored("Do you want to go to the old house, or the lake?", ConsoleColor.Green);
    //            string leftChoice = Console.ReadLine().ToLower();

    //            if (leftChoice == "old house")
    //            {
    //                HandleOldHouse();
    //            }
    //            else if (leftChoice == "lake")
    //            {
    //                HandleLake();
    //            }
    //            else
    //            {
    //                PrintColored("Wrong path", ConsoleColor.Red);
    //            }
    //        }

    //        static void HandleOldHouse()
    //        {
    //            Console.WriteLine("You are in the Old House.");
    //            Thread.Sleep(1500);
    //            Console.WriteLine("\nYou heard a noise.");
    //            Thread.Sleep(2500);
    //            Console.WriteLine("\nAnd you found the room the noise was coming from.");
    //            Thread.Sleep(2000);
    //            Console.WriteLine("\nYou open the door.");
    //            Thread.Sleep(2500);
    //            Console.WriteLine("\nYou see Goku.");
    //            Thread.Sleep(2500);
    //            Console.WriteLine("\nYou went on a journey with him.");
    //            Thread.Sleep(1500);
    //            PrintColored("\nYou win!!", ConsoleColor.Green);
    //            Thread.Sleep(4500);
    //            Environment.Exit(0);
    //        }

    //        static void HandleLake()
    //        {
    //            Console.Write("\nYou see a beautiful lake,");
    //            Thread.Sleep(1500);
    //            Console.Write("\napproach it,");
    //            Thread.Sleep(1500);
    //            Console.Write("\nsee your reflection,");

    //            // Note: This part assumes 'Hobby' is accessible. You might need to pass it as a parameter or store it globally.
    //            if (hobby.ToLower().Contains("swimming"))
    //            {
    //                Thread.Sleep(1500);
    //                PrintColored("\nand swim to the sea", ConsoleColor.Blue);
    //                Thread.Sleep(1500);
    //                PrintColored("\nYou win!!", ConsoleColor.Green);
    //                Thread.Sleep(4500);
    //                Environment.Exit(0);
    //            }

    //            Thread.Sleep(1000);
    //            Console.Write("\nand collapse from a ");
    //            PrintColored("heart attack.", ConsoleColor.Red);
    //            Thread.Sleep(1000);
    //            PrintColored("\n\nGAME OVER", ConsoleColor.Red);
    //            Thread.Sleep(4000);
    //            Environment.Exit(0);
    //        }

    //        static void HandleMiddlePath()
    //        {
    //            PrintColored("You see a Mountain!", ConsoleColor.Blue);
    //            Thread.Sleep(1000);
    //            PrintColored("\nYou're freezing.", ConsoleColor.Blue);
    //            Thread.Sleep(1000);
    //            PrintColored("\nYou are dead!", ConsoleColor.Red);
    //            Thread.Sleep(4000);
    //            Environment.Exit(0);
    //        }

    //        static void HandleNoResponse(int noCount)
    //        {
    //            switch (noCount)
    //            {
    //                case 5:
    //                    PrintColored("Ha-ha, you're so indecisive!", ConsoleColor.DarkMagenta);
    //                    break;
    //                case 10:
    //                    PrintColored("Oh come on, enough already!", ConsoleColor.DarkMagenta);
    //                    break;
    //                case 15:
    //                    PrintColored("Alright, you said no so no it shall be.", ConsoleColor.White);
    //                    Thread.Sleep(2000);
    //                    PrintColored("\nWait...", ConsoleColor.Cyan);
    //                    for (int i = 0; i < 5; i++)
    //                    {
    //                        PrintColored(".", ConsoleColor.Cyan);
    //                        Thread.Sleep(1500);
    //                    }
    //                    SecretEnding();
    //                    break;
    //                default:
    //                    PrintColored("Please answer with yes or no.", ConsoleColor.White);
    //                    break;
    //            }
    //        }

    //        static void PrintColored(string text, ConsoleColor color)
    //        {
    //            Console.ForegroundColor = color;
    //            Console.WriteLine(text);
    //            Console.ResetColor();
    //        }

    //        static void SecretEnding()
    //        {
    //            // Implement your secret ending here
    //            PrintColored("You've discovered the secret ending!", ConsoleColor.Magenta);
    //            // Add more details for the secret ending
    //        }
    //    }
    //}
}