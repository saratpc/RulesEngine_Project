using RulesEngine.DA.Models;

namespace RulesEngine.Core
{
    public interface IRulesEngineRuleProcessor
    {
        void ProcessRule(RERule ruleType);
    }
}