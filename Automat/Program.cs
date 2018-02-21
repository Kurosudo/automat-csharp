using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Program
    {
        public static int penizky = 1000;
        static void Main(string[] args)
        {
            
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("|            SLOT MACHINE                        |");
            Console.WriteLine("|     Ugly code by: Kurosudo                     |");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|                  PRESS ENTER!!                 |");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|------------------------------------------------|");
            ConsoleKeyInfo start = Console.ReadKey();
            if (start.Key == ConsoleKey.Enter)
            {
                
                for (long i = 1; i > 0; i++)
                {
                    Console.Clear();
                    Roll();
                    Console.ReadKey();
                }

            }

        }

        static public void Roll()
        {
            int genwon;
            string win;

            Random random = new Random();
            int slot1 = random.Next(1, maxValue: 5);
            int slot2 = random.Next(1, maxValue: 5);
            int slot3 = random.Next(1, maxValue: 5);
            string slot1s = slot1.ToString();
            string slot2s = slot2.ToString();
            string slot3s = slot3.ToString();

            if (slot1 == slot2 && slot2 == slot3)
            {

               win = "win ";
               genwon = random.Next(1, maxValue: 20);
               penizky = penizky + genwon;
            }
            else
            {
                genwon = random.Next(1, maxValue: 20);
                penizky = penizky - genwon;
                win = "lose";

            }

            if (penizky < 0)
            {
                Console.WriteLine("You lose all your money. I hope you are happy now. Your child is sick, wife without money and you lose everything. Shame on you!");

                for (long a = 1; a > 0; a++)
                { 
                Console.ReadKey();
                }
            }

            string penizkys = penizky.ToString();
            Console.WriteLine("                |-------------|");
            Console.WriteLine("                |SLOT  MACHINE|");
            Console.WriteLine("                |-------------|");
            Console.WriteLine("                |             |");
            Console.WriteLine($"                ||{slot1s}|  |{slot2s}|  |{slot3s}||");
            Console.WriteLine("                |             |");
            Console.WriteLine("                |             |");
            Console.WriteLine("                |             |");
            Console.WriteLine($"                ||{win}|       |");
            Console.WriteLine("                |-------------|");
            Console.WriteLine("");
            Console.WriteLine($"                |{penizkys} $|");
        }

    }
}
