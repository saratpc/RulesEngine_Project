using System;
using RulesEngine.DA.Models;

namespace RulesEngine.Core
{
    public class HermesConcatRuleProcessor : IHermesConcatRuleProcessor
    {
        public void ProcessHermesConcatRule(int ruleId)
        {
            // This method is redundant. The specific interface can also be deleted.
            Console.WriteLine($"Processing rule filters and forming a dynamic query.");

            Console.WriteLine($"Performing the configured actions: Calling Hermes WS, Calling Prism WS");
        }

        public void ProcessRule(RERule ruleType)
        {
            // TODO
            // Get Rule Parameters, Rule Filters
            // Do necessary actions
        }
    }
}
