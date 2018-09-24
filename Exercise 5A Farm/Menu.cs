using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5A_Farm
{
    public class Menu
    {
        public static void AnimalMenu()
        {
            Console.WriteLine("1 Pigs, 2 Horses, 3 Sheep, 4 Main Menu");
            var var1 = Console.ReadLine();

            if (var1 == "1")
            {
                Pigs.PigActions();
            }
            else if (var1 == "2")
            {
                Horses.HorsesActions();
            }
            else if (var1 == "3")
            {
                Sheep.SheepActions();
            }
            else if (var1 == "4")
            {
                FarmMenu.MainMenu();
            }

        }
    }
}
