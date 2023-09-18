using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreOOP.BusinessLayer.Entities;

namespace ExploreOOP.BusinessLayer.Interfaces
{
    public interface IAuthorizationSystemService
    {
        public void AuthorizeTransaction(Transaction transaction);

    }
}
