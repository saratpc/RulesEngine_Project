using System;
using RulesEngine.DA.Models;

namespace RulesEngine.Core
{
    public class HermesConcatRuleProcessor : IHermesConcatRuleProcessor
    {
        public void ProcessHermesConcatRule(int ruleId)
        {
            Console.WriteLine($"Processing rule filters and forming a dynamic query.");

            Console.WriteLine($"Performing the configured actions: Calling Hermes WS, Calling Prism WS");
        }

        public void ProcessRule(RERule ruleType)
        {
            // Do something
            // Get Rule Parameters and other stuff.
        }
    }
}
