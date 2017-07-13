using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: Demo for lesson 9
 * version: 0.3 - 
*/

namespace Comp123_lesson2b
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider Climbing", 50);
            superHuman.AddPower("Web Casting", 40);
            superHuman.AddPower("Phasing", 50);
            superHuman.AddPower("Invisibility", 30);
            Console.WriteLine(superHuman.ToString());   
         
        }
    }
}
