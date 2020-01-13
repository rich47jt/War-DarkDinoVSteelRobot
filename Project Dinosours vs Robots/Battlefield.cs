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
        
        Herd theHerd;
        Fleet theFleet;
        



        // constructor (SPAWNER)
        public Battlefield()
        {
            this.theFleet = new Fleet();
            this.theHerd = new Herd();
            StartBattlefield();
            Battle();
            Console.ReadLine();
        }
        // member methods (CAN DO)

        public void StartBattlefield() 

        {
            Console.WriteLine("START");
            
        }

        public void Battle()
        {

            
            
            while(theHerd.DeadDino != true && theFleet.DeadRobot != true)

            {
                
                
                for (int i = 0; i < theHerd.Dinos.Count; i++)
                {
                    
                    theHerd.Dinos[i].DinoAttack(theFleet.Robots[0]);
                    Console.WriteLine("Attacking");
                    Console.ReadLine();

                }

                for (int i = 0; i < theFleet.Robots.Count; i++)
                {
                    theFleet.Robots[i].RoboAttack(theHerd.Dinos[0]);
                  
                    Console.WriteLine("Attacking");
                    Console.ReadLine();

                }

                    theHerd.UpdateStatusDino();
                theFleet.UpdateStatusRobot();
               

      
            }

                    
        }

      
         

       
       




    }
    
}
