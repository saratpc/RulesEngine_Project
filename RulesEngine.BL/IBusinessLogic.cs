using RulesEngine.Core;

namespace RulesEngine.BL
{
    public interface IBusinessLogic
    {
        void ProcessRulesEngineQueue();

        // TESTING
        void ProcessRuleType(IHermesConcatRuleProcessor _processor);
    }
}