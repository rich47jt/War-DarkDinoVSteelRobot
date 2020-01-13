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

      public  Robot Knight = new Robot("Knight",1200,45,60);
      public Robot Pawn = new Robot("Pawn",1200,45,60);
      public Robot Bishop = new Robot("Bishop",1200,45,60);
      public List<Robot> Robots;
        public bool DeadRobot;


        // constructor (SPAWNER)

        public Fleet()
        {
          Robots = new List<Robot>();
          Robots.Add( new Robot("Knight",1200,45,60));
          Robots.Add(new Robot("Pawn",1200,45,60));
          Robots.Add( new Robot("Bishop",1200,45,60));
        }
        


        // member methods (CAN DO)

        public void UpdateStatusRobot()
        {
            for (int i = 0; i < Robots.Count; i++)
            {
                if (Robots[i].RobotHealthBar <= 0)
                {
                    Robots.Remove(Robots[i]);
                    i--;
                    Console.WriteLine("Robot Defeated");
                }
            }

            



            if (Robots.Count == 0)
            {
                DeadRobot = true;
            }
        }
    }
}
