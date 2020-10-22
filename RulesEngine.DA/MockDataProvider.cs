using RulesEngine.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RulesEngine.DA
{
    public class MockDataProvider : IDataAccess
    {
        public IEnumerable<RERule> GetActiveRules()
        {
            List<RERule> rules = new List<RERule>()
            { new RERule() { RuleId = 1, RuleDesc = "Long desc concat", RuleType = "HermesSEOConcatenation", InputLevel = 5, OutputLevel = 7, Cascade = false } };

            return rules;
        }

        public string GetFiltersForRule(int ruleId)
        {
            throw new NotImplementedException();
        }
    }
}
