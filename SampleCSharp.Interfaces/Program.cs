using SampleCSharp.Interface.Data.Interfaces;
using SampleCSharp.Interface.Data.Services;
using System;

namespace SampleCSharp.Interfaces
{
    class Program
    {
        public Program()
        {

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("==============");
                Console.WriteLine(@"0 - Listar; 1 - Obter; 2 - Adicionar; 3 - Atualizar; 4 - Deletar;");
                Console.WriteLine("==============");

                int.TryParse(Console.ReadLine(), out var option);
                Console.WriteLine();

                IDataServices data = new DataServices();

                switch (option)
                {
                    case 0:
                        Console.WriteLine(data.GetAll());
                        break;

                    case 1:
                        Console.WriteLine("Insira um Id:");
                        int.TryParse(Console.ReadLine(), out var id);

                        Console.WriteLine();
                        Console.WriteLine(data.GetUserInfo(id));
                        break;

                    case 2:
                        Console.WriteLine("Insira um Nome:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Insira uma Idade:");
                        int.TryParse(Console.ReadLine(), out var age);

                        Console.WriteLine();
                        Console.WriteLine(data.AddUser(name, age));
                        break;

                    case 3:
                        Console.WriteLine("Insira um Id:");
                        int.TryParse(Console.ReadLine(), out var idUpdated);
                        Console.WriteLine("Insira um Nome:");
                        var nameUpdated = Console.ReadLine();
                        Console.WriteLine("Insira uma Idade:");
                        int.TryParse(Console.ReadLine(), out var ageUpdated);

                        Console.WriteLine();
                        Console.WriteLine(data.UpdateUser(idUpdated, nameUpdated, ageUpdated));
                        break;

                    case 4:
                        Console.WriteLine("Insira um Id:");
                        int.TryParse(Console.ReadLine(), out var idDeleted);

                        Console.WriteLine();
                        Console.WriteLine(data.DeleteUser(idDeleted));
                        break;

                    default:
                        Console.WriteLine("Opcao nao identificada.");
                        Console.WriteLine("Aperta uma tecla para sair!");
                        Console.ReadKey();
                        return;
                }

                Console.WriteLine();
            }
        }
    }
}
