using RulesEngine.Core;
using RulesEngine.DA.Models;

namespace RulesEngine.BL
{
    public interface IBusinessLogic
    {
        void ProcessRulesEngineQueue();

        void ProcessRuleType(IRulesEngineRuleProcessor _processor, RERule rule);
    }
}