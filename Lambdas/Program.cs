﻿using System;

namespace Lambdas
{
    class Program
    {
        delegate string Message(string a);  //The simple delegate
        delegate int Summ(int a, int b);

        delegate void Hello();

        static void Main(string[] args)
        {
            Message message = a => a;       //The simple lambda expression
            Console.WriteLine(message("test"));

            Summ summ = (a, b) => a + b;
            Console.WriteLine(summ(5, 5));

            Hello hello;
            if (DateTime.Now.Hour < 12)
            {
                hello = GoodMorning;
            }
            else
            {
                hello = GoodEvening;
            }

            hello();
            Console.ReadKey();

        }

        private static void GoodMorning()
        {
            Console.WriteLine("Good morning Tom");
        }

        private static void GoodEvening()
        {
            Console.WriteLine("Good evening Tom");
        }
    }
}
