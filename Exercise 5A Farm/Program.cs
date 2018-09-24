using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5A_Farm
{
    public class Program
    {
        public Pigs pig = new Pigs();
        public Horses horse = new Horses();
        public Sheep sheep = new Sheep();
        public Menu menu = new Menu();
        public FarmMenu farmmenu = new FarmMenu();

        // Allows a 1.5 second pause whenever called
        public static void Pause2Sec() => System.Threading.Thread.Sleep(1500);

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello..\n");
            Pause2Sec();
            Console.WriteLine("And welcome to George's " +
                              "\"Totally not an allegory for 1917 Russia\"...Farm\n");
            Pause2Sec();
            Console.WriteLine("What would you like to do?\n");
            FarmMenu.MainMenu();
        }
    }
}


