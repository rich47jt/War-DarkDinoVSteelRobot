using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dinosours_vs_Robots
{
    class Dinosaur
    {
        // `member variables (HAS A)
        public string DinoType;
        public double DinoHealthBar;
        public double DinoAttackPower;
        public double DWeaponDamage;
        public double DinoEnergy;
        
        Weapons weapons;
        
        
      
        //constructor (SPAWNER)
       public Dinosaur(string DinoType,double DinoHealthBar, double DinoAttackPower, double DWeaponDamage,double DinoEnergy)
       {
          this.DinoType = DinoType;
          this.DinoHealthBar = DinoHealthBar;
          this.DinoAttackPower = DinoAttackPower;
          this.DWeaponDamage = DWeaponDamage;
          this.DinoEnergy = DinoEnergy;
          weapons = new Weapons(40,40,40);


          

       }
             

        //member methods (CAN DO)
        public void DinoAttack(Robot robot)
        {
             robot.RobotHealthBar -= DinoAttackPower + DWeaponDamage;

        }

        
        



      
        
            

        

        
        

         
            



    }
}
