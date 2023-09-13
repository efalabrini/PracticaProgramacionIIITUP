
using ExploreOOP.src.BusinessLayer.Entities;
using PersistenceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.Services
{
    public class LineOfCreditAccountService : ILineOfCreditAccountRepository
    {
        public LineOfCreditAccount Get(int id) 
        {
            return _lineOfCreditAccountRepository.Get(id);
        }
    

        public void Delete(int id) 
        {
            _lineOfCreditAccountRepository.Delete(id);
        }
        ILineOfCreditAccountRepository _lineOfCreditAccountRepository;

        public LineOfCreditAccountService(ILineOfCreditAccountRepository lineOfCreditAccountRepository)
        {
            _lineOfCreditAccountRepository = lineOfCreditAccountRepository;
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
