using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    internal class Program
    {






        static void Main(string[] args)
        {

            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };


            Console.WriteLine("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? Yes or no? \nYou can press any other key to decline.");
            string userChoice1 = Console.ReadLine();
            Console.WriteLine();


            if (userChoice1.ToLower() == "no")
            {
                Console.WriteLine("Have a good day!");

            }
            else if (userChoice1.ToLower() == "yes")
            {
                Console.WriteLine("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();
                Console.WriteLine();



                while (userName == null)
                {
                    Console.WriteLine("Please input your name.");
                    userName = Console.ReadLine();
                    Console.WriteLine();
                }

                Console.WriteLine("What is your age?");
                bool validAge = Int32.TryParse(Console.ReadLine(), out int userAge);
                Console.WriteLine();



                while (!validAge)
                {
                    Console.WriteLine("Please input a valid number.");
                    Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("What is your age?");
                    validAge = Int32.TryParse(Console.ReadLine(), out userAge);
                    Console.WriteLine();
                }

                Console.Write("Would you like to see the current list of activities? Yes/No? \nYou can press any other key or decline to quit. ");
                string userChoiceList = Console.ReadLine();
                Console.WriteLine();




                if (userChoiceList.ToLower() == "no")
                {

                    Console.WriteLine("Have a good day!");
                }
                else if (userChoiceList.ToLower() == "yes")
                {
                    Console.WriteLine("Here are the list of available activities:");

                    foreach (var activity in activities)
                    {


                        Console.WriteLine(activity);

                    }

                    Console.WriteLine();

                    Console.WriteLine("Would you like to add any activities before we generate one? Yes/No:");
                    string userChoiceAdd = Console.ReadLine();
                    Console.WriteLine();

                    if (userChoiceAdd.ToLower() == "no")
                    {

                        Console.WriteLine("Connecting to the database");

                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }
                        Console.WriteLine();

                        Console.Write("Choosing your random activity");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }
                        Console.WriteLine();


                        var rng = new Random();

                        int randomNumber = rng.Next(activities.Count);
                        string randomActivity = activities[randomNumber];

                        while (userAge > 21 && randomActivity == "Wine Tasting")
                        {
                            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                            Console.WriteLine("Selecting another activity...");

                            activities.Remove(randomActivity);
                            randomNumber = rng.Next(activities.Count);
                            randomActivity = activities[randomNumber];
                        }

                        Console.WriteLine($"Ah got it! {userName}, your random activity is: {randomActivity}!");
                        Console.WriteLine("Come again for another random activity!");




                    }

                    else if (userChoiceAdd.ToLower() == "yes")
                    {



                        Console.WriteLine("What activity would you like to add? ");
                        string userAddition = Console.ReadLine();

                        Console.WriteLine($"Added {userAddition} as an activity.");
                        activities.Add(userAddition);
                        Console.WriteLine();

                        Console.WriteLine("Would you like to add more? yes/no: ");
                        string userChoiceAddAnother = Console.ReadLine();

                        while (userChoiceAddAnother.ToLower() == "yes")
                        {
                            userAddition = "";

                            Console.WriteLine("What activity would you like to add? ");
                            userAddition = Console.ReadLine();

                            Console.WriteLine($"Added {userAddition} as an activity.");
                            activities.Add(userAddition);
                            Console.WriteLine();

                            Console.WriteLine("Would you like to add more? yes/no: ");
                            userChoiceAddAnother = Console.ReadLine();

                        }



                        Console.WriteLine("Connecting to the database");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }
                        Console.WriteLine();

                        Console.Write("Choosing your random activity");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }
                        Console.WriteLine();



                        var rng = new Random();

                        int randomNumber = rng.Next(activities.Count);
                        string randomActivity = activities[randomNumber];

                        while (userAge > 21 && randomActivity == "Wine Tasting")
                        {
                            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                            Console.WriteLine("Selecting another activity...");

                            activities.Remove(randomActivity);
                            randomNumber = rng.Next(activities.Count);
                            randomActivity = activities[randomNumber];
                        }

                        Console.WriteLine($"Ah got it! {userName}, your random activity is: {randomActivity}!");
                        Console.WriteLine("Come again for another random activity!");










                    }
                    else
                    {
                        Console.WriteLine("Have a good day!");
                    }

                }
                else
                {
                    Console.WriteLine("Have a good day!");

                }











            }


        }
    }
}