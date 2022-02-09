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

            Random rand = new Random();
            int flipCoin = rand.Next(0,2);
            if (flipCoin == HEAD)
            {
                Console.WriteLine("Hurray! Head wins");
            }
            else
            {
                Console.WriteLine("Boorah! Tail wins");
            }
            Console.ReadLine();
        }
    }
}
