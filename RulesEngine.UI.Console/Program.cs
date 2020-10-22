using Autofac;
using RulesEngine.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // dependency
            //BusinessLogic businessLogic = new BusinessLogic();
            //businessLogic.ProcessData();

            var container = AutofacConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            System.Console.WriteLine();
            System.Console.WriteLine("End of program. Hit 'return' key to exit.");
            System.Console.ReadLine();
        }
    }
}
