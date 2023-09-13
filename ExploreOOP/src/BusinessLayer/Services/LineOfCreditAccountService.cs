﻿
using ExploreOOP.src.BusinessLayer.Entities;
using PersistenceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreOOP.src.BusinessLayer.Interfaces;


namespace BusinessLayer.Services
{
    public class LineOfCreditAccountService : ExploreOOP.src.BusinessLayer.Interfaces.ILineOfCreditAccountService
    {
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

        public LineOfCreditAccount Get(int id)
        {
            return _lineOfCreditAccountRepository.Get(id);
        }

        public void Delete(int id)
        {
            _lineOfCreditAccountRepository.Delete(id);
        }

    }
}
