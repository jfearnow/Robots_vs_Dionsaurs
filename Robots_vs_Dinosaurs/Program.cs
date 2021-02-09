using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot thisIsMyRobot = new Robot();

            Console.WriteLine(thisIsMyRobot.name);

            Dinosaur thisIsMyDinosaur = new Dinosaur();

            Console.WriteLine(thisIsMyDinosaur.type);

            Weapon thisIsMyWeapon = new Weapon();
            Console.WriteLine(thisIsMyWeapon.weaponType);
        }
            

    }
}
