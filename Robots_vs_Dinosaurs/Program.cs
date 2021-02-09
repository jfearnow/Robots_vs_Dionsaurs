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
            Herd thisIsMyHerd = new Herd();
            Console.WriteLine();

            Fleet thisIsMyFleet = new Fleet();
            Console.WriteLine();

           

            

            Weapon thisIsMyWeapon = new Weapon();
            Console.WriteLine(thisIsMyWeapon.weaponType);
        }
            

    }
}
