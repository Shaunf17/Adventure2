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
            Player p = new Player();
            p.Health = 10;

            List<Character> e = new List<Character>();
            e.Add(new Character() { Name = "Gob", Health = 8 });

            Loop(p, e);
        }

        public static void Loop(Player player, List<Character> targets)
        {
            string userInput = "";
            string[] split;
            string plural;
            plural = (targets.Count > 1) ? "Enemies" : "Enemy"; 

            while (player.Health > 0 && AreEnemiesAlive(targets))
            {
                Print.SlowLine(String.Format("Player Health: {0}", player.Health), 50);
                foreach (var enemy in targets)
                {
                    Print.SlowLine(String.Format("<red>{0}</red> Health: {1}", enemy.Name, enemy.Health), 50);
                    Print.Slow("te", 2, "st");
                }

                userInput = Console.ReadLine();
                split = userInput.Split(' ');

                switch (userInput.ToLower())
                {
                    case "attack":
                        targets.First().Health = targets.First().Health - 4;
                        player.Health -= 10;
                        break;
                }


            }

            if (player.Health <= 0)
                Print.SlowLine("You are <red>dead</red>");
            else
                Print.SlowLine(String.Format("<yellow>Congratulations!</yellow> {0} defeated!", plural), 50);
        }

        /// <summary>
        /// Iterates through the target list and checks if at least one is alive.
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