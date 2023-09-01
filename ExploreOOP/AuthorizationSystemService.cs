using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreOOP
{
    public class AuthorizationSystemService : IAuthorizationSystemService
    {
        public void AuthorizeTransaction()
        {
            //To do: AI validations

            Console.WriteLine("Transaction approved by an AI system");
        }
    }
}
