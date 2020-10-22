using RulesEngine.Core;

namespace RulesEngine.DA
{
    public interface IDataAccess
    {
        string GetActiveRules();

        string GetFiltersForRule(int ruleId);
    }
}