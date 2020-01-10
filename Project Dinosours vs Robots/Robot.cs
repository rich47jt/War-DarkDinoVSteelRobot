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
        public double RobotHealthBar;
        public double RobotAttackPower;
        public double RoboWeaponDamage;
        public double RoboEnergy;
        public string RobotType;
        public  Weapons weapons;
        
  

        // constructor (SPAWNER)
        public Robot(string RobotType, double RobotHealhbar, double RobotAttackPower, double RoboWeaponDamage, double RoboEnergy)
        {
            this.RobotHealthBar = RobotHealhbar;
            this.RobotAttackPower = RobotAttackPower;
            this.RoboWeaponDamage = RoboWeaponDamage;
            this.RoboEnergy = RoboEnergy;
            this.RobotType = RobotType;
            weapons = new Weapons(40, 40, 40);
        }
        // member methods (CAN DO)
        
        public void RoboAttack(Dinosaur dinosaur)
        {
            dinosaur.DinoHealthBar -= RobotAttackPower + RoboWeaponDamage;
        }

        

        
    }
}
