using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class UserDAO
    {
        static List<User> users = new List<User>();
        public void InitializeDataset() 
        {
            users.Add(new User() { Name = "Teo", Phone = "1234657", Email = "teo@gmail.com" });
            users.Add(new User() { Name = "Ti", Phone = "553245356", Email = "ti@gmail.com" });
            users.Add(new User() { Name = "Bin", Phone = "246626", Email = "bin@gmail.com" });
            users.Add(new User() { Name = "Bo", Phone = "475457457", Email = "bo@gmail.com" });
            users.Add(new User() { Name = "Beo", Phone = "234234234", Email = "beo@gmail.com" });
            users.Add(new User() { Name = "Ban", Phone = "86786868", Email = "ban@gmail.com" });
        }
        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
