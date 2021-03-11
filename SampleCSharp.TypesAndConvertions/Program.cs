using System;

namespace SampleCSharp.ConcatenateAndConvertions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            var name = Console.ReadLine();

            Console.WriteLine("Digite o ano que nasceu: ");
            var year = Console.ReadLine();

            Console.WriteLine("Digite qual o valor do PIX que deseja receber: ");
            var amount = Console.ReadLine();

            Console.WriteLine();
            ConcatenateAndConvert(name, year, amount);
        }

        static void ConcatenateAndConvert(object value1, object value2, object value3)
        {
            var name = string.Empty;
            var age = 0;
            var amount = 0.0M;

            //verifica qual o tipo de dado
            if (value1 is string)
            {
                //Converte se necessário
                //name = value1 as string; /*Conversão Implícita*/
                name = value1.ToString(); /*Conversão Explícita*/
            }

            if (value2 is string)
            {
                //age = Convert.ToInt32(value2);  /*Conversão Explícita - gera exception quando o tipo de dado não é válido*/
                int.TryParse(value2.ToString(), out age);  /*Conversão Explícita - gera exception quando recebe valor null*/

                age = age > 0 ? DateTime.Now.Year - age : 0;
            }

            if (value3 is string)
            {
                //amount = Convert.ToDecimal(amount);  /*Conversão Explícita - gera exception quando o tipo de dado não é válido*/
                decimal.TryParse(value3.ToString(), out amount); /*Conversão Explícita - gera exception quando recebe valor null*/
            }

            //concatenação de string simples
            Console.WriteLine("Seu nome é " + name + ". Tem " + age + " anos, e não vai receber um pix de: R$" + amount + " reais.");

            //concatenação com string format
            Console.WriteLine(string.Format("Seu nome é {0}. Tem {1} anos, e não vai receber um pix de: R${2} reais.", name, age, amount));

            //concatenação com interpolação
            Console.WriteLine($"Seu nome é {name}. Tem {age} anos, e não vai receber um pix de: R${amount} reais.");

            Console.WriteLine();
        }
    }
}
