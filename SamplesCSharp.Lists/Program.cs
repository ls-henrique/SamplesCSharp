using System;
using System.Collections.Generic;
using System.Linq;

namespace SamplesCSharp.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maneiras de declarar e popular uma lista

            var list1 = new List<string>();
            list1.Add("Camila");
            list1.Add("Maria");
            list1.Add("Henrique");
            list1.Add("Karolina");
            list1.Add("Kaisque");

            Console.WriteLine($"Itens declarados na lista 1: {list1.Count}");
            Console.WriteLine("=========");


            var list2 = new List<string> { "Camila", "Juan", "Luiz", "Douglas", "Kaisque" };

            Console.WriteLine($"Itens declarados na lista 2: {list2.Count}");
            Console.WriteLine("=========");


            var list3 = new List<string>();
            list3.AddRange(list2);

            Console.WriteLine($"Itens declarados na lista 3: {list3.Count}");
            Console.WriteLine("=========");


            //Differença entre listas
            var diff = list3.Except(list1);

            Console.WriteLine($"Diferença da lista 1 e 2: {diff.Count()}");
            Console.WriteLine($"{string.Join(", ", diff)}");
            Console.WriteLine("=========");
        }
    }
}
