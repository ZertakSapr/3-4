using System;
using System.Collections.Generic;
using System.Text;

namespace _3_4
{
    class DlEl : IElChoice<double>
    {
        private static Random rnd = new Random();
        public double UserEl()
        {
            return int.Parse(Console.ReadLine());
        }
        public double RndEl()
        {
            return rnd.NextDouble() * (200) - 100;
        }
    }
}
