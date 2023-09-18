using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreOOP.BusinessLayer.Entities;
using ExploreOOP.BusinessLayer.Interfaces;

namespace ExploreOOP.BusinessLayer.Services
{
    public class AuthorizationSystemService : IAuthorizationSystemService
    {
        public void AuthorizeTransaction(Transaction transaction)
        {
            //To do: AI validations

            Console.WriteLine($"{transaction.Amount} USD Transaction approved by an AI system");
        }
    }
}
