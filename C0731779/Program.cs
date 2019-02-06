using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731779
{
    class C0731779
    {
        static void Main(string[] args)
        {
            methodA();
        }
        public static void methodA()
        {
            while (Peanut())
            {
                Console.WriteLine("I am stuck in a infinite loop.");
            }
        }
        public static bool Peanut()
        {
            return true;
        }
    }
}
