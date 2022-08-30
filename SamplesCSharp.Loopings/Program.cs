using System;
using System.Collections.Generic;
using System.Linq;

namespace SamplesCSharp.Loopings
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileLoop();

            DoWhileLoop();

            ForLoop();

            ForEachLoop();

            ForEachLinqLoop();

            ExampleLoop();

            PiramidUpLoop();

            PiramidDownLoop();
        }

        static void WhileLoop()
        {
            Console.WriteLine("************WhileLoop************");

            var index = 0;
            var list = new List<string> { "Camila", "Maria", "Henrique", "Karolina", "Kaisque" };

            while (index < list.Count)
            {
                var element = list.ElementAt(index);
                Console.WriteLine(element);
                index++;
            }

            Console.WriteLine();
        }

        static void DoWhileLoop()
        {
            Console.WriteLine("************DoWhileLoop************");

            var index = 0;
            var list = new List<string> { "Camila", "Maria", "Henrique", "Karolina", "Kaisque" };

            do
            {
                var element = list.ElementAt(index);
                //ou
                //var element = list[index];

                Console.WriteLine(element);
                index++;
            }
            while (index < list.Count);

            Console.WriteLine();
        }

        static void ForLoop()
        {
            Console.WriteLine("************ForLoop************");

            var list = new List<string> { "Camila", "Maria", "Henrique", "Karolina", "Kaisque" };

            for (var index = 0; index < list.Count; index++)
            {
                var element = list.ElementAt(index);
                //ou
                //var element = list[index];

                Console.WriteLine(element);
            }
            Console.WriteLine();
        }

        static void ForEachLoop()
        {
            Console.WriteLine("************ForEachLoop************");

            var list = new List<string> { "Camila", "Maria", "Henrique", "Karolina", "Kaisque" };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        static void ForEachLinqLoop()
        {
            Console.WriteLine("************ForEachLinqLoop************");

            var list = new List<string> { "Camila", "Maria", "Henrique", "Karolina", "Kaisque" };
            list.ForEach(o => Console.WriteLine(o));

            Console.WriteLine();
        }

        static void ExampleLoop()
        {
            Console.WriteLine("************ExampleLoop************");

            var list = new List<string> { "Camila", "Maria", "Henrique", "Karolina", "Kaisque" };
            var index = 0;
            var rand = new Random();

            Console.WriteLine("============");

            // print items da lista;
            list.ForEach(o =>
            {
                Console.WriteLine(o);
            });

            Console.WriteLine("============");

            // outra maneira de pegar item random;
            while (index <= 10)
            {
                var element = list.ElementAt(rand.Next(1, list.Count));
                Console.WriteLine(element);
                index++;
            }
        }

        static void PiramidUpLoop()
        {
            Console.WriteLine("************PiramidUpLoop************");

            for (var rows = 0; rows < 15; rows++)
            {
                for (var itens = 0; itens < rows; itens++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void PiramidDownLoop()
        {
            Console.WriteLine("************PiramidDownLoop************");

            for (var rows = 15; rows > 0; rows--)
            {
                for (var itens = 0; itens < rows; itens++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}