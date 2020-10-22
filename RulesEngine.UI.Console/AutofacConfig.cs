﻿using Autofac;
using RulesEngine.BL;
using RulesEngine.Common;
using RulesEngine.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.UI.Console
{
    public static class AutofacConfig
    {
        public static IContainer Configure()
        {
            // Create an instance of Container Builder
            ContainerBuilder builder = new ContainerBuilder();
            // Register the types

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();

            builder.RegisterType<DataAccess>().As<IDataAccess>();
            builder.RegisterType<Logger>().As<ILogger>();

            return builder.Build(); // return the built container
        }

    }
}