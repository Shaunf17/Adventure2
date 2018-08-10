using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Adv_2._0.Utilities
{
    public static class Print
    {
        static int DefaultSpeed = 50;
        #region Slow method overloads
        /// <summary>
        /// Print the text slowly to the screen.
        /// </summary>
        /// <param name="text"></param>
        public static void Slow(string text)
        {
            Slow(text, DefaultSpeed, "gray", false);
        }
        /// <summary>
        /// Print the text slowly to the screen, specifying speed.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speed"></param>
        public static void Slow(string text, int speed)
        {
            Slow(text, speed, "gray", false);
        }
        /// <summary>
        /// Print the text slowly to the screen, specifying colour.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="colour"></param>
        public static void Slow(string text, string colour)
        {
            Slow(text, DefaultSpeed, colour, false);
        }
        /// <summary>
        /// Print the text slowly to the screen, specifying speed and colour.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speed"></param>
        /// <param name="colour"></param>
        public static void Slow(string text, int speed, string colour)
        {
            Slow(text, speed, colour, false);
        }
        /// <summary>
        /// Print the text slowly to the screen with a new line.
        /// </summary>
        /// <param name="text"></param>
        public static void SlowLine(string text)
        {
            Slow(text, DefaultSpeed, "gray", true);
        }
        /// <summary>
        /// Print the text slowly to the screen with a new line, specifying speed.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speed"></param>
        public static void SlowLine(string text, int speed)
        {
            Slow(text, speed, "gray", true);
        }
        /// <summary>
        /// Print the text slowly to the screen with a new line, specifying colour.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="colour"></param>
        public static void SlowLine(string text, string colour)
        {
            Slow(text, DefaultSpeed, colour, true);
        }
        /// <summary>
        /// Print the text slowly to the screen with a new line, specifying speed and colour.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speed"></param>
        /// <param name="colour"></param>
        public static void SlowLine(string text, int speed, string colour)
        {
            Slow(text, speed, colour, true);
        }
        #endregion

        /// <summary>
        /// Writes the text input out to the console, taking in parameters for speed, colour and carriage return.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speed"></param>
        /// <param name="colour"></param>
        /// <param name="newLine"></param>
        public static void Slow(string text, int speed, string colour, bool newLine)
        {
            StringBuilder tag = new StringBuilder();    // Declare new StringBuilder tag
            bool isTag = false;                         // Sets if input stream should be evaluated as a tag
            string originalColour = colour;             // Original colour that was passed in as a paramater

            ParseColour(originalColour);                // Sets the foreground colour to the colour that was passed in

            foreach (var letter in text)                //Loops through each letter in the input text
            {
                if (letter.Equals('<'))
                {
                    tag.Clear();
                    isTag = true;
                }
                    
                if (isTag)
                    tag.Append(letter);
                else
                {
                    Console.Write(letter);
                    Thread.Sleep(speed);
                }

                if (letter.Equals('>'))
                {
                    isTag = false;
                    ParseColour(GetColourFromTag(tag, originalColour));
                }
            }
            if (newLine)
                Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Determines the colour of the Slow method input parameter.
        /// </summary>
        /// <param name="colour"></param>
        /// <returns></returns>
        private static void ParseColour(string colour)
        {
            if (colour.ToLower().StartsWith("dark"))
                colour = colour.Substring(0, 4) + colour[4].ToString().ToUpper() + colour.Substring(colour.Length - (colour.Length - 5));

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), char.ToUpper(colour[0]) + colour.Substring(1));
        }

        /// <summary>
        /// Reads the string between the two tags and returns it. If it detects a closing tag it returns the colour the console was first set to.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="originalColour"></param>
        /// <returns></returns>
        private static string GetColourFromTag(StringBuilder tag, string originalColour)
        {
            string text = tag.ToString();
            string[] split;

            split = text.Split('<', '>');
            if (split[1].StartsWith("/"))
                return originalColour; 
            else
                return split[1];
            
        }
    }
}
