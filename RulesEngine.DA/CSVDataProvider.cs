using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RulesEngine.DA.Models;

namespace RulesEngine.DA
{
    public class CSVDataProvider : IDataAccess, IDataProvider
    {
        public IEnumerable<RERule> GetActiveRules()
        {
            string PRODUCT_FILTERS_FILE = "Resources\\ActiveRules.txt";
            // Read active filters from a file

            // Get the file's contents.
            string file_contents = File.ReadAllText(PRODUCT_FILTERS_FILE);

            // Break the file into lines.
            string[] lines = file_contents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var activeRules = lines.Select(line => new RERule()
            {
                
                RuleId = int.Parse(line.Split(',')[0]),
                RuleDesc = line.Split(',')[1],
                RuleType = line.Split(',')[2],
                InputLevel = int.Parse(line.Split(',')[3]),
                OutputLevel = int.Parse(line.Split(',')[4]),
                Cascade = bool.Parse(line.Split(',')[5])
            });
            return activeRules;
        }

        public string GetFiltersForRule(int ruleId)
        {
            return "";
            // TODO
            
        }
    }
}
