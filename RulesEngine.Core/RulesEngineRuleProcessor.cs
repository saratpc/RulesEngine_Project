using RulesEngine.DA.Models;

namespace RulesEngine.Core
{
    public class RulesEngineRuleProcessor : IRulesEngineRuleProcessor
    {
        // Process different kinds of rules

        IHermesConcatRuleProcessor _processor;
        public RulesEngineRuleProcessor(IHermesConcatRuleProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessRule(RERule rule)
        {
            // switch case
            // based on the Rule Type: call the appropriate processor
            if (rule.RuleType == "HermesSEOConcatenation")
            {
                //HermesConcatRuleProcessor hermes = new HermesConcatRuleProcessor();
                //hermes.ProcessHermesConcatRule(1);
                _processor.ProcessHermesConcatRule(1);


            }
        }
    }
}
