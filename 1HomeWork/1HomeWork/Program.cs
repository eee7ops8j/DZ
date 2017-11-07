using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        private static int min, max, z, w;
        private static char h;
        private static int[] a;

        static char WWW()
        {
            Console.Write(" : ");
            h = char.Parse(Console.ReadLine());
            if ((h != 'y') && (h != 'n'))
            {

                Console.Write("only y or n ");
                WWW();
            }

            return h;
        }
        static int QQQ()
        {
            Console.Write(": ");
            w = int.Parse(Console.ReadLine());
            if ((w != 1) && (w != 2))
            {
                Console.Write("only 1 or 2 ");
                QQQ();

            }
            return w;
        }
        static int[] Sort()
        {
            Array.Sort(a);
            Console.WriteLine();
            Console.Write("Sort   :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0: 0}", a[i]);

            }
            return a;
        }
        static int[] Sarr()
        {
            Console.Write("Size of Array: ");
            z = int.Parse(Console.ReadLine());
            a = new int[z];


            Console.WriteLine("press 1 for random: ");
            Console.WriteLine("press 2 for readline: ");
            QQQ();

            if (w == 1)
            {
                Random rnd = new Random();
                Console.Write("Massive:");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = rnd.Next(1, 100);
                    Console.Write("{0: 0}", a[i]);
                }
            }
            if (w == 2)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(i + 1);
                    Console.Write(" num - ");
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Massive: ");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("{0: 0}", a[i]);
                }
            }

            return a;

        }

        static int MethodMin(int[] a)
        {
            min = a.Min();
            return min;
        }
        static int MethodMax(int[] a)
        {
            max = a.Max();
            return max;
        }
        static int[] Search()
        {
            Array.Sort(a);
            Console.WriteLine();
            Console.Write("Search in: ");
            int x = int.Parse(Console.ReadLine());
            int search = Array.BinarySearch(a, x);

            if (search == 0)
            { Console.Write(x + " : there is"); }
            if (search != 0)
            { Console.Write(x + " : not found"); }

            return a;
        }

        static void View()
        {
            Console.WriteLine();
            Console.WriteLine("Max:{0}", max);
            Console.WriteLine("Min:{0}", min);
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            Console.Write("Start programs: y / n");
            WWW();

            if (h == 'y')
            {
                Sarr();
                MethodMin(a);
                MethodMax(a);
                Sort();
                Search();
                View();
            }
            if (h == 'n')
            {


            }

        }

    }
}


