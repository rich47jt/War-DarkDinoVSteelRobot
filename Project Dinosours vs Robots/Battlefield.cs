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

        // member methods (CAN DO)
        public void RunBattle() // master method
        {
            theFleet.robots[0].HealthBar -= theHerd.Dinos[0].attack;
        }

        public void DamageControl()
        {

        }

        public void AttackControlor()
        {

        }
            
    }
}
