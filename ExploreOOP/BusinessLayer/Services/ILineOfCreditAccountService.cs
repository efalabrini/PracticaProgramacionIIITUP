using ExploreOOP.BusinessLayer.Entities;

namespace ExploreOOP.BusinessLayer.Services
{
    public interface ILineOfCreditAccountService
    {
        void Add(LineOfCreditAccount lineOfCreditAccount);
        void Delete(int id);
        LineOfCreditAccount Get(int id);
        List<LineOfCreditAccount> GetAll();
    }
}