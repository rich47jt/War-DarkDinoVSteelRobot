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
        public int DinoHealthBar;
        public double DinoAttackPower;
        public double DinoEnergy;
        

        Weapons weapons;
        
        
        
      
        //constructor (SPAWNER)
       public Dinosaur(string DinoType,int DinoHealthBar, double DinoAttackPower,double DinoEnergy)
       {
         this.DinoType = DinoType;
         this.DinoHealthBar = DinoHealthBar;
         this.DinoAttackPower = DinoAttackPower;
         this.DinoEnergy = DinoEnergy;
         

         weapons = new Weapons("sword");
          


          

       }
             

        //member methods (CAN DO)
        public void DinoAttack(Robot robot)
        {

            robot.RobotHealthBar -= DinoAttackPower + weapons.damage;


        }   



    }
}
