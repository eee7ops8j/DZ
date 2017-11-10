using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ДЗ
//1) написать метод возведения числа в степень
//2) написать свой метод int.TryParse

namespace ConsoleApp24
{
    class Program
    {
        //public static string outChar, outPassword;
        //public static int outPassword;
        public static void RaisingPower(int x, int y)
        {
            int a = x;
            int b;
            int c = 1;
            do
            {
                b = a * x;
                a = b;
                c++;
            }
            while (c < y);
            Console.WriteLine("Число {0} в степени {1} равно {2}", x, y, a);
        }
       
        
        class NewTryParse
        {
            public void Test(int inPassword)
            {
                string outPassword="";
                for (int i = 1; i < inPassword + 1; i++)
                {

                    int z;
                    string y;
                    Random rnd = new Random(DateTime.Now.Millisecond + (i * 1000));
                    z = rnd.Next(33, 126);
                    outPassword += (char)z;
                }

                Console.Write("Ваш новый пароль: {0}", outPassword);
            }

            public void Test(string inChar)
            {
                string x = inChar;


                if (x == "A" || x == "a") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 1);
                if (x == "B" || x == "b") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 2);
                if (x == "C" || x == "c") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 3);
                if (x == "D" || x == "d") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 4);
                if (x == "E" || x == "E") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 5);
                if (x == "F" || x == "f") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 6);
                if (x == "G" || x == "g") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 7);
                if (x == "H" || x == "h") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 8);
                if (x == "I" || x == "i") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 9);
                if (x == "J" || x == "j") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 10);
                if (x == "K" || x == "k") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 11);
                if (x == "L" || x == "l") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 12);
                if (x == "M" || x == "m") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 13);
                if (x == "N" || x == "n") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 14);
                if (x == "O" || x == "o") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 15);
                if (x == "P" || x == "p") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 16);
                if (x == "Q" || x == "q") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 17);
                if (x == "R" || x == "r") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 18);
                if (x == "S" || x == "s") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 19);
                if (x == "T" || x == "t") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 20);
                if (x == "U" || x == "u") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 21);
                if (x == "V" || x == "v") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 22);
                if (x == "W" || x == "w") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 23);
                if (x == "X" || x == "x") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 24);
                if (x == "Y" || x == "y") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 25);
                if (x == "Z" || x == "z") Console.Write("у буквы '{0}' индекс '{1}'", inChar, 26);
              
            }

        }

        static void Main(string[] args)
        {
            NewTryParse TryParse = new NewTryParse();
            Console.WriteLine("Введите номер задания");
            Console.WriteLine("1:Возведение числа в степень");
            Console.WriteLine("2:Новый метод int.TryParse");
            Console.Write(":");
            int q = int.Parse(Console.ReadLine());

            switch (q)
            {
                case 1:
                    Console.Write("Число :");
                    int inNamber = int.Parse(Console.ReadLine());
                    Console.Write("Степень :");
                    int inPower = int.Parse(Console.ReadLine());
                    RaisingPower(inNamber, inPower);
                    break;
                case 2:
                    Console.WriteLine("1:Метод создания рандом пароля в (ASCII от 33 до 126):");
                    Console.WriteLine("2:Метод получения индекса буквы в Англ.алфавите(инфо:A=1)");
                    int p = int.Parse(Console.ReadLine());
                    switch (p)
                    {
                        case 1:
                            Console.Write("Длина пароля:");
                            int inPassword = int.Parse(Console.ReadLine());
                            TryParse.Test(inPassword);
                            break;
                        case 2:
                            Console.Write("Буква :");
                            string inChar = Console.ReadLine();
                            TryParse.Test(inChar);
                            break;
                        default: break;
                    }
                    break;
                default: break;
            }
            Console.ReadLine();
        }
    }
}
