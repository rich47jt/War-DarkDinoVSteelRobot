using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dinosours_vs_Robots
{
    class Fleet
    {
        // member variables (HAS A)

      public  Robot Knight = new Robot("Knight",26000,60,40,60);
      public Robot Pawn = new Robot("Pawn",31000,56,40,60);
      public Robot Bishop = new Robot("Bishop",37000,49,40,60);
      public List<Robot> Robots;


        // constructor (SPAWNER)

        public void FleetRobots()
        {
          Robots = new List<Robot>();
            

          Robots.Add( new Robot("Knight",26000,60,40,60));
          Robots.Add(new Robot("Pawn",31000,56,40,60));
          Robots.Add( new Robot("Bishop",37000,49,40,60));
        }
        


        // member methods (CAN DO)


    }
}
