using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreOOP.src.BusinessLayer.Entities;
using ExploreOOP.src.BusinessLayer.Interfaces;

namespace ExploreOOP.src.BusinessLayer.Services
{
    public class AuthorizationSystemServiceMocked : IAuthorizationSystemService
    {
        public void AuthorizeTransaction(Transaction transaction)
        {
            Console.WriteLine($"{transaction.Amount} USD Transaction approved by mocked system ");
        }
    }
}
