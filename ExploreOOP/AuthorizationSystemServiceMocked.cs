using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreOOP
{
    public class AuthorizationSystemServiceMocked : IAuthorizationSystemService
    {
        public void AuthorizeTransaction()
        {
            Console.WriteLine("Transaction approved by mocked system");
        }
    }
}
