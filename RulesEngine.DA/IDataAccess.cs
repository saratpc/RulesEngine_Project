using RulesEngine.Core;

namespace RulesEngine.DA
{
    public interface IDataAccess
    {
        void GetDataFromDB(IHermesConcatRuleProcessor processor);
    }
}