using System;

namespace SamplesCSharp.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maneiras de declarar e popular um array

            var array1 = new string[5];

            array1[0] = "Camila";
            array1[1] = "Maria";
            array1[2] = "Henrique";
            array1[3] = "Karolina";
            array1[4] = "Kaisque";

            Console.WriteLine($"Itens declarados no array 1: {array1.Length}");
            Console.WriteLine("=========");

            string[] array2 = { "Camila", "Juan", "Luiz", "Douglas", "Kaisque" };

            Console.WriteLine($"Itens declarados no array 2: {array2.Length}");
            Console.WriteLine("=========");
        }
    }
}
