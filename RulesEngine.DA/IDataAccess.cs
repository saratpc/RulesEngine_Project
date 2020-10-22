using RulesEngine.Core;
using RulesEngine.DA.Models;
using System.Collections.Generic;

namespace RulesEngine.DA
{
    public interface IDataAccess
    {
        IEnumerable<RERule> GetActiveRules();

        string GetFiltersForRule(int ruleId);
    }
}