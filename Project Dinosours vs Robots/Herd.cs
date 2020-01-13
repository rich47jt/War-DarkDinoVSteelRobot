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
        Dinosaur TRex = new Dinosaur("TRex",1000,55,60);
        Dinosaur Raptor = new Dinosaur("Raptor", 1000,45,60);
        Dinosaur Brontasaur = new Dinosaur("Brontasaur", 1000,65,60);
        public List<Dinosaur> Dinos;
        public bool DeadDino;
        

        // constructor (SPAWNER)
        public Herd()
        {
            Dinos = new List<Dinosaur>();
            Dinos.Add(new Dinosaur("TRex", 1000, 40, 60));
            Dinos.Add(new Dinosaur("Raptor", 1000, 40, 60));
            Dinos .Add(new Dinosaur("Brontasaur",1000,40,60));
            DeadDino = false;
            



        }
        // member methods (CAN DO)


        public void UpdateStatusDino()
        {
            for(int i = 0; i < Dinos.Count; i++)
            {
                if (Dinos[i].DinoHealthBar <= 0)
                {
                    Dinos.Remove(Dinos[i]);
                     i--;
                    Console.WriteLine("DinoDefeated");
                    
                }
            }

           



            if (Dinos.Count == 0)
            {
                DeadDino = true;
            }


        }








    }
}
