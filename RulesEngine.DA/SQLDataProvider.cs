using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RulesEngine.DA.Models;

namespace RulesEngine.DA
{
    public class SQLDataProvider : IDataAccess, IDataProvider
    {
        public IEnumerable<RERule> GetActiveRules()
        {
            // TODO: GetActiveRules from Rules Engine DB Tables
            // Configure Dapper
            return null;
        }

        public string GetFiltersForRule(int ruleId)
        {
            // TODO: GetFiltersForRule from Rules Engine DB Tables
            // Configure Dapper
            return null;
        }
    }
}
