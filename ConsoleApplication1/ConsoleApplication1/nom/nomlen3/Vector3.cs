using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen3
{
    public class Vector3
    {
        public Vector3()
        {
            Console.WriteLine("Vector3调用了");
        }

        private float x, y, z, length;
        private int age;

        public Vector3(float x,float y,float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.length = Length();
        }

        public float Length()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public int Age
        {
            set
            {
                if(value >=0)
                {
                age = value;
                }
            }
        }

        public float getX()
        {
            return x;
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public void SetX(float x)
        {
            this.x = x;
        }

        public void SetY(float y)
        {
            this.y = y;
        }

        public void SetZ(float z)
        {
            this.z = z;
        }

        public int MyIntProperty
        {
            set
            {
                Console.WriteLine("属性set被调用");
                Console.WriteLine("在set中被调用的value值为:" + value);
            }
            get
            {
                Console.WriteLine("属性get被调用");
                return 100;
            }
        }
    }
}
