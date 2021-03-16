using System.Collections.Generic;

namespace SampleCSharp.Interface.Data.Interfaces
{
    public interface IDataServices
    {
        string GetAll();

        string GetUserInfo(int id);

        string AddUser(string name, int age);

        string UpdateUser(int id, string name, int age);

        string DeleteUser(int id);
    }
}
