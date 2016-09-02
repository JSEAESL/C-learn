using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    enum GameState:byte
    {
        Pause = 100,
        Failed = 101,
        Succ = 102,
        Start = 200,

    }
    class len6
    {
        static void Main(string[] args)
        {
            GameState state = GameState.Start;
            if(state == GameState.Start)
            {
                Console.WriteLine("GameState Start");
            }
            Console.WriteLine(state);

            GameState state1 = GameState.Start;
            int num = (int)state1;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
