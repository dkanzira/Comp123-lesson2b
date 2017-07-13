using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: Demo for lesson 9
 * version: 0.4 - Implemented the SuperHero Class
*/

namespace Comp123_lesson2b
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHero = new SuperHuman("Super Dude");
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Web Casting", 40);
            superHero.AddPower("Phasing", 50);
            superHero.AddPower("Invisibility", 30);
            Console.WriteLine(superHero.ToString());   
         
        }
    }
}
