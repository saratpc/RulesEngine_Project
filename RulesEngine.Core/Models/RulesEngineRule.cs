using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Core.Models
{
    public enum RuleType
    {
        HermesSEOConcatenation,
        ImageAssociation,
        GenericRuleType
    }
    public class RulesEngineRule
    {
        public RuleType RuleType { get; set; }

        
    }
    
    public class Blah
    {
        public void Do()
        {
            RulesEngineRule rule = new RulesEngineRule() { RuleType = RuleType.HermesSEOConcatenation };
            
        }
        
    }
}
