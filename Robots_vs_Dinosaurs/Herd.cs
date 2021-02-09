using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Herd
    {
        List<Dinosaur> dinosaurList = new List<Dinosaur>();
        Dinosaur thisIsMyDinosaur = new Dinosaur();

        public Herd()
        {
            dinosaurList.Add(thisIsMyDinosaur);
        }
    }
}
