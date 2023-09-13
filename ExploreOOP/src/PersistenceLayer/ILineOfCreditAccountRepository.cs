using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreOOP.src.BusinessLayer.Entities;

namespace PersistenceLayer
{
    public interface ILineOfCreditAccountRepository
    {
        List<LineOfCreditAccount> GetAll();

        LineOfCreditAccount Get(int id);

        void Add(LineOfCreditAccount lineOfCreditAccount);

        void Delete(int id);
        LineOfCreditAccount Add(int lineOfCreditAccount);
    }
}
