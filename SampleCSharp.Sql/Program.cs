using System;
using System.Data.SqlClient;

namespace SampleCSharp.Sql
{
    class Program
    {
        static void Main(string[] args)
        {
            //windows authentication
            //using var connection = new SqlConnection("Server=(myServerAddress;Database=myDataBase;Trusted_Connection=True;");
            //user and password
            //using var connection = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");

            using var connection = new SqlConnection("connection_string");

            try
            {
                connection.Open();

                using var command = new SqlCommand("select * from [Table]", connection);

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
