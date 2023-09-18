
using ExploreOOP.BusinessLayer.Entities;
using ExploreOOP.PersistenceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreOOP.BusinessLayer.Services
{
    public class LineOfCreditAccountService : ILineOfCreditAccountService
    {
        ILineOfCreditAccountRepository _lineOfCreditAccountRepository;

        public LineOfCreditAccountService(ILineOfCreditAccountRepository lineOfCreditAccountRepository)
        {
            _lineOfCreditAccountRepository = lineOfCreditAccountRepository;
        }

        public LineOfCreditAccount Get(int id)
        {
            return _lineOfCreditAccountRepository.Get(id);
        }


        public void Delete(int id)
        {
            _lineOfCreditAccountRepository.Delete(id);
        }


        public List<LineOfCreditAccount> GetAll()
        {
            return _lineOfCreditAccountRepository.GetAll();
        }

        public void Add(LineOfCreditAccount lineOfCreditAccount)
        {
            _lineOfCreditAccountRepository.Add(lineOfCreditAccount);
        }
    }
}
