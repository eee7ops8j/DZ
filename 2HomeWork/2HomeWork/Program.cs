using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    //1) Вывести последнюю цифру числа(3537 -> 7)
    //2) Пользователь вводит числа до тех пор пока не ввел -1, если ввел -1 я хочу узнать сумму введеных ранее чисел
    //3) Вывести на экран числа от 10 до 20 в обратном порядке
    //4) Считать с клавиатуры число и вывести все его цифры отдельно
    //5) Считать с клавиатуры число и вывести его наоборот
    //6) Найти и вывести сумму цифр числа(234 -> 9)
    //7) Вывести отдельно дробную, отдельно целую часть числа
    class Program
    {
        private static int x = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("---\n" +
                "1.Вывести последнюю цифру числа(3537 -> 7)\n" +
                "2.Пользователь вводит числа до тех пор пока не ввел -1, если ввел -1 я хочу узнать сумму введеных ранее чисел\n" +
                "3.Вывести на экран числа от 10 до 20 в обратном порядке\n" +
                "4.Считать с клавиатуры число и вывести все его цифры отдельно\n" +
                "5.Считать с клавиатуры число и вывести его наоборот\n" +
                "6.Найти и вывести сумму цифр числа(234 -> 9)\n" +
                "7.Вывести отдельно дробную, отдельно целую часть числа\n" +
                "Select action:");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: Action1(); break;
                case 2: Action2(); break;
                case 3: Action3(); break;
                case 4: Action4(); break;
                case 5: Action5(); break;
                case 6: Action6(); break;
                case 7: Action7(); break;
                default: break;
            }

        }

        static void Action1()
        {
            Console.Write("Enter your number : ");
            int a = int.Parse(Console.ReadLine());
            int b = a % 10;
            Console.WriteLine("Answer : " + b);
            Console.WriteLine();

        }
        static void Action2()
        {
            Console.Write("Enter your number : ");
            int m = 0;
            while (x != -1) // x public static 
            {
                int x = int.Parse(Console.ReadLine());
                m = m + x;
                if (x == -1)
                {
                    Console.WriteLine("summa = " + m);
                }
            }
            Console.WriteLine();
        }
        static void Action3()
        {
            for (int i = 20; i >= 10; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void Action4()
        {

        }
        static void Action5()
        {
            //Console.Write("Enter your number : ");
            //int a = int.Parse(Console.ReadLine());

            //while (a != 0)
            //{
            //    int b = a % 10;
            //    a /= 10;
            //    Console.Write(b);
            //}
            //Console.ReadLine();
        }
        static void Action6()
        {
            for (int i = 9; i <= 239; i++)
            {
                x = x + i;
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }
        static void Action7()
        {
            Console.Write("Enter your fractional numbers :\nexample - 1234, 1232\n: ");
            float a = float.Parse(Console.ReadLine());
            float b = a - a % 1;
            float c = a % 1;
            Console.WriteLine("number before float : " + b);
            Console.WriteLine("number after float : " + c);
            Console.ReadLine();
        }

    }
}
