using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class UserRepositories : IUserRepositories
    {
        public List<User> GetAllUsers()
        {
            UserDAO userDAO = new UserDAO();
            userDAO.InitializeDataset();
            return userDAO.GetAllUsers();

        }
    }
}
