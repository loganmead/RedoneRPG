using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoneRPG
{
    class Start
    {
        public static void Setup()
        {
            bool firstTime = true;


            if (firstTime)
            {
                Console.WriteLine("Herro Hero, type your name");
                string heroName = Console.ReadLine();
                Console.WriteLine("Hello " + heroName);
                Console.ReadLine();
                Rules.Instruc();
                firstTime = false;
            }

            else
            {
                Console.WriteLine("We notice you are not a first time player... :)");
            }

            




        }
    }
}
