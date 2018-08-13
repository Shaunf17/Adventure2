using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Adv_2._0.Utilities;
using Adv_2._0.Menus;

namespace Adv_2._0
{
    /// <summary>
    /// Main program class. Contains main method as entry point.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Adventure";
            Console.SetWindowSize(100, 50);


            MainMenu.Init();
            MainMenu.MainLoop();
        }

        /// <summary>
        /// Method to perform unit tests on the application.
        /// </summary>
        public static void Test()
        {

        }
    }
}
