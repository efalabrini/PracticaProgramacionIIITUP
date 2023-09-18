using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreOOP.BusinessLayer.Interfaces;
using ExploreOOP.BusinessLayer.Services;

namespace ExploreOOP.BusinessLayer.Entities
{
    public class LineOfCreditAccount : BankAccount
    {
        //Dependency Injection constructor
        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit, IAuthorizationSystemService authorizationSystemService)
            : base(name, initialBalance, -creditLimit, authorizationSystemService)
        {
        }

        //Dependency Non-Injection constructor
        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit)
            : base(name, initialBalance, -creditLimit, new AuthorizationSystemService())
        {
        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                // Negate the balance to get a positive interest charge:
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }

        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
        isOverdrawn
        ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
        : default;
    }
}
