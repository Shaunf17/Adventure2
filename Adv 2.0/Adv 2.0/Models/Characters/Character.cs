using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_2._0.Characters
{
    public class Character
    {
        // Basic info
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        // Stats
        public int Might { get; set; }
        public int Awareness { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }

        // Navigation Properties
    }
}
