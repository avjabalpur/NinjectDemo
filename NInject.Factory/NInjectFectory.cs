using NInject.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInject.Factory
{
    /// <summary>
    /// This is the main class for DI
    /// </summary>
    public class NInjectFectory
    {
        private readonly IUsers users;

        public NInjectFectory(IUsers userIOC)
        {
            users = userIOC;
        }

        public void GetUsers() {
            users.GetUsers();
        }
    }
}
