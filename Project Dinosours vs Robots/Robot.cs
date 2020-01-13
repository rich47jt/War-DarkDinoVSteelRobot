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
        public double RoboEnergy;
        public int RoboAttackPower;
        public string RobotType;
        public  Weapons weapons;
        



        // constructor (SPAWNER)
        public Robot(string RobotType, double RobotHealthbar, int RoboAttackPower, double RoboEnergy)
        {
           this.RobotHealthBar = RobotHealthbar;
           this.RoboEnergy = RoboEnergy;
            this.RoboAttackPower = RoboAttackPower;
           this.RobotType = RobotType;
            weapons = new Weapons("sword");
            
            
           
        }
        // member methods (CAN DO)
        
        public void RoboAttack(Dinosaur dinosaur)
        {
           dinosaur.DinoHealthBar -= RoboAttackPower + weapons.damage;
        }

        

        
    }
}
