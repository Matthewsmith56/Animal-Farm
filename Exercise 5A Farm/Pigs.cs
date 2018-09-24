using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Exercise_5A_Farm
{
    public class Pigs
    {

        public static void PigActions()
        {

            Console.WriteLine("Pig 1, Pig 2, or Pig 3, Return 4");
            var var2 = Console.ReadLine();

            if (var2 == "1")
            {
                Console.WriteLine("The first pig says \"Oink\"");
                ReturntoPigs();
            }   
            else if (var2 == "2")
            {
                Console.WriteLine("The second pig rolls in the mud");
                ReturntoPigs();
            }
            else if (var2 == "3")
            {
                Console.WriteLine("Napoleon the pig says \"All animals are equal, " +
                                  "but some animals are more equal than others\"...Oink");
                ReturntoPigs();

            }
            else if (var2 == "4")
            {
                Console.Clear();
                Menu.AnimalMenu();
            }
            //else if (var2 == "5")
            //{
            //    Menu.AnimalMenu();
            //}
        }
        private static void ReturntoPigs()
        {
            PigActions();
        }
    }
}
