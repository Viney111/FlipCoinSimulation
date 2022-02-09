using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoinSimulation
{
    internal class HEAD_TAIL_GAME
    {
        static void Main(string[] args)
        {
            //CONSTANTS
            const int HEAD = 1;
            const int TAIL = 0;
            const int flipCoinCounter = 20;

            //VARIABLES
            int headCounter = 0;
            int tailCounter = 0;
            int i = 0;

            while (i < flipCoinCounter)
            {
                Random rand = new Random();
                int flipCoin = rand.Next(0, 2);
                if (flipCoin == HEAD)
                {
                    //Console.WriteLine("Hurray! Head wins");
                    headCounter++;
                }
                else
                {
                    //Console.WriteLine("Boorah! Tail wins");
                    tailCounter++;
                }
             i++;
            }
            Console.WriteLine($"Head wins {headCounter}");
            Console.WriteLine($"Tail wins {tailCounter}");
            Console.ReadLine();
        }
    }
}
