using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dinosours_vs_Robots
{
    class Weapons
    {
        // member variables (HAS A)
        double Weapon; 
        double Sword;
        double Axe;
        double Hammer;
        double AttackPower;
        
        

        // constructor (SPAWNER)

        public void Amory()
        {
          
        }
        


        // member methods (CAN DO)
        public void RunWeaponControlor() // master method
        {
            Console.WriteLine("choose Weapons");
           Weapon  = Convert.ToDouble(Console.ReadLine());

        }

        public void AttackPowerControlorSword()
        {
            Console.WriteLine("Sword ATK 55");
            Sword = Convert.ToDouble(Console.ReadLine());
        }

        public void AttackContorlAxe()
        {
            Console.WriteLine("Axe ATK 54");
            Axe = Convert.ToDouble(Console.ReadLine());

        }

        public void AttackControlHammer()
        {
            Console.WriteLine("Hammer ATK 54");
            Hammer = Convert.ToDouble(Console.ReadLine());

        }

    }
}
