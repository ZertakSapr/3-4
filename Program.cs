using System;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IntEl ints = new IntEl();
            StrEl strs = new StrEl();
            DlEl dls = new DlEl();
            BoolEl bls = new BoolEl();

            IPrinter[] array = new IPrinter[8];

            Console.WriteLine("Как вы хотите заполянть массив одномерных в int");
            bool flagone = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во злементов вы хотите в одномерном масииве в int");
            int count = int.Parse(Console.ReadLine());

            OneDim<int> intels = new OneDim<int>(count, ints, flagone);
            array[0] = intels;

            Console.WriteLine("Как вы хотите заполянть массив одномерных в string");
            bool flagone1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во злементов вы хотите в одномерном масииве в string");
            int count1 = int.Parse(Console.ReadLine());

            OneDim<string> stringels = new OneDim<string>(count1, strs, flagone1);
            array[1] = stringels;

            Console.WriteLine("Как вы хотите заполянть массив одномерных в bool");
            bool flagone2 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во злементов вы хотите в одномерном масииве в bool");
            int count2 = int.Parse(Console.ReadLine());

            OneDim<bool> boolels = new OneDim<bool>(count2, bls, flagone2);
            array[2] = boolels;

            Console.WriteLine("Как вы хотите заполянть массив одномерных в double");
            bool flagone3 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во злементов вы хотите в одномерном масииве в double");
            int count3 = int.Parse(Console.ReadLine());

            OneDim<double> doublels = new OneDim<double>(count3, dls, flagone3);
            array[3] = doublels;

            Console.WriteLine("Как вы хотите заполянть массив двумерных в int");
            bool flagtwo = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во строк вы хотите в двумерном масииве в int");
            int counttwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во столбцов вы хотите в двумерном масииве в int");
            int counttwoс = int.Parse(Console.ReadLine());

            TwoDim<int> inters = new TwoDim<int>(counttwo, counttwoс, ints, flagtwo);
            array[4] = inters;

            Console.WriteLine("Как вы хотите заполянть массив двумерных в string");
            bool flagtwo1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во строк вы хотите в двумерном масииве в string");
            int counttwo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во столбцов вы хотите в двумерном масииве в string");
            int counttwoс1 = int.Parse(Console.ReadLine());

            TwoDim<string> stringers = new TwoDim<string>(counttwo1, counttwoс1, strs, flagtwo1);
            array[5] = stringers;

            Console.WriteLine("Как вы хотите заполянть массив двумерных в bool");
            bool flagtwo2 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во строк вы хотите в двумерном масииве в bool");
            int counttwo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во столбцов вы хотите в двумерном масииве в bool");
            int counttwoс2 = int.Parse(Console.ReadLine());

            TwoDim<bool> boolers = new TwoDim<bool>(counttwo2, counttwoс2, bls, flagtwo2);
            array[6] = boolers;

            Console.WriteLine("Как вы хотите заполянть массив двумерных в double");
            bool flagtwo3 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во строк вы хотите в двумерном масииве в double");
            int counttwo3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во столбцов вы хотите в двумерном масииве в double");
            int counttwoс3 = int.Parse(Console.ReadLine());

            TwoDim<double> doublers = new TwoDim<double>(counttwo3, counttwoс3, dls, flagtwo3);
            array[7] = doublers;

            for(int i=0; i<8; i++)
            {
                array[i].Print();
            }
        }
    }
}
