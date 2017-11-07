using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    ////11. Найти сумму элементов массива
    ////12. Найти произведение элементов массива
    ////13. Найти минимальный элемент массива
    ////14. Найти максимальный элемент массива
    ////15. Найти среднее арифметическое элементов массива
    ////16. Поменять местами минимальный и максимальный элементы массива
    ////17. Считать с клавиатуры размер двух массивов, поэлементно их сравнить
    ////18. Удвоить значение всех элементов массива
    ////19. Считать с клавиатуры массив строк заданного пользователем размера.Считать еще одну строку, вывести все строки содержащие данную строку и индекс с которого такая подстрока начинается
    ////20. Считать с клавиатуры массив строк заданного пользователем размера. Считать еще одну строку, удалить из всех строк вхождение данной строки

    class Program
    {
        private static int x = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("11.Найти сумму элементов массива\n" +
                              "12.Найти произведение элементов массива\n" +
                              "13.Найти минимальный элемент массива\n" +
                              "14.Найти максимальный элемент массива\n" +
                              "15.Найти среднее арифметическое элементов массива\n" +
                              "16.Поменять местами минимальный и максимальный элементы массива\n" +
                              "17.Считать с клавиатуры размер двух массивов, поэлементно их сравнить\n" +
                              "18.Удвоить значение всех элементов массива\n" +
                              "19.Считать с клавиатуры массив строк заданного пользователем размера.Считать еще одну строку,\n" +
                              "    вывести все строки содержащие данную строку и индекс с которого такая подстрока начинается\n" +
                              "20.Считать с клавиатуры массив строк заданного пользователем размера.Считать еще одну строку,\n" +
                              "    удалить из всех строк вхождение данной строки\n" +
                              "21.Пользователь вводит числа с клавиатуры до тех пор пока не ввел не число и заполняет массив,\n" +
                              "    размер массива не известен, изначально пусть будет на 1 элемент, когда массив будет полностью\n" +
                              "    заполнен надо его расширить на 1 элемент и снова дать пользователю возможность вводить числа,\n" +
                              "    когда пользователь введет не число, вывести на экран этот массив");
            Console.Write("Enter action : ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 11: Action1(); break;
                case 12: Action2(); break;
                case 13: Action3(); break;
                case 14: Action4(); break;
                case 15: Action5(); break;
                case 16: Action6(); break;
                case 17: Action7(); break;
                case 18: Action8(); break;
                case 19: Action9(); break;
                case 20: Action10(); break;
                case 21: Action11(); break;

                default: break;
            }
        }
        static void Action1()               //Найти сумму элементов массива
        {
            Console.Write("Array size: ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.Write("Massive:");
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write("{0: 0}", a[i]);
            }
            int c = 0;
            for (int i = 0; i < b; i++)
            {
                c = c + a[i];
            }
            Console.Write("\nArray +: " + c);
            Console.ReadLine();
        }
        static void Action2()           //Найти произведение элементов массив
        {
            Console.Write("Array size: ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.Write("Massive:");
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write("{0: 0}", a[i]);
            }
            int c = 1;
            for (int i = 0; i < b; i++)
            {
                c = a[i] * c;
            }
            Console.Write("\nArray *: " + c);
            Console.ReadLine();
        }
        static void Action3()           //.Найти минимальный элемент массива
        {
            Console.Write("Array size: ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.Write("Massive:");
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write("{0: 0}", a[i]);
            }
            int mintemp = a[0];
            //min = a.Min();
            for (int i = 0; i < b; i++)
            {
                if (mintemp > a[i])
                {
                    mintemp = a[i];

                }
            }
            Console.WriteLine("\nMin : " + mintemp);
            Console.ReadLine();
        }
        static void Action4()               //Найти максимальный элемент массива
        {
            Console.Write("Array size: ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.Write("Massive:");
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write("{0: 0}", a[i]);
            }
            int maxtemp = a[0];
            //max = a.Max();
            for (int i = 0; i < b; i++)
            {
                if (maxtemp < a[i])
                {
                    maxtemp = a[i];
                }
            }
            Console.WriteLine("\nMax : " + maxtemp);
            Console.ReadLine();
        }
        static void Action5()       //Найти среднее арифметическое элементов массива
        {
            Console.Write("Array size: ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.Write("Massive:");
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write("{0: 0}", a[i]);
            }
            Console.WriteLine();
            int c = 0;
            for (int i = 0; i < b; i++)
            {
                c = c + a[i];
            }
            int average = c / b;
            //  for (int i = 0; i < b; i++) { Console.Write("{0: 0}", a[i] + "+"); } Console.WriteLine("/"+b+"="+ average);
            Console.Write("\nAverage : " + average);
            Console.ReadLine();
        }
        static void Action6()     //Поменять местами минимальный и максимальный элементы массива
        {
            Console.Write("Array size: ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.Write("Massive         :");
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write("{0: 0}", a[i]);
            }
            int mintemp = a[0];
            int itempmin = 0;
            for (int i = 0; i < b; i++)
            {
                if (mintemp > a[i])
                {
                    mintemp = a[i];
                    itempmin = i;
                }
            }
            int maxtemp = a[0];
            int itempmax = 0;
            for (int i = 0; i < b; i++)
            {
                if (maxtemp < a[i])
                {
                    maxtemp = a[i];
                    itempmax = i;
                }
            }
            a[itempmax] = mintemp;
            a[itempmin] = maxtemp;
            Console.Write("\nreverse max/min :");
            for (int i = 0; i < b; i++)
            {
                Console.Write("{0: 0}", a[i]);
            }
            Console.ReadLine();
        }
        static void Action7()       //Считать с клавиатуры размер двух массивов, поэлементно их сравнить
        {
            Console.Write("Array size 1: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Array size 2: ");
            int c = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.Write("Massive 1   :");
            int[] a1 = new int[b];
            for (int i = 0; i < b; i++)
            {
                a1[i] = rnd.Next(1, 100);
                Console.Write("{0: 0}", a1[i]);
            }
            Console.Write("\nMassive 2   :");
            int[] a2 = new int[c];
            for (int i = 0; i < c; i++)
            {
                a2[i] = rnd.Next(1, 100);
                Console.Write("{0: 0}", a2[i]);
            }
            //int j;
            //if (b < c) { j = c; }
            //else { j = b; }
            Console.WriteLine();
            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a1[i] < a2[j]) { Console.WriteLine(a1[i] + " < " + a2[j]); }
                    if (a1[i] > a2[j]) { Console.WriteLine(a1[i] + " > " + a2[j]); }
                    if (a1[i] == a2[j]) { Console.WriteLine(a1[i] + " = " + a2[j]); }
                }
            }
            Console.ReadLine();

        }
        static void Action8()       //Удвоить значение всех элементов массива
        {
            Console.Write("Array size: ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.Write("Massive     :");
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write("{0: 0}", a[i]);
            }
            Console.Write("\nMassive *2  :");

            for (int i = 0; i < b; i++)
            {
                int j = 0;
                j = a[i];
                j = j * 2;
                a[i] = j;
                Console.Write("{0: 0}", a[i]);
            }
            Console.ReadLine();

        }
        static void Action9()       //Считать с клавиатуры массив строк заданного пользователем размера.Считать еще одну строку,
                                    //вывести все строки содержащие данную строку и индекс с которого такая подстрока начинается
        {
            Console.Write("String Array size: ");
            int b = int.Parse(Console.ReadLine());
            string[] str = new string[b];
            for (int i = 0; i < b; i++)
            {
                Console.Write("Str {0}:", i + 1);
                str[i] = Console.ReadLine();
            }
            Console.Write("Enter string search: ");
            string str1 = Console.ReadLine();

            for (int i = 0; i < b; i++)
            {
                if (str[i] == str1) { Console.Write("\nindex : {0} - string : {1}", i, str[i]); }
            }
            Console.ReadLine();
        }



        static void Action10()      //Считать с клавиатуры массив строк заданного пользователем размера.Считать еще одну строку, удалить из всех строк вхождение данной строки\n" +
        {
            Console.Write("String Array size: ");
            int b = int.Parse(Console.ReadLine());
            string[] str = new string[b];
            for (int i = 0; i < b; i++)
            {
                Console.Write("Str {0}:", i + 1);
                str[i] = Console.ReadLine();
            }
            Console.Write("Enter string delete: ");
            string str1 = Console.ReadLine();

            for (int i = 0; i < b; i++)
            {
                if (str[i] == str1) { str[i] = null; }
            }
            Console.WriteLine("New Array : ");
            for (int i = 0; i < b; i++)
            {
                Console.Write("{0}.{1} :", i, str[i]);
            }
            Console.ReadLine();
        }

        static void Action11()      //Пользователь вводит числа с клавиатуры до тех пор пока не ввел не число и заполняет массив, 
                                    //размер массива не известен, изначально пусть будет на 1 элемент, когда массив будет полностью
                                    //заполнен надо его расширить на 1 элемент и снова дать пользователю возможность вводить числа, 
                                    //когда пользователь введет не число, вывести на экран этот массив
        {
            //    int g = 1;
            //    int[] a = new int[g];
            //    for (int i = 0; i < g; i++)
            //    {
            //        int ai1 = 0;
            //        Console.WriteLine("index {0}: ",i);

            //        string ai = Console.ReadLine();
            //      Int32.TryParse(ai,out ai1);
            //        if (ai1 == 0) {
            //            Console.Write("Massive: ");
            //            for (int j = 0; j < a.Length; j++)
            //            {
            //                Console.Write("{0: 0}", a[j]);
            //            }

            //        }
            //        //int ai1 = int.Parse(ai); 
            //        a[i] = ai1;

            //        g = g+1;
            //    }

            int g = 1;
            int[] a = new int[g];
            for (int i = 0; ; i++)
            {



                Console.Write("index {0}: ", i);
                int ai2 = 0;
                string ai = Console.ReadLine();

                Int32.TryParse(ai, out int ai1);
                if (ai1 == 0)
                {
                    Console.Write("Massive: ");
                    for (int j = 0; j < a1.Length; j++)
                    {
                        Console.Write("{0: 0}", a1[j]);
                    }
                    break;
                }
                else
                {

                    g = g + 1;
                    ai2 = int.Parse(ai);
                    a[i] = ai2;
                    Array.Copy(a, a1, a.Length);


                }

            }
            Console.ReadLine();
        }




    }

}


