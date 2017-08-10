using Ninject;
using Ninject.Modules;
using NInject.Factory;
using NInject.Models;
using NInject.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NInjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Accessing DI");

            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var users = kernel.GetAll<IUsers>();

            foreach (var user in users)
            {
                var nInjectFectory = new NInjectFectory(user);
                nInjectFectory.GetUsers();
            }

            Console.ReadLine();
        }
    }

    public class DI : NinjectModule
    {
        public override void Load()
        {
            Bind<IUsers>().To<SystemUsers>();
            Bind<IUsers>().To<AppUsers>();
            Bind<IUsers>().To<AccountUsers>();
        }
    }
}
