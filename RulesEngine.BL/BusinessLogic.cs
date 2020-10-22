using RulesEngine.Common;
using RulesEngine.Core;
using RulesEngine.DA;
using RulesEngine.DA.Models;
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

        IRulesEngineRuleProcessor _processor;

        public BusinessLogic(IDataAccess dataAccess, ILogger logger, IRulesEngineRuleProcessor processor)
        {
            _dataAccess = dataAccess;
            _logger = logger;
            _processor = processor;
        }

        public void ProcessRulesEngineQueue()
        {
            _logger.LogMessage("Processing Queue");

            // dependency 1
            //DataAccess dataAccess = new DataAccess();
            //dataAccess.GetActiveRules();

            // dependency 2
            //Logger logger = new Logger();
            //logger.LogMessage("Processed Queue");

            IEnumerable<RERule> activeRules = _dataAccess.GetActiveRules();

            foreach (RERule rule in activeRules)
            {
                GetRuleFilters(rule.RuleId);
            }

            ProcessRuleType(_processor);
        }

        private void GetRuleFilters(int ruleId)
        {
            _dataAccess.GetFiltersForRule(ruleId);
            _logger.LogMessage("Getting the filters for Rule 1");
        }

        public void ProcessRuleType(IRulesEngineRuleProcessor _processor)
        {
            // Do the actions for the rule type
            // switch case for Rule Type

            // ProcessRuleType based on the active rule
            // call da to get the rule's filters

            // TODO: Remove hardcoded rule Id: 1
            //_processor.ProcessHermesConcatRule(1);
            _processor.ProcessRule("HermesSEOConcatenation");
            

        }

    }
}
