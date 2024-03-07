using System;
using System.Collections.Generic;
using System.Text;

namespace _3_4
{
    sealed class OneDim<T>: BaseClass
    {
        private T[] array;
        IElChoice<T> choice;
        public OneDim(int length, IElChoice<T> Choice,  bool flag = false) : base(flag)
        {
            choice = Choice;
            array = new T[length];
            TypeOfInizialization();
        }

        protected override void UserFill()
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент");
                array[i] = choice.UserEl();
            }
        }


        protected override void RndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = choice.RndEl();
            }
        }

        public override void Print()
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
