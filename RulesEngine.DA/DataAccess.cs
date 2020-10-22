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
        IHermesConcatRuleProcessor _processor;

        public void GetDataFromDB(IHermesConcatRuleProcessor processor)
        {
            Console.WriteLine("Simulating DB connxn");
            Console.WriteLine("Getting active rules from Queue");
            Console.WriteLine("Fetched one rule. Rule Type: Hermes Concat");

            _processor = processor;
            ProcessRule(_processor);
           
        }

        private void ProcessRule(IHermesConcatRuleProcessor processor)
        {
            // TODO: Remove hardcoded rule Id: 1
            processor.GetRuleFilters(1);
        }
    }
}
