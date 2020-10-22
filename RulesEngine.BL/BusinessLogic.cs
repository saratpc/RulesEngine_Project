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
            //dataAccess.GetDataFromDB();

            // dependency 2
            //Logger logger = new Logger();
            //logger.LogMessage("Processed Queue");

            _dataAccess.GetDataFromDB(_processor);
            _logger.LogMessage("Processed Queue");
        }
    }
}
