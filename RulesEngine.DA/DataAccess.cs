using RulesEngine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.DA
{
    public class DataAccess : IDataAccess
    {

        public string GetActiveRules()
        {
            // Write an SP to fetch this data
            Console.WriteLine("Simulating DB connxn");
            Console.WriteLine("Getting active rules from Queue");
            Console.WriteLine("Fetched one rule. Rule Type: Hermes Concat");

            return "Hermes SEO Concat";
        }

        public string GetFiltersForRule(int ruleId)
        {
            Console.WriteLine($"Getting filters for Rule {ruleId}");
            return "FilterForRule1";
        }
    }
}
