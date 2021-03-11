using System;
using System.Linq;

namespace SamplesCSharp.Convertions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Camila", "Juan", "Luiz", "Douglas", "Kaisque" };

            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine(array.GetType().Name);
            Console.WriteLine();

            var list = array.ToList();
            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(list.GetType().Name);
            Console.WriteLine();

            var dictionary = list.ToDictionary(o => o, o => o);
            Console.WriteLine(string.Join(", ", dictionary.Values));
            Console.WriteLine(dictionary.GetType().Name);
            Console.WriteLine();

            var array1 = dictionary.Values.ToArray();
            Console.WriteLine(string.Join(", ", array1));
            Console.WriteLine(array1.GetType().Name);
            Console.WriteLine();
        }
    }
}
