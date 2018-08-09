using Adv_2._0.Characters;
using Adv_2._0.Characters.Player;
using Adv_2._0.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_2._0
{
    public static class Combat
    {
        public static void init()
        {

        }

        public static void Loop(Player player, List<Character> targets)
        {
            string userInput = "";
            string[] split;

            while (player.Health > 0 || AreEnemiesAlive(targets))
            {
                Print.Slow(String.Format("Player Health: {0}", player.Health), 50, true);
                foreach (var enemy in targets)
                {

                }

                userInput = Console.ReadLine();
                split = userInput.Split(' ');

                switch (userInput.ToLower())
                {
                    case "attack":
                        break;
                }
            }
        }

        /// <summary>
        /// Iterates through the target list and checks if at least one is alive
        /// </summary>
        /// <param name="targets"></param>
        /// <returns></returns>
        public static bool AreEnemiesAlive(List<Character> targets)
        {
            bool atLeastOneAlive = false;

            foreach (var enemy in targets)
            {
                if (enemy.Health > 0)
                    atLeastOneAlive = true;
            }

            return atLeastOneAlive;
        }
    }
}
