using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    class Test
    {
        static void Main(string[] args)
        {
            DepositAccount depAc = new DepositAccount("person", 1000, 15);
            LoanAccount loanAc = new LoanAccount("person", 1000, 15);
            MortgageAccount morgAc = new MortgageAccount("company", 1000, 15);
            List<Account> accounts = new List<Account>();
            accounts.Add(depAc);
            accounts.Add(morgAc);
            accounts.Add(loanAc);
            foreach (var account in accounts)
            {
                account.DepositMoney(50);
                Console.WriteLine(account);
                Console.WriteLine(account.CalculateInterest(9));
            }
        }
    }
}
