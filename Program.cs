using System;
using System.Collections.Generic;

namespace Lab8_GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> superHeroes = new List<string>() { "Superman", "Batman", "Spider-Man", "Wolverine" };
            List<string> favoriteFood = new List<string>() { "Freedom", "Justice", "Aunt May's Wheatcakes", "Cigars" };
            List<string> city = new List<string>() { "Planet Krypton", "Gotham City", "Queens, NY", "Canada" };
            List<string> archEnemy = new List<string>() { "Lex Luthor", "The Joker", "Green Goblin", "Sabertooth" };

            bool playAgain = true;
            bool validSelection = true;

            while (playAgain)
            {
                Console.WriteLine("Super heroes are totally awesome. Let's learn about some of the most popular heroes!");
                Console.WriteLine("Please select a number (1-4) to learn more about the specific hero!");

                for (int i = 0; i < superHeroes.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {superHeroes[i]}");
                }

                string input = "";
                int selection;

                try
                {
                    input = Console.ReadLine();
                    selection = int.Parse(input);

                    if (1 <= selection && selection <= 4)
                    {
                        while (validSelection == true)
                        {
                            if (selection == 1)
                            {
                                Console.WriteLine($"You have picked {superHeroes[selection - 1]}!");
                                Console.WriteLine("Press 1 for their favorite food. 2 for their city. 3 to find out who their Arch Enemy is!");
                                int choice1 = int.Parse(Console.ReadLine());

                                if (choice1 == 1)
                                {
                                    DisplayFood(favoriteFood, (selection - 1));
                                    validSelection = false;
                                }
                                else if (choice1 == 2)
                                {
                                    DisplayCity(city, (selection - 1));
                                    validSelection = false;
                                }
                                else if (choice1 == 3)
                                {
                                    DisplayVillian(archEnemy, (selection - 1));
                                    validSelection = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a number 1-3");
                                    Console.WriteLine("Press any key to try again");
                                    Console.ReadKey();
                                    Console.Clear();
                                    validSelection = true;
                                }
                            }
                            if (selection == 2)
                            {
                                Console.WriteLine($"You have picked {superHeroes[selection - 1]}!");
                                Console.WriteLine("Press 1 for their favorite food. 2 for their city. 3 to find out who their Arch Enemy is!");
                                int choice1 = int.Parse(Console.ReadLine());
                                if (choice1 == 1)
                                {
                                    DisplayFood(favoriteFood, (selection - 1));
                                    validSelection = false;
                                }
                                else if (choice1 == 2)
                                {
                                    DisplayCity(city, (selection - 1));
                                    validSelection = false;
                                }
                                else if (choice1 == 3)
                                {
                                    DisplayVillian(archEnemy, (selection - 1));
                                    validSelection = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a number 1-3");
                                    Console.WriteLine("Press any key to try again");
                                    Console.ReadKey();
                                    Console.Clear();
                                    validSelection = true;
                                }
                            }
                            if (selection == 3)
                            {
                                Console.WriteLine($"You have picked {superHeroes[selection - 1]}!");
                                Console.WriteLine("Press 1 for their favorite food. 2 for their city. 3 to find out who their Arch Enemy is!");
                                int choice1 = int.Parse(Console.ReadLine());
                                if (choice1 == 1)
                                {
                                    DisplayFood(favoriteFood, (selection - 1));
                                    validSelection = false;
                                }
                                else if (choice1 == 2)
                                {
                                    DisplayCity(city, (selection - 1));
                                    validSelection = false;
                                }
                                else if (choice1 == 3)
                                {
                                    DisplayVillian(archEnemy, (selection - 1));
                                    validSelection = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a number 1-3");
                                    Console.WriteLine("Press any key to try again");
                                    Console.ReadKey();
                                    Console.Clear();
                                    validSelection = true;
                                }
                            }
                            if (selection == 4)
                            {
                                Console.WriteLine($"You have picked {superHeroes[selection - 1]}!");
                                Console.WriteLine("Press 1 for their favorite food. 2 for their city. 3 to find out who their Arch Enemy is!");
                                int choice1 = int.Parse(Console.ReadLine());
                                if (choice1 == 1)
                                {
                                    DisplayFood(favoriteFood, (selection - 1));
                                    validSelection = false;
                                }
                                else if (choice1 == 2)
                                {
                                    DisplayCity(city, (selection - 1));
                                    validSelection = false;
                                }
                                else if (choice1 == 3)
                                {
                                    DisplayVillian(archEnemy, (selection - 1));
                                    validSelection = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a number 1-3");
                                    Console.WriteLine("Press any key to try again");
                                    Console.ReadKey();
                                    Console.Clear();
                                    validSelection = true;
                                }


                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number 1-4");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The input " + input + " was a bit villianous.");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input " + input + " was not a number.");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                }


                if (RunProgramAgain() == true)
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }
        }

        public static void DisplayFood(List<string> food, int pos)
        {
            Console.WriteLine($"favorite food: {food[pos]}");
        }
        public static void DisplayCity(List<string> city, int pos)
        {
            Console.WriteLine($"City: {city[pos]}");
        }
        public static void DisplayVillian(List<string> villian, int pos)
        {
            Console.WriteLine($"Arch Enemy: {villian[pos]}");
        }
        public static bool RunProgramAgain()
        {
            bool validateAgain = true;
            bool repeatProgram = true;

            while (validateAgain == true)
            {
                Console.WriteLine("Would you like to run this program again? Enter y to run again or n to quit.");
                string playAgain = Console.ReadLine();

                if (playAgain.Length > 1 || playAgain.Length == 0)
                {
                    validateAgain = true;
                }
                else if (playAgain.ToLower() == "y")
                {
                    validateAgain = false;
                    repeatProgram = true;
                    Console.Clear();

                }
                else if (playAgain.ToLower() == "n")
                {
                    validateAgain = false;
                    repeatProgram = false;

                }
                else
                {
                    validateAgain = true;
                }
            }

            return repeatProgram;

        }
    }
}
