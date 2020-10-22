using RulesEngine.DA.Models;
using System.Collections.Generic;

namespace RulesEngine.DA
{
    public interface IDataProvider
    {
        IEnumerable<RERule> GetActiveRules();
        string GetFiltersForRule(int ruleId);
    }
}