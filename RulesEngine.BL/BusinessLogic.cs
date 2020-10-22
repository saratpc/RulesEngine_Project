using RulesEngine.Common;
using RulesEngine.Core;
using RulesEngine.DA;
using RulesEngine.DA.Models;
using System.Collections.Generic;

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

            IEnumerable<RERule> activeRules = _dataAccess.GetActiveRules();

            foreach (RERule rule in activeRules)
            {
                GetRuleFilters(rule.RuleId);
                ProcessRuleType(_processor, rule);
            }
        }

        private void GetRuleFilters(int ruleId)
        {
            _dataAccess.GetFiltersForRule(ruleId);
            _logger.LogMessage($"Getting the filters for Rule {ruleId}");
        }

        public void ProcessRuleType(IRulesEngineRuleProcessor _processor, RERule rule)
        {
            // Do the actions for the rule type
            // switch case for Rule Type

            // ProcessRuleType based on the active rule
            // call da to get the rule's filters

            //_processor.ProcessHermesConcatRule(1);
            _processor.ProcessRule(rule);

        }

    }
}
