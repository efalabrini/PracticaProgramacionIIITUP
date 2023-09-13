using ExploreOOP.src.BusinessLayer.Entities;

namespace BusinessLayer.Services
{
    public interface ILineOfCreditAccountService
    {
        void Add(LineOfCreditAccount lineOfCreditAccount);
        void Delete(int id);
        LineOfCreditAccount Get(int id);
        List<LineOfCreditAccount> GetAll();
    }
}