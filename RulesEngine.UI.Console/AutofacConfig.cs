using Autofac;
using RulesEngine.BL;
using RulesEngine.Common;
using RulesEngine.Core;
using RulesEngine.DA;

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

            // Configure Data Providers
            builder.RegisterType<MockDataProvider>().As<IDataProvider>();
            //builder.RegisterType<CSVDataProvider>().As<IDataProvider>();

            // todo: get by ends with Processor using reflection


            builder.RegisterType<RulesEngineRuleProcessor>().As<IRulesEngineRuleProcessor>();
            builder.RegisterType<HermesConcatRuleProcessor>().As<IHermesConcatRuleProcessor>();

            builder.RegisterType<Logger>().As<ILogger>();

            return builder.Build(); // return the built container
        }

    }
}
