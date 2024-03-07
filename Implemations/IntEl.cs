using System;
using System.Collections.Generic;
using System.Text;

namespace _3_4
{
    class IntEl : IElChoice<int>
    {
        private static Random rnd= new Random();
        public int UserEl()
        {
            return int.Parse(Console.ReadLine());
        }
        public int RndEl()
        {
            return rnd.Next(-100, 101);
        }
    }
}
