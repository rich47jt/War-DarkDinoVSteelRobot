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
       
        string Kinght;
        string Pawn;
        string Bishop;
        public List<Robot> robots;



        // constructor (SPAWNER)

        // member methods (CAN DO)
        public void RunRobotFleet() // master method
        {
            Console.WriteLine("Choose your Robot");
            Type = Convert.ToDouble(Console.ReadLine());
        }

    }
}
