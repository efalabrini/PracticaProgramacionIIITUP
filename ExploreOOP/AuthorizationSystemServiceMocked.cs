using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreOOP
{
    public class AuthorizationSystemServiceMocked : IAuthorizationSystemService
    {
        public void AuthorizeTransaction(Transaction transaction)
        {
            Console.WriteLine($"{transaction.Amount} USD Transaction approved by mocked system ");
        }
    }
}
