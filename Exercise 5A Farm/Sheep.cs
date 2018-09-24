using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5A_Farm
{
    public class Sheep
    {
        public static void SheepActions()
        {
            Console.WriteLine("Sheep 1, Sheep 2, Sheep 3, Return 4 ");
            var var4 = Console.ReadLine();

            if (var4 == "1")
            {
                Console.WriteLine("The first sheep says \"Bahh\"");
                SheepActions();
            }
            else if (var4 == "2")
            {
                Console.WriteLine("The second sheep is eating grass");
                SheepActions();
            }
            else if (var4 == "3")
            {
                Console.WriteLine("The third sheep says \"We haven't tried real socialism\"");
                SheepActions();
            }
            else if (var4 == "4")
            {
                Console.Clear();
                Menu.AnimalMenu();
            }
        }
        private static void ReturntoSheep()
        {
            SheepActions();
        }
    }
}
