using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5A_Farm
{
    public class Horses
    {

        public static void HorsesActions()
        {
            Console.WriteLine("Horse 1, Horse 2, or Horse 3, Return 4  ");
            var var3 = Console.ReadLine();

            if (var3 == "1")
            {
                Console.WriteLine("The first horse says \"Neigh\"");
                ReturntoHorses();
            }
            else if (var3 == "2")
            {
                Console.WriteLine("The second horse gallops away");
                ReturntoHorses();
            }
            else if (var3 == "3")
            {
                Console.WriteLine("Boxer the horse couldn't be found");
                ReturntoHorses();
            }
            else if (var3 == "4")
            {
                Console.Clear();
                Menu.AnimalMenu();
            }

        }
        private static void ReturntoHorses()
        {
            HorsesActions();
        }

    }
}
