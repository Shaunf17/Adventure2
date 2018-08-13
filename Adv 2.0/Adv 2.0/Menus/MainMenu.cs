using Adv_2._0.Characters;
using Adv_2._0.Characters.Player;
using Adv_2._0.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_2._0.Menus
{
    /// <summary>
    /// Provides a user interface that allows for text input. Functions as a controller to call methods
    /// and present information in the form of text.
    /// </summary>
    public static class MainMenu
    {
        // Declare global variables
        static string userInput;
        static string[] userInputSplit;
        static Random random;

        /// <summary>
        /// Initialises global variables, creates new game objects and executes the main game loop
        /// </summary>
        public static void Init()
        {
            userInput = "";
            random = new Random();
        }

        /// <summary>
        /// The main game loop. Takes in user input and controls which methods are executed.
        /// </summary>
        public static void MainLoop()
        {
            Player p = new Player() { Name = "Bob", Health = 100 };
            List<Character> e = new List<Character>();
            e.Add(new Character { Name = "Hog", Health = 20 });

            while (!userInput.ToLower().Equals("exit"))
            {
                Console.Write("> ");
                userInput = Console.ReadLine();

                //if (userInput.ToLower().Equals("exit"))
                //    break;

                //if (userInput.ToLower().Equals("combat"))
                //    Combat.init(p, e);

                switch (userInput.ToLower())
                {
                    case "exit":
                        break;

                    case "combat":
                        List<Character> list = new List<Character>();
                        list.Add(new Character { Name = "awea", Health = random.Next(100) });
                        Combat.init(p, list);
                        break;
                }
            }
        }

        /// <summary>
        /// Test the console colour by typing in an enum console colour
        /// </summary>
        public static void TestInput()
        {
            Console.Write("> ");
            userInput = Console.ReadLine();

            try
            {
                Print.SlowLine("hello, world!", userInput);
            }
            catch
            {
                Print.SlowLine("Sorry, colour not recognised");
            }
        }
    }
}
