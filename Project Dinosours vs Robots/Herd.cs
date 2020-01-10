using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dinosours_vs_Robots
{
    class Herd
    {
        //member variables (HAS A)
        Dinosaur TRex = new Dinosaur("TRex",29000,55,40,60);
        Dinosaur Raptor = new Dinosaur("Raptor", 27000,45,40,60);
        Dinosaur Brontasaur = new Dinosaur("Brontasaur", 30000,65,40,60);
        public List<Dinosaur> Dinos;
 
        

        // constructor (SPAWNER)
        public Herd()
        {
            Dinos = new List<Dinosaur>();
            Dinos.Add(new Dinosaur("TRex", 30000, 65, 40, 60));
            Dinos.Add(new Dinosaur("Raptor", 27000, 45, 40, 60));
            Dinos .Add(new Dinosaur("Brontasaur",29000,55,40,60));
            



        }
        // member methods (CAN DO)





    }
}
