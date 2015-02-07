// Author: Han Cheng Liang
// ID: 300791705
//Programming 2 Section 062
// The making of a super hero
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    class SuperHero:Hero
    {
        //array
         private string[] superPowers;

        //constructor
        public SuperHero(string name):
            base(name)
        {
            this.generateRandomPowers();
        }
            
        //generating random powers
        private void generateRandomPowers()
        {
            string[] power={"Super Speed","Super Strength","Body Armour","Flight","Fire Generation","Weather Control"};
            this.superPowers = new string[3];
            int count = 0;
            while (count < superPowers.Length)
            {
                Random rnd = new Random();
                int number = rnd.Next(6);
                if (power[number] != "chosen")
                {
                    
                    superPowers[count] = power[number];
                    power[number] = "chosen";
                    count++;
                }
                
            }
             
        }
        //display the 3 power that is generated
        public void showPowers()
        {
            for (int count = 0; count < this.superPowers.Length; count++)
            {
                Console.WriteLine("the hero's superpower is {0}",superPowers[count]);
            }
        }

    

    
    
    }
}
    

