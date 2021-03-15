using MySql.Data.MySqlClient;
using System;

namespace SamplesCSharp.MySql
{
    class Program
    {
        static void Main(string[] args)
        {
            //windows authentication
            //using var connection = new MySqlConnection("Server=myServerAddress;Database=myDataBase;IntegratedSecurity=yes;Uid=auth_windows;");
            //user and password
            //using var connection = new MySqlConnection("Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;");

            using var connection = new MySqlConnection("connection_string");

            try
            {
                connection.Open();

                using var command = new MySqlCommand("select * from [Table]", connection);

                var reader = command.ExecuteReader();

                Console.WriteLine("Registros da tabela - [Table]:");

                while (reader.Read())
                {
                    Console.WriteLine($"Id: {reader[0]} - Descricao: {reader[1]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO - {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
