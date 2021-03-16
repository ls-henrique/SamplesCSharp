using SampleCSharp.Interface.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SampleCSharp.Interface.Data.Services
{
    public class DataServices : IDataServices
    {
        public string GetAll()
        {
            var users = new List<object> {
                new { Id = 1, Name = "Ana Carolina", Age = 19 },
                new { Id = 2, Name = "Daniel Vieira", Age = 18 },
                new { Id = 3, Name = "Ricardo Dantas", Age = 20 }
            };

            return string.Join(", ", users.Select(o => o));
        }

        public string GetUserInfo(int id)
        {
            return $"Id: {id} - Nome: 'Ronaldinho (O Bruxo)' - Idade: '88'";
        }

        public string AddUser(string name, int age)
        {
            return $"Inserido!";
        }

        public string UpdateUser(int id, string name, int age)
        {
            return $"Id: {id} - Atualizado!";
        }

        public string DeleteUser(int id)
        {
            return $"Id: {id} - Deletado!";
        }
    }
}
