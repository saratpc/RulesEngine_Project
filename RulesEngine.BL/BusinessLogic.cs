using RulesEngine.Common;
using RulesEngine.Core;
using RulesEngine.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.BL
{
    public class BusinessLogic : IBusinessLogic
    {
        IDataAccess _dataAccess;
        ILogger _logger;

        IHermesConcatRuleProcessor _processor;

        public BusinessLogic(IDataAccess dataAccess, ILogger logger, IHermesConcatRuleProcessor processor)
        {
            _dataAccess = dataAccess;
            _logger = logger;
            _processor = processor;
        }

        public void ProcessRulesEngineQueue()
        {
            Console.WriteLine("Processing queue");

            // dependency 1
            //DataAccess dataAccess = new DataAccess();
            //dataAccess.GetActiveRules();

            // dependency 2
            //Logger logger = new Logger();
            //logger.LogMessage("Processed Queue");

            _dataAccess.GetActiveRules();
            _logger.LogMessage("Processed Queue");

            // foreach active rule:

            GetRuleFilters();

            ProcessRuleType(_processor);
        }

        private void GetRuleFilters()
        {
            _dataAccess.GetFiltersForRule(1);
            _logger.LogMessage("Getting the filters for Rule 1");
        }

        public void ProcessRuleType(IHermesConcatRuleProcessor _processor)
        {
            // Do the actions for the rule type
            // switch case for Rule Type

            // ProcessRuleType based on the active rule
            // call da to get the rule's filters

            // TODO: Remove hardcoded rule Id: 1
            _processor.ProcessHermesConcatRule(1);
            

        }

    }
}
