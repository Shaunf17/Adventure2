using Adv_2._0.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_2._0.Menus
{
    public static class MainMenu
    {
        static string userInput;
        static string[] userInputSplit;

        public static void Init()
        {
            userInput = "";
        }

        public static void MainLoop()
        {
            while (!userInput.ToLower().Equals("exit"))
            {
                Console.Write("> ");
                userInput = Console.ReadLine();

                try
                {
                    Print.Slow("hello, world!", userInput, true);
                }
                catch
                {
                    Print.Slow("Sorry, colour not recognised", true); 
                }
            }
        }
    }
}
