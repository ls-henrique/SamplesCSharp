using System;

namespace SamplesCSharpTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o nome do seu time de futebol:");
            var value = Console.ReadLine();

            //Declaração e uso de tuplas - forma 1
            var tuple1 = new Tuple<string, int, int, string, DateTime>("São Paulo", 10, 0, value, DateTime.Now);

            Console.WriteLine($"Jogo do dia {tuple1.Item5} - '{tuple1.Item1}': {tuple1.Item2} X {tuple1.Item3} :'{tuple1.Item4}'");


            //Declaração e uso de tuplas - forma 2
            var (teamA, scoreA, scoreB, teamB, dateAB) = new Tuple<string, int, int, string, DateTime>("São Paulo", 10, 0, value, DateTime.Now);

            Console.WriteLine($"Jogo do dia {dateAB} - '{teamA}': {scoreA} X {scoreB} :'{teamB}'");


            //Declaração e uso de tuplas - forma 3
            var (team1, score1, score2, team2, date12) = ("São Paulo", 10, 0, value, DateTime.Now);

            Console.WriteLine($"Jogo do dia {date12} - '{team1}': {score1} X {score2} :'{team2}'");


            Console.WriteLine($"São Paulo FC sempre será o melhor!");
            Console.WriteLine();
        }
    }
}
