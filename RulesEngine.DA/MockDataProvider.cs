using RulesEngine.DA.Models;
using System.Collections.Generic;


namespace RulesEngine.DA
{
    public class MockDataProvider : IDataAccess, IDataProvider
    {
        public IEnumerable<RERule> GetActiveRules()
        {
            List<RERule> rules = new List<RERule>()
            { new RERule() { RuleId = 1, RuleDesc = "Long desc concat", RuleType = "HermesSEOConcatenation", InputLevel = 5, OutputLevel = 7, Cascade = false } };

            return rules;
        }

        public string GetFiltersForRule(int ruleId)
        {
            // TODO
            return "";
        }
    }
}
