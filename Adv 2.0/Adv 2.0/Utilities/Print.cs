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
        static int DefaultSpeed = 100;
        #region Slow method overloads
        public static void Slow(string text)
        {
            Slow(text, DefaultSpeed, "gray", false);
        }

        public static void Slow(string text, int speed)
        {
            Slow(text, speed, "gray", false);
        }

        public static void Slow(string text, string colour)
        {
            Slow(text, DefaultSpeed, colour, false);
        }

        public static void Slow(string text, bool newLine)
        {
            Slow(text, DefaultSpeed, "gray", newLine);
        }

        public static void Slow(string text, int speed, string colour)
        {
            Slow(text, speed, colour, false);
        }

        public static void Slow(string text, int speed, bool newLine)
        {
            Slow(text, speed, "gray", newLine);
        }

        public static void Slow(string text, string colour, bool newLine)
        {
            Slow(text, DefaultSpeed, colour, newLine);
        }
        #endregion

        /// <summary>
        /// Writes the text input out to the console, taking in parameters for speed, colour and carriage return 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speed"></param>
        /// <param name="colour"></param>
        /// <param name="newLine"></param>
        public static void Slow(string text, int speed, string colour, bool newLine)
        {
            StringBuilder tag = new StringBuilder();
            bool isTag = false;
            string originalColour = colour;

            ParseColour(originalColour);

            foreach (var letter in text)
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
                //return "Gray";
                return originalColour; 
            else
                return split[1];
            
        }
    }
}
