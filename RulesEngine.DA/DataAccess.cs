using RulesEngine.Core;
using RulesEngine.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.DA
{
    public class DataAccess : IDataAccess
    {
        IDataProvider _dataProvider;

        public DataAccess(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public IEnumerable<RERule> GetActiveRules()
        {
            // Write an SP to fetch this data
            Console.WriteLine("***********************************");
            Console.WriteLine($"Getting active rules from Queue using {_dataProvider.GetType()}");

            var activeRules = _dataProvider.GetActiveRules();
            Console.WriteLine($"No. of active rules = {activeRules.Count()}");
            Console.WriteLine("***********************************");

            return activeRules;
        }

        public string GetFiltersForRule(int ruleId)
        {
            Console.WriteLine($"Getting filters for Rule {ruleId}");
            return "FilterForRule1";
        }

        
    }
}
