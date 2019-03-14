using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tiajsmith.Models;

namespace tiajsmith.DAL
{
    interface IUserDAL
    {
        /// <summary>
        /// Retrieves a user from the system.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        User GetUser(string username);

        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="user"></param>
        void CreateUser(string username, string password);

        /// <summary>
        /// Updates a user.
        /// </summary>
        /// <param name="user"></param>
        void UpdateUser(User user);

        /// <summary>
        /// Deletes a user from the system.
        /// </summary>
        /// <param name="user"></param>
        void DeleteUser(User user);
    }
}
