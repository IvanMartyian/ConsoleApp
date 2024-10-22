﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSpiel
{
    internal class Program
    {
        static void Main()
        {
            string Name;
            string Surname;
            int Age;
            string Food;
            string Hobby;

            PrintColored(new List<PrintInfo> {
                new PrintInfo("HI!! This my First Program!", ConsoleColor.Cyan, true),
            });

            Thread.Sleep(2000);
            Console.WriteLine("\nSo...");

            Thread.Sleep(1000);
            PrintColored(new List<PrintInfo> {
                new PrintInfo("What's your ", ConsoleColor.White, false),
                new PrintInfo("name", ConsoleColor.Green, false),
                new PrintInfo("?", ConsoleColor.White, true)
            });
            Name = Console.ReadLine();

            Thread.Sleep(1000);
            PrintColored(new List<PrintInfo>
            {
             new PrintInfo("\nWhat's your ", ConsoleColor.White, false),
             new PrintInfo("surname", ConsoleColor.Green, false),
             new PrintInfo("?", ConsoleColor.White, true),

            });
            Surname = Console.ReadLine();

            Console.WriteLine($"\nNice to meet you, {Name} {Surname}. Welcome to my World!!");

            Thread.Sleep(1000);
            PrintColored("\nHow ", "old ", ConsoleColor.Green, "are you?\n");
            Age = Convert.ToInt32(Console.ReadLine());

            if (Age < 18)
            {
                Console.WriteLine("\n\nWow,there´s a little baby sitting right in front of me!");

                Thread.Sleep(1000);
                Console.WriteLine("Well, let’s see what you’re capable of, cutie.");
            }

            else if (Age >= 18)
            {
                PrintColored(new List<PrintInfo>
            {
             new PrintInfo("Wow are you dad!!", ConsoleColor.White, false)

            });

                Thread.Sleep(1000);
                PrintColored(new List<PrintInfo>
            {
             new PrintInfo("\nYou should be enjoying your retirement by now, but oh well.", ConsoleColor.White, false)

            });

            }

            Thread.Sleep(1000);
            PrintColored(new List<PrintInfo>
            {
             new PrintInfo("\nWhat's your ", ConsoleColor.White, false),
             new PrintInfo("favorite ", ConsoleColor.DarkMagenta, false),
             new PrintInfo("food", ConsoleColor.Green, false),
             new PrintInfo("?", ConsoleColor.White, true)

            });

            Food = Console.ReadLine();
            string[] fastFoods = { "burger", "hamburger", "nuggets" };
            string[] commonFoods = { "pizza", "sushi", "pasta", "chicken", "salad" };


            if (fastFoods.Contains(Food.ToLower()))

            {
                PrintColored(new List<PrintInfo>
                {
                new PrintInfo("\nWow! Are you trying to summon an ancient deity with your food choice?", ConsoleColor.White, true)
                });

                Thread.Sleep(2000);
                PrintColored(new List<PrintInfo>
                {
                 new PrintInfo("I hope it's not too hungry!", ConsoleColor.White,true)
                });

            }

            else if (commonFoods.Contains(Food.ToLower()))

            {
                PrintColored(new List<PrintInfo>
                {
                 new PrintInfo("\nWow! Are really hungry?", ConsoleColor.White,true)
                });
            }

            Thread.Sleep(1000);
            PrintColored(new List<PrintInfo>
                {
                 new PrintInfo("\nWhat's your ", ConsoleColor.White,false),
                 new PrintInfo("favorite ", ConsoleColor.DarkMagenta,false),
                 new PrintInfo("hobby", ConsoleColor.Green,false),
                 new PrintInfo("?", ConsoleColor.White,true)
                });

            Hobby = Console.ReadLine();
            string[] magicHobbies = { "magic", "singing", "dancing", "playing guitar", "guitar", "music", "swimming", "games", "gaming" };
            string[] commonHobbies = { "sleeping", "reading", "playing football" };
            string[] extremeHobbies = { "skydiving", "rock climbing", "surfing", "bungee jumping", "parkour" };
            string[] creativeHobbies = { "writing", "photography", "sculpting", "knitting", "drawing" };
            string[] techHobbies = { "programming", "robotics", "3d printing", "electronics", "coding" };

             if (CheckInput(magicHobbies, Hobby))
            {
                PrintColored(new List<PrintInfo> {
                new PrintInfo("\nHa! Your hobby sounds like a spell from Harry Potter!", ConsoleColor.White, true),
                });
                Thread.Sleep(2000);
                PrintColored(new List<PrintInfo> {
                new PrintInfo("\nJust don't turn me into a toad, please!", ConsoleColor.White, true),
                });
            }
            //if (magicHobbies.Contains(Hobby.ToLower()))
            //{
            //    Console.WriteLine("Ha! Your hobby sounds like a spell from Harry Potter!");
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Just don't turn me into a toad, please!");
            //}

            if (CheckInput(commonHobbies, Hobby))
            {
                PrintColored("\nAWESOME! That's a great way ", "to relax", ConsoleColor.Green, " and enjoy life.");
            }

            else if (CheckInput(extremeHobbies, Hobby))
            {
                PrintColored(new List<PrintInfo> {
                new PrintInfo("\nWow, youre quite the adrenaline junkie! Stay safe out there!", ConsoleColor.White, true),
                });
            }
            else if (CheckInput(creativeHobbies, Hobby))
            {
                PrintColored(new List<PrintInfo> {
                    new PrintInfo("\nAh, an artist at heart! The world needs more creative souls like you.", ConsoleColor.White, true),
                });
            }
            else if (CheckInput(techHobbies, Hobby))
            {
                PrintColored(new List<PrintInfo> {
                    new PrintInfo("\nA tech enthusiast! You're building the future, one project at a time.", ConsoleColor.White, true),
                });

            }
            else if (!CheckInput(magicHobbies, Hobby) && !CheckInput(commonHobbies, Hobby) && !CheckInput(extremeHobbies, Hobby) && !CheckInput(creativeHobbies, Hobby) && !CheckInput(techHobbies, Hobby))
            {
                PrintColored(new List<PrintInfo> {
                    new PrintInfo($"\n{Hobby}? That's an interesting hobby! I'd love to hear more about it sometime.", ConsoleColor.White, true),
                });
            }

            Thread.Sleep(2000);
            PrintColored(new List<PrintInfo> {
                new PrintInfo("\nLet's take a little ", ConsoleColor.White, false),
                new PrintInfo("Quiz", ConsoleColor.White, false),
                });

            for (int i = 0; i < 10; i++)
            {
                PrintColored(new List<PrintInfo> { new PrintInfo(".", ConsoleColor.Cyan, false), });
                Thread.Sleep(1000);
            }


            bool correctChoise = false;
            int noCount = 0;
            while (!correctChoise)
            {
                PrintColored(new List<PrintInfo> { 
                    new PrintInfo("\nAre you ready?", ConsoleColor.White, true), 
                });


                string readyResponse = Console.ReadLine();

                if (readyResponse.ToLower() == "yes")
                {
                    PrintColored(new List<PrintInfo> { 
                        new PrintInfo("\nOk,", ConsoleColor.Green, false),
                        new PrintInfo("let's go.", ConsoleColor.White, false), 
                    });

                    Thread.Sleep(1000);
                    PrintColored(new List<PrintInfo> {
                        new PrintInfo("\nBut!...?", ConsoleColor.White, false),
                    });

                    Thread.Sleep(2000);
                    PrintColored(new List<PrintInfo> {
                        new PrintInfo("\nWait!", ConsoleColor.White, false),
                         new PrintInfo("...", ConsoleColor.Cyan, false),
                    });

                    Thread.Sleep(2000);
                    for (int i = 0; i < 10; i++)
                    {
                        PrintColored(new List<PrintInfo> { 
                            new PrintInfo(".", ConsoleColor.Cyan, false), 
                        });
                        Thread.Sleep(2000);
                    }
                    while (!correctChoise)
                    {
                        PrintColored(new List<PrintInfo> {
                            new PrintInfo("\n\nYou are in the middle of a ", ConsoleColor.White, false),
                            new PrintInfo("forest", ConsoleColor.Green, false),
                            new PrintInfo(".", ConsoleColor.White, false),
                        });

                        Thread.Sleep(3000);
                        PrintColored(new List<PrintInfo> {
                            new PrintInfo("\nThere are three paths in front of you.", ConsoleColor.White, true),
                        });

                        Thread.Sleep(3000);
                        PrintColored(new List<PrintInfo> {
                            new PrintInfo("\nChoose a path: ", ConsoleColor.White, false),
                            new PrintInfo("left", ConsoleColor.Green, false),
                            new PrintInfo(", ", ConsoleColor.White, false),
                            new PrintInfo("middle", ConsoleColor.Green, false),
                            new PrintInfo(", ", ConsoleColor.White, false),
                            new PrintInfo("right", ConsoleColor.Green, false),
                            new PrintInfo("?", ConsoleColor.White, false),
                        });

                        string choice = Console.ReadLine().ToLower();

                        switch (choice)
                        {
                            case "left":
                                Console.WriteLine("You find yourself at a crossroads.");

                                Thread.Sleep(2000);
                                PrintColored(new List<PrintInfo> {
                                    new PrintInfo("Do you want to go to the ", ConsoleColor.White, false),
                                    new PrintInfo("old house, ", ConsoleColor.Green, false),
                                    new PrintInfo("or the ", ConsoleColor.White, false),
                                    new PrintInfo("lake", ConsoleColor.Blue, false),
                                    new PrintInfo("?", ConsoleColor.White, false),
                                    });
                                string leftChoice = Console.ReadLine().ToLower();

                                if (leftChoice == "old house")
                                {
                                    Console.WriteLine("You are in the Old House.");

                                    Thread.Sleep(1500);
                                    Console.WriteLine("\nYou heard a noise.");

                                    Thread.Sleep(2500);
                                    Console.WriteLine("\nAnd you found the room the noise was coming from.");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nYou open the door.");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("\nYou see Goku.");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("\nYou went on a journey with him.");

                                    Thread.Sleep(1500);
                                    PrintColored(new List<PrintInfo> {
                                    new PrintInfo("\nYou win!!", ConsoleColor.Green, false),
                                    });

                                    Thread.Sleep(4500);
                                    Environment.Exit(0);
                                }
                                else if (leftChoice == "lake")
                                {
                                    Console.Write("\nYou see a beautiful lake,");

                                    Thread.Sleep(1500);
                                    Console.Write("\napproach it,");
                                    Thread.Sleep(1500);
                                    Console.Write("\nsee your reflection,");

                                    if (Hobby.ToLower().Contains("swimming"))
                                    {
                                        Thread.Sleep(1500);
                                        PrintColored(new List<PrintInfo> {
                                                     new PrintInfo("\nand swim to the ", ConsoleColor.White, false),
                                                     new PrintInfo("sea", ConsoleColor.Blue, false),
                                                     });

                                        Thread.Sleep(1500);
                                        PrintColored(new List<PrintInfo> { 
                                            new PrintInfo("\nYou win!!", ConsoleColor.Green, false), 
                                            });

                                        Thread.Sleep(4500);
                                        Environment.Exit(0);
                                    }
                                    Thread.Sleep(1000);
                                    Console.Write("\nand collapse from a ");
                                    PrintColored(new List<PrintInfo> { new PrintInfo("heart attack.", ConsoleColor.Red, false), });

                                    Thread.Sleep(1000);
                                    PrintColored(new List<PrintInfo> { new PrintInfo("\n\nGAME OVER", ConsoleColor.Red, false), });

                                    Thread.Sleep(4000);

                                    Environment.Exit(0);
                                    break;
                                }
                                else
                                {
                                    PrintColored(new List<PrintInfo> { new PrintInfo("Wrong path", ConsoleColor.Red, false), });
                                }
                                break;

                            case "middle":
                                PrintColored(new List<PrintInfo> { 
                                             new PrintInfo("You see a ", ConsoleColor.White, false), 
                                             new PrintInfo("Mountain!", ConsoleColor.Blue, false), });

                                Thread.Sleep(1000);
                                PrintColored(new List<PrintInfo> { new PrintInfo("\nYou're freezing.", ConsoleColor.Blue, false), });

                                Thread.Sleep(1000);
                                PrintColored(new List<PrintInfo> { new PrintInfo("\nYou are dead!", ConsoleColor.Red, false), });

                                Thread.Sleep(4000);
                                Environment.Exit(0);
                                break;

                            case "right":
                                PrintColored(new List<PrintInfo> { new PrintInfo("\nWrong path", ConsoleColor.Red, false), });
                                break;

                            default:
                                PrintColored(new List<PrintInfo> { new PrintInfo("\nWrong path", ConsoleColor.Red, false), });
                                break;
                        }
                    }
                }

                else if (readyResponse.ToLower() == "no")
                {
                    noCount++;
                    if (noCount == 5)
                    {
                        PrintColored(new List<PrintInfo> 
                        { new PrintInfo("Ha-ha, you´re so indecisive!", ConsoleColor.DarkMagenta, false), });
                    }
                    else if (noCount == 10)
                    {
                        PrintColored(
                            new List<PrintInfo> { new PrintInfo("Oh come on, enough already!", ConsoleColor.DarkMagenta, false), });
                    }
                    else if (noCount == 15)
                    {
                        PrintColored(
                            new List<PrintInfo> { new PrintInfo("Alright, you said ", ConsoleColor.White, false),
                            new PrintInfo("no ", ConsoleColor.Red, false),
                            new PrintInfo("so ", ConsoleColor.White, false),
                            new PrintInfo("no ", ConsoleColor.DarkRed, false),
                            new PrintInfo("it shall be.", ConsoleColor.White, false), });

                        Thread.Sleep(2000);
                        PrintColored(
                            new List<PrintInfo> { new PrintInfo("\nWait", ConsoleColor.White, false),
                            new PrintInfo("...", ConsoleColor.Cyan, false),
                            });

                        for (int i = 0; i < 5; i++)
                        {
                            PrintColored(
                             new List<PrintInfo> { 
                             new PrintInfo(".", ConsoleColor.Cyan, false),
                             });
                            Thread.Sleep(1500);
                        }
                        SecretEnding();
                        return;
                    }
                    else
                    {
                        PrintColored(
                           new List<PrintInfo> { new PrintInfo("Please answer with ", ConsoleColor.White, false),
                            new PrintInfo("yes ", ConsoleColor.Green, false),
                            new PrintInfo("or ", ConsoleColor.White, false),
                            new PrintInfo("no", ConsoleColor.DarkRed, false),
                            new PrintInfo(".", ConsoleColor.White, false), });
                    }
                }
            }
            Console.ReadKey();

        }

        static void PrintColored(List<PrintInfo> printInfos)
        {
            foreach (PrintInfo pi in printInfos)
            {
                Console.ForegroundColor = pi.TextColor;
                if (pi.PrintLine)
                {
                    Console.WriteLine(pi.TextToPrint);
                }
                else
                {
                    Console.Write(pi.TextToPrint);
                }
            }
        }
        static void PrintColored(string text1 = null,

                                 string coloredtext1 = null,
                                 ConsoleColor color1 = ConsoleColor.White,

                                 string text2 = null,

                                 string coloredtext2 = null,
                                 ConsoleColor color2 = ConsoleColor.White,

                                 string text3 = null)
        {
            if (!string.IsNullOrEmpty(text1))
            {
                Console.Write(text1);
            }


            if (!string.IsNullOrEmpty(coloredtext1))
            {
                Console.ForegroundColor = color1;
                Console.Write(coloredtext1);
                Console.ResetColor();
            }


            if (!string.IsNullOrEmpty(text2))
            {
                Console.Write(text2);
            }


            if (!string.IsNullOrEmpty(coloredtext2))
            {
                Console.ForegroundColor = color2;
                Console.Write(coloredtext2);
                Console.ResetColor();
            }

            if (!string.IsNullOrEmpty(text3))
            {
                Console.Write(text3);
            }

        }

        private static bool CheckInput(string[] collection, string input)
        {
            if (collection.Contains(input.ToLower()))
            {
                return true;
            }
            return false;
        }


        static void SecretEnding()
        {
            PrintColored(
                 new List<PrintInfo> { new PrintInfo("\nYou find yourself on a ", ConsoleColor.White, false),
                  new PrintInfo("secret path ", ConsoleColor.DarkMagenta, false),
                  new PrintInfo("You are ", ConsoleColor.White, false),
                  new PrintInfo("in the ", ConsoleColor.White, false),
                  new PrintInfo("forest.", ConsoleColor.DarkCyan, false), 
                 });

            Thread.Sleep(1500);
            Console.WriteLine("\nAn old man stands before you.");

            int noCount = 0;
            while (noCount < 5)
            {
                PrintColored(
                new List<PrintInfo> { new PrintInfo("\nThe old man asks: ", ConsoleColor.White, false),
                  new PrintInfo("'yes'", ConsoleColor.Green, false),
                  new PrintInfo(" or ", ConsoleColor.White, false),
                  new PrintInfo("'no'", ConsoleColor.DarkRed, false),
                  new PrintInfo(".", ConsoleColor.White, true),
                });

                string answer = Console.ReadLine().ToLower();

                if (answer == "yes")
                {
                    Console.Write("The old man shakes his head: ");
                    PrintColored(new List<PrintInfo> { new PrintInfo("'Wrong answer.'", ConsoleColor.DarkRed,false) });

                }
                else if (answer == "no")
                {
                    noCount++;
                    if (noCount >= 10)
                    {
                        PrintColored(new List<PrintInfo>
                        { new PrintInfo("The old man steps aside: ", ConsoleColor.White, false),
                        new PrintInfo("'You have passed the test.'", ConsoleColor.DarkGreen, false) });

                        Thread.Sleep(2000);
                        break;
                    }
                    else
                    {
                        PrintColored(new List<PrintInfo> { new PrintInfo("\nOld man: ", ConsoleColor.White, false) });
                        Console.Write($"{GetRandomResponse()}");
                    }
                }
                else
                {
                    Console.Write("Hint: You must convincingly say ");
                    PrintColored(new List<PrintInfo> { 
                                 new PrintInfo("Hint: You must convincingly say ", ConsoleColor.White, false),
                                 new PrintInfo("'no'.", ConsoleColor.DarkRed, false) });
                }
            }
                Console.Write("\nYou pass by the ");
                PrintColored(new List<PrintInfo> { new PrintInfo("old man ", ConsoleColor.DarkMagenta, false), 
                            new PrintInfo("and encounter another one.",ConsoleColor.White,false)});

                Thread.Sleep(1500);
                Console.WriteLine("\nThe new old man asks: ");
                PrintColored(new List<PrintInfo> { 
                    new PrintInfo("\nThe new old man asks: ", ConsoleColor.White, false), 
                    new PrintInfo("'Yes'", ConsoleColor.Green, false),
                    new PrintInfo("'or'", ConsoleColor.White, false),
                    new PrintInfo("'No'", ConsoleColor.DarkRed, false), });
                Console.ReadLine();

                Thread.Sleep(1500);
            PrintColored(new List<PrintInfo> {
                    new PrintInfo("You've gone ", ConsoleColor.White, false),
                    new PrintInfo("mad.", ConsoleColor.Red, false),});
                Thread.Sleep(1500);
            PrintColored(new List<PrintInfo> {
                    new PrintInfo("You win!", ConsoleColor.Green, false),});

            

        }
        static string GetRandomResponse()
        {
            string[] responses =
            {
                    "You haven't convinced me, try again.",
                    "No? Are you sure?",
                    "Think carefully and say it again.",
                    "Your 'no' isn't convincing enough.",
                    "I'm waiting for a more decisive answer."
                };
            Random random = new Random();
            return responses[random.Next(responses.Length)];

        }
    }
}
