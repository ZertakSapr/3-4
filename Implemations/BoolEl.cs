using System;
using System.Collections.Generic;
using System.Text;

namespace _3_4
{
    class BoolEl : IElChoice<bool>
    {
        private static Random rnd= new Random();
        public bool UserEl()
        {
            return bool.Parse(Console.ReadLine());
        }
        public bool RndEl()
        {
            bool[] bl = { false, true };
            bool el = bl[rnd.Next(0, 2)];
            return el;
        }
    }
}
