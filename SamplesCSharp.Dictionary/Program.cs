using System;
using System.Collections.Generic;

namespace SamplesCSharp.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maneiras de declarar e popular um array

            var dictionary1 = new Dictionary<int, string>();

            dictionary1.Add(0, "Camila");
            dictionary1.Add(1, "Maria");
            dictionary1.Add(2, "Henrique");
            dictionary1.Add(3, "Karolina");
            dictionary1.Add(4, "Kaisque");

            Console.WriteLine($"Itens declarados no dicionario 1: {dictionary1.Count}");
            Console.WriteLine("=========");

            var dictionary2 = new Dictionary<int, string>() { { 0, "Camila" }, { 1, "Maria" }, { 2, "Henrique" }, { 3, "Karolina" }, { 4, "Kaisque" } };

            Console.WriteLine($"Itens declarados no dicionario 2: {dictionary2.Count}");
            Console.WriteLine("=========");

            Console.WriteLine($"Keys do dicionario: {string.Join(", ", dictionary2.Keys)}");
            Console.WriteLine($"Values do dicionario: {string.Join(", ", dictionary2.Values)}");
            Console.WriteLine("=========");
        }
    }
}
