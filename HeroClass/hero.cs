using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroClass
{

        class Hero
    {
        //private property
        private int strength;

        private int speed;

        private int health;



        //public property
        public string name;

            
    
        //constuctor
        public Hero(string name)
        {
            this.name = name;
            this.generateAbilities();
        }

        private void generateAbilities()
        {
            Random number = new Random();
            this.strength = number.Next(100) + 1;
            this.speed = number.Next(100) + 1;
            this.health = number.Next(100) + 1;
        }

        public void fight()
        {
            if (this.hitAttempt())
            {
                int damageRate = this.hitDamage();
                Console.WriteLine("Attack success, {0} damage to ememy", damageRate);


            }
            
