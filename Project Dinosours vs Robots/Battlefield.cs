using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dinosours_vs_Robots
{
    class Battlefield
    {
        // member variables (HAS A)
        Weapons weapons;
        Herd theHerd;
        Fleet theFleet;



        // constructor (SPAWNER)
        public Battlefield()
        {
            this.theFleet = new Fleet();
            this.theHerd = new Herd();
            StartBattlefield();
        }
        // member methods (CAN DO)

        public void StartBattlefield() //master method

        {
            Console.WriteLine("START");
            
        }

        public void Battle()
        {
           

            
            while(theHerd.Dinos[0].DinoHealthBar > 0 && theFleet.Robots[0].RobotHealthBar >0)
            {
                for (int i = 0; i > theHerd.Dinos.Count; i++)
                {
                    theFleet.Robots[i].RoboAttack(theHerd.Dinos[i]);
                    theHerd.Dinos[i].DinoAttack(theFleet.Robots[i]);
                }
            }

                    
        }

        public bool CheckHealth()
        {

        }

     




















        




    


    }
    
}
