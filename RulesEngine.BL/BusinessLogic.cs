using RulesEngine.Common;
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

        public BusinessLogic(IDataAccess dataAccess, ILogger logger)
        {
            _dataAccess = dataAccess;
            _logger = logger;
        }

        public void ProcessData()
        {
            Console.WriteLine("Processing queue");

            // dependency 1
            //DataAccess dataAccess = new DataAccess();
            //dataAccess.GetDataFromDB();

            // dependency 2
            //Logger logger = new Logger();
            //logger.LogMessage("Processed Queue");

            _dataAccess.GetDataFromDB();
            _logger.LogMessage("Processed Queue");
        }
    }
}
