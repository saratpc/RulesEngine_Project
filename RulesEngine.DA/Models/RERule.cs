using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.DA.Models
{
    public class RERule
    {
        public int RuleId { get; set; }
        public string RuleDesc { get; set; }
        public int InputLevel { get; set; }
        public int OutputLevel { get; set; }
        public bool Cascade { get; set; }
        public string RuleType { get; set; }
    }
}
