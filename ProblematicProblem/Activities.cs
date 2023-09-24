using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    public class Activities
    {
        string userName { get; set; }
        int userAge { get; set; } 

        string randomActivity { get; set; }
        bool validAge { get; set; } = false;
        bool loopAgain { get; set; } = false;
        bool loopInput { get; set; } = false;

        List<string> defaultList = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        public void Welcome()
        {
            Console.WriteLine("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? Yes or no?");
            string userChoice1 = Console.ReadLine();
            Console.WriteLine();


            if (userChoice1.ToLower() == "no")
            {
                Console.WriteLine("Thank you for using the random activity generator! Come again soon!");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
        }

        public void UserInput()
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
        }

        public void ActivityReveal()
        {
            Console.Write("Would you like to see the current list of activities? Yes/No?");
            string userChoiceList = Console.ReadLine();
            Console.WriteLine();

            if (userChoiceList.ToLower() == "yes")
            {
                Console.WriteLine("Here are the list of available activities:");

                foreach (var activity in defaultList)
                {


                    Console.WriteLine(activity);

                }

                Console.WriteLine();
                
            }
            else
            {
                
            }
        }

        public void ActivityInput()

        {
            Console.WriteLine("Would you like to add any activities before we generate one? Yes/No:");
            string userChoiceAdd = Console.ReadLine();
            Console.WriteLine();

            if (userChoiceAdd.ToLower() == "yes")
            {
                Console.WriteLine("What activity would you like to add? ");
                string userAddition = Console.ReadLine();

                Console.WriteLine($"Added {userAddition} as an activity.");
                defaultList.Add(userAddition);
                Console.WriteLine();

                Console.WriteLine("Would you like to add more? yes/no: ");
                string userChoiceAddAnother = Console.ReadLine();

                while (userChoiceAddAnother.ToLower() == "yes")
                {
                    userAddition = "";

                    Console.WriteLine("What activity would you like to add? ");
                    userAddition = Console.ReadLine();

                    Console.WriteLine($"Added {userAddition} as an activity.");
                    defaultList.Add(userAddition);
                    Console.WriteLine();

                    Console.WriteLine("Would you like to add more? yes/no: ");
                    userChoiceAddAnother = Console.ReadLine();


                }
            }
            else
            {
              
            }
        }

        public void ActivityGen ()
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

            int randomNumber = rng.Next(defaultList.Count);
            string randomActivity = defaultList[randomNumber];

            while (userAge < 21 && randomActivity == "Wine Tasting")
            {
                Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                Console.WriteLine("Selecting another activity...");

                defaultList.Remove(randomActivity);
                randomNumber = rng.Next(defaultList.Count);
                randomActivity = defaultList[randomNumber];
            }

            Console.WriteLine($"Ah got it! {userName}, your random activity is: {randomActivity}!");
        }

        public bool LoopOrEnd()
        {
            
            Console.WriteLine("Do you want another random activity? Yes or No?");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "yes")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Thank you for using the random activity generator! Come again soon!");
                Console.ReadKey();
                return false;  
            }
        }
    }
}
