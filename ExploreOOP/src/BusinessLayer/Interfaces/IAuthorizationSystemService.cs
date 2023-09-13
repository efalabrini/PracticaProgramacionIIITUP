using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreOOP.src.BusinessLayer.Entities;

namespace ExploreOOP.src.BusinessLayer.Interfaces
{
    public interface IAuthorizationSystemService
    {
        public void AuthorizeTransaction(Transaction transaction);

    }
}
