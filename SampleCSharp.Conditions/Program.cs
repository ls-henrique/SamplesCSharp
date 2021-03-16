using System;

namespace SampleCSharp.Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua cor preferida:");
            var color = Console.ReadLine();

            Console.WriteLine();

            IfElseCondition(age);

            ElseIfCondition(age);

            TernaryOperator(age);

            SwitchCondition(color);

            SwitchExpression(color);
        }

        static void IfElseCondition(int age)
        {
            Console.WriteLine("************IfElseCondition************");

            if (age >= 18)
            {
                Console.WriteLine("Pessoa maior que 18 anos");
            }
            else
            {
                Console.WriteLine("Pessoa menor que 18 anos");

            }

            Console.WriteLine();
        }

        static void ElseIfCondition(int age)
        {
            Console.WriteLine("************ElseIfCondition************");

            if (age >= 18)
            {
                Console.WriteLine("Pessoa maior que 18 anos");
            }
            else if (age < 18)
            {
                Console.WriteLine("Pessoa menor que 18 anos");
            }
            else
            {
                Console.WriteLine("Chamem a CIA é um ALIEN!");
            }

            Console.WriteLine();
        }

        static void TernaryOperator(int age)
        {
            Console.WriteLine("************SwitchCondition************");

            Console.WriteLine(age > 18 ? "Pessoa maior que 18 anos" : "Pessoa menor que 18 anos");

            Console.WriteLine();
        }

        static void SwitchCondition(string color)
        {
            Console.WriteLine("************SwitchCondition************");

            switch (color)
            {
                case "amarelo":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Sua cor preferida é amarelo");
                    break;
                case "vermelho":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sua cor preferida é vermelho");
                    break;
                case "azul":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sua cor preferida é azul");
                    break;
                case "verde":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sua cor preferida é verde");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("QUE GOSTO ESTRAAAAANHO!!");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        static void SwitchExpression(string color)
        {
            Console.WriteLine("************SwitchCondition************");

            var message = color switch
            {
                "amarelo" => "Sua cor preferida é amarelo",
                "vermelho" => "Sua cor preferida é vermelho",
                "azul" => "Sua cor preferida é azul",
                "verde" => "Sua cor preferida é verde",
                _ => "QUE GOSTO ESTRAAAAANHO!!"
            };

            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
