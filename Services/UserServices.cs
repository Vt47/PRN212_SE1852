using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepositories iUserRepositories;
        public UserServices()
        {
            iUserRepositories = new UserRepositories();
        }
        public List<User> GetAllUsers()
        {
            return iUserRepositories.GetAllUsers(); 
        }
    }
}
