using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//21. Сгенерировать такой массив в котором бы присутствовали все цифры от 0 до 10, но в произвольном порядке.
//22. Структурой описать игральную карту
//23. Сгенерировать упорядоченную колоду карт
//24. Перемешать колоду карт
//25. Найти позиции всех тузов в колоде
//26. Переместить все пиковые карты в начало колоды


namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("21. Сгенерировать такой массив в котором бы присутствовали все цифры от 0 до 10, но в произвольном порядке\n" +
                "22. Структурой описать игральную карту\n" +
                "23. Сгенерировать упорядоченную колоду карт\n" +
                "24. Перемешать колоду карт\n" +
                "25. Найти позиции всех тузов в колоде\n" +
                "26. Переместить все пиковые карты в начало колоды");
            Console.Write("Enter action : ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 21: Action21(); break;
                case 22: Action22(); break;
                case 23: Action23(); break;
                case 24: Action24(); break;
                case 25: Action25(); break;
                case 26: Action26(); break;
                default: break;
            }
        }
        static void Action21() //Сгенерировать такой массив в котором бы присутствовали все цифры от 0 до 10, но в произвольном порядке\n" +
        {
            Console.Write("Array size: ");
            int sizem = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.Write("Massive     :");
            int[] massiv = new int[sizem];
            for (int i = 0; i < sizem; i++)
            {
                bool checkbool;
                int checkint;
                do
                {
                    checkint = rnd.Next(sizem);
                    checkbool = false;
                    for (int index = 0; index < i; index++)
                    {
                        int n = massiv[index];
                        if (n == checkint)
                        {
                            checkbool = true;
                            break;
                        }
                    }
                }
                while (checkbool);
                massiv[i] = checkint;
                Console.Write("{0: 0}", massiv[i]);
            }
            Console.ReadLine();
        }
        struct Card22
        {
            public int Score;
            public string Name;
            public string Сardsuit;
        }

        static void Action22() //Структурой описать игральную карту\n" +
        {
            Card22 card;
            card.Сardsuit = "Hearts";
            card.Name = "King";
            card.Score = 4;

            Console.WriteLine("Cardsuit : " + card.Сardsuit);
            Console.WriteLine("Name : " + card.Name);
            Console.WriteLine("Score : " + card.Score);
            Console.ReadLine();
        }


        public enum SuitName
        {
            Clubs,
            Spases,
            Hearts,
            Diamonds
        }
        public enum CardName23
        { Six = 6, Seven, Eight, Nine, Ten, Ace, Jack = 2, Queen, King };


        static void Action23() //Сгенерировать упорядоченную колоду карт\n" +
        {
            //SuitName sname = SuitName.;
            //int suite = (int)sname;

            //Console.WriteLine(suite);



            int[,] cards = new int[4, 9];
            for (int i = 0; i < cards.GetLength(0); i++)
            {

                for (int j = 0; j < cards.GetLength(1); j++)
                {

                    cards[i, j] = j + 1;

                }
            }
            //for (int i = 0; i < cards.GetLength(0); i++)
            //{
            //    //Console.WriteLine("\n:");
            //for (int j = 0; j < cards.GetLength(1); j++)
            //{
            //    //int x = (int)SuitName.[i];
            //    //Enum.GetName(SuitName.{ 0}, ees);
            //    //Enum.GetName(CardName23.Ace, eee);

            //    //Console.Write("{0} - {1} - {2} - {3} - {4}",
            //    //    Enum.Parse(typeof(SuitName), name),name), 
            //    //    Enum.Parse(typeof(CardName23), name), name);
            foreach (var namecar in Enum.GetNames(typeof(SuitName)))
            {
                Console.Write("{1} \n", Enum.Parse(typeof(SuitName), namecar), namecar);
                foreach (var name in Enum.GetNames(typeof(CardName23)))
                {
                    Console.WriteLine(" : {1} score {0,3:D}", Enum.Parse(typeof(CardName23), name), name);
                }
                Console.WriteLine();
            }
            //}

            //{0,3:D}
            //}
            Console.ReadLine();
        }

        static void Action24() //Перемешать колоду карт\n" +
        {

        }


        static void Action25() //Найти позиции всех тузов в колоде\n" +
        {

        }
        static void Action26() //Переместить все пиковые карты в начало колоды");
        {

        }
    }

}


