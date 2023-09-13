using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreOOP.src.BusinessLayer.Entities;

namespace ExploreOOP.src.BusinessLayer.Interfaces
{
    public interface ILineOfCreditAccountService
    {
        public List<LineOfCreditAccount> GetAll();

        public void Add(LineOfCreditAccount lineOfCreditAccount);

        public LineOfCreditAccount Get(int id);

        public void Delete(int id);
    }
}