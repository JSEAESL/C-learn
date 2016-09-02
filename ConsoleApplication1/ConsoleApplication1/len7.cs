using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    struct Position
    {
        public float x;
        public float y;
        public float z;
    }
    enum Direction
    {
        West,
        North,
        East,
        South
    }
    struct Path
    {
        public float dis;
        public Direction dir;
    }
    class len7
    {

        static void Main(string[] args)
        {
            Position emePos;
            emePos.x = 100;

            Path myPath;
            myPath.dis = 100;
            myPath.dir = Direction.East;

        }
    }
}
