using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
     class Robot
     {
        public string name;
        public int health;
        public int powerLevel;
        public string weaponChoice;
        public int attackPower;

        public Robot()
        {
            name = "Choose your name: ";
            health = 100;
            powerLevel = 100;
            weaponChoice = "Choose your weapon: ";
            attackPower = 200;
        }
     }
}
