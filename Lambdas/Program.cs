using System;

namespace Lambdas
{
    class Program
    {
        enum Colors
        {
            Pink,
            White
        }

        delegate string Message(string a);  //The simple delegate
        delegate int Summ(int a, int b);
        delegate void Hello();

        static void Main(string[] args)
        {
            Console.WriteLine(Colors.Pink);

            Message message = a => a;       //The simple lambda expression
            Console.WriteLine(message("test"));

            string test2 = message("test2");
            Console.WriteLine(test2);

            Summ summ = (a, b) => a + b;
            Console.WriteLine(summ(5, 5));

            Hello hello1 = () => Console.WriteLine("Hello Masha");
            hello1();

            Hello hello2 = () => GoodEveningMasha();
            hello2();

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

        private static void GoodEveningMasha()
        {
            Console.WriteLine("Good evening Masha");
        }
    }
}
