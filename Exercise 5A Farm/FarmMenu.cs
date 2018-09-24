using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Exercise_5A_Farm
{
    public class FarmMenu
    {
        public static void MainMenu()
        {
            Console.WriteLine("1. Meet the animals, " +
                              "\n2. Work the farm, " +
                              "\n3. Overthrow your totalitarian overlords in the name of " +
                              "\n   liberty only to inevitably become that which you swore to free yourself from" +
                              "\n4. Feed the chickens");
            var var5 = Console.ReadLine();

            if (var5 == "1")
            {
                Menu.AnimalMenu();
            }
            else if (var5 == "2")
            {
                FarmWork();
            }
            else if (var5 == "3")
            {
                Overthrow();
            }
            else if (var5 == "4")
            {
                FeedChickens();
            }
        }

        private static void Overthrow()
        {
            Console.WriteLine("The animals have risen against you, nowhere is safe. It’s time to leave " +
                              "\n     you run down the street as you hear the animals chanting " +
                              "\n   \"four legs good, two legs bad\" over and over……there is no returning, everything is lost.");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }

        private static void FeedChickens()
        {
            Console.WriteLine("The chickens have been fed and return to their Coops. " +
                              "\n   They silently judge your life decisions and talk about you when you're gone " +
                              "\n   They know your weaknesses and fears, they are the enemy of the proud and the " +
                              "\n   harbingers of judgement....do not underestimate them");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }

        private static void FarmWork()
        {
            Console.WriteLine("Great job! despite the weird looks " +
                              "\n   you have been getting from the animals recently you finished all the chores");
            Console.ReadKey();
            MainMenu();
        }
    }
}
