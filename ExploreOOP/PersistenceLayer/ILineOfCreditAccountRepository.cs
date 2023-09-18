using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreOOP.BusinessLayer.Entities;

namespace ExploreOOP.PersistenceLayer
{
    public interface ILineOfCreditAccountRepository
    {
        List<LineOfCreditAccount> GetAll();

        LineOfCreditAccount Get(int id);

        void Add(LineOfCreditAccount lineOfCreditAccount);

        void Delete(int id);


    }
}
