using RulesEngine.BL;

namespace RulesEngine.UI.Console
{
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public void Run()
        {
            _businessLogic.ProcessRulesEngineQueue();
        }
    }
}
