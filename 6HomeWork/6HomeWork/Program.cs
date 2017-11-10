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
            public string Test(int inPassword, out string outPassword)
            {
                outPassword = "";
                for (int i = 1; i < inPassword + 1; i++)
                {

                    int z;
                    string y;
                    Random rnd = new Random(DateTime.Now.Millisecond + (i * 1000));
                    z = rnd.Next(33, 126);
                    outPassword += (char)z;
                 

                }
                return outPassword;
                //   Console.Write("Ваш новый пароль: {0}", outPassword);
            }

            public int Test(string inChar, out int outChar)
            {
                string x = inChar;


                if (x == "A" || x == "a") return outChar = 1;
                if (x == "B" || x == "b") return outChar = 2;
                if (x == "C" || x == "c") return outChar = 3;
                if (x == "D" || x == "d") return outChar = 4;
                if (x == "E" || x == "E") return outChar = 5;
                if (x == "F" || x == "f") return outChar = 6;
                if (x == "G" || x == "g") return outChar = 7;
                if (x == "H" || x == "h") return outChar = 8;
                if (x == "I" || x == "i") return outChar = 9;
                if (x == "J" || x == "j") return outChar = 10;
                if (x == "K" || x == "k") return outChar = 11;
                if (x == "L" || x == "l") return outChar = 12;
                if (x == "M" || x == "m") return outChar = 13;
                if (x == "N" || x == "n") return outChar = 14;
                if (x == "O" || x == "o") return outChar = 15;
                if (x == "P" || x == "p") return outChar = 16;
                if (x == "Q" || x == "q") return outChar = 17;
                if (x == "R" || x == "r") return outChar = 18;
                if (x == "S" || x == "s") return outChar = 19;
                if (x == "T" || x == "t") return outChar = 20;
                if (x == "U" || x == "u") return outChar = 21;
                if (x == "V" || x == "v") return outChar = 22;
                if (x == "W" || x == "w") return outChar = 23;
                if (x == "X" || x == "x") return outChar = 24;
                if (x == "Y" || x == "y") return outChar = 25;
                if (x == "Z" || x == "z") return outChar = 26;
                return outChar = 0;

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
                            string outPassword;
                            Console.Write("Длина пароля:");
                            //string outPassword = "";
                         int inPassword = int.Parse(Console.ReadLine());
                            //  int inPassword = TryParse.Test(Console.ReadLine()),out string outPassword);
                            TryParse.Test(inPassword, out outPassword);
                            Console.WriteLine(outPassword);

                            //  Console.WriteLine("{0} {1}",TryParse.Test(inPassword, out outPassword));
                            //TryParse.Test(inPassword);
                            break;
                        case 2:
                            int outChar;
                            Console.Write("Буква :");
                            string inChar = Console.ReadLine();
                            TryParse.Test(inChar, out outChar);
                            Console.WriteLine(outChar);
                            //Console.WriteLine("{0} {1}", TryParse.Test(Console.ReadLine(), out outChar));
                            //   TryParse.Test(inChar);
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
