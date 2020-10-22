using RulesEngine.Core;

namespace RulesEngine.BL
{
    public interface IBusinessLogic
    {
        void ProcessRulesEngineQueue();

        // TESTING
        void ProcessRuleType(IRulesEngineRuleProcessor _processor);
    }
}