using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Core
{
    public class HermesConcatRuleProcessor : IHermesConcatRuleProcessor
    {
        public void ProcessHermesConcatRule(int ruleId)
        {
            Console.WriteLine($"Processing rule filters and forming a dynamic query.");

            Console.WriteLine($"Performing the configured actions: Calling Hermes WS, Calling Prism WS");
        }

        public void ProcessRule(string ruleType)
        {
            // Do something
            // Get Rule Parameters and other stuff.
        }
    }
}
