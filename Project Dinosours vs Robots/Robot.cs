using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dinosours_vs_Robots
{
    class Robot
    {
        // member variables (HAS A)
        string Kinght;
        string Pawn;
       
      string Bishop;
        
        
      public  double HealthBar;
       double  PowerLevel;

        
       

        // constructor (SPAWNER)

        // member methods (CAN DO)
        public void RobotContolor() // master method
        {
            
        }

        public void HealthControlor()
        {
            Console.WriteLine("Health 100");
            HealthBar = Convert.ToDouble(Console.ReadLine());
        }

        public void PowerControlr()
        {
            Console.WriteLine("Power 100");
            PowerGauge = Convert.ToDouble(Console.ReadLine());
        }

    }
}
