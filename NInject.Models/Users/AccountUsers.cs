using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInject.Models.Users
{
    public class AccountUsers : IUsers
    {
        public void GetUsers()
        {
            Console.WriteLine("Reading account users");
        }
    }
}
