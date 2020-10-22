using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ProcessRule(string ruleType)
        {
            // switch case
            // based on the Rule Type: call the appropriate processor
            if(ruleType == "HermesSEOConcatenation")
            {
                //HermesConcatRuleProcessor hermes = new HermesConcatRuleProcessor();
                //hermes.ProcessHermesConcatRule(1);
                _processor.ProcessHermesConcatRule(1);


            }

        }
    }
}
