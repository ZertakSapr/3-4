using System;
using System.Collections.Generic;
using System.Text;

namespace _3_4
{
    class TwoDim<T>:BaseClass
    {
        private T[,] array;

        static private Random rnd = new Random();

        IElChoice<T> choice;

        public TwoDim(int RowCount, int CountColumn, IElChoice<T> Choice, bool Flag = false) : base(Flag)
        {
            choice = Choice;
            array = new T[RowCount, CountColumn];
            TypeOfInizialization();

        }

        protected override void UserFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент");
                    array[i, j] = choice.UserEl();
                }
            }
        }

        protected override void RndFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = choice.RndEl();
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine("Массив двумерных");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string final = "";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    final += array[i, j] + " ";
                }
                Console.WriteLine(final);
            }

        }
    }
}
