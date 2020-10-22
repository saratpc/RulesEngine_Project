using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Core
{
    public class HermesConcatRuleProcessor : IHermesConcatRuleProcessor
    {
        public void GetRuleFilters(int ruleId)
        {
            Console.WriteLine($"Getting Rule Filters for {ruleId}");

            Console.WriteLine($"Processing rule filters and forming a dynamic query.");
        }
    }
}
