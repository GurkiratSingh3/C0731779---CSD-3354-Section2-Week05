using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731779
{
    class C0731779
    {
        static int i = 0;
        static void Main(string[] args)
        {
            methodA();   
        }
        public static void methodA()
        {
           
            while (Peanut())
            {
                
                Console.WriteLine("i is {0}", i);
                if (i > 10) 
                {
                    return;
                }
            }
        }
        public static bool Peanut()
        {
             i++;
             return true;
        }
    }
}
