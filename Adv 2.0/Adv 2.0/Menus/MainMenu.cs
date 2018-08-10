﻿using Adv_2._0.Utilities;
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

        /// <summary>
        /// Initialises global variables, creates new game objects and executes the main game loop
        /// </summary>
        public static void Init()
        {
            userInput = "";
            Console.Title = "Adventure";
        }

        /// <summary>
        /// The main game loop. Takes in user input and controls which methods are executed.
        /// </summary>
        public static void MainLoop()
        {
            while (!userInput.ToLower().Equals("exit"))
            {
                Console.Write("> ");
                userInput = Console.ReadLine();

                if (userInput.ToLower().Equals("exit"))
                    break;

                if (userInput.ToLower().Equals("combat"))
                    Combat.init();
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
