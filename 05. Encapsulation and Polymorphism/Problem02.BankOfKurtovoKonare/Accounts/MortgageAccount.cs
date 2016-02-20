using Problem02.BankOfKurtovoKonare.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.BankOfKurtovoKonare
{
    class MortgageAccount : Accounts, IAccount
    {
        public MortgageAccount(Customer customer, decimal balance, decimal intRate)
            : base(customer, balance, intRate)
        {
        }

        public override decimal CalculateRate(int months)
        {
            if (Customer is Company)
            {
                if (months < 12)
                {
                    return base.CalculateRate(months) * 1/2 ;
                }
                else
                {
                    return base.CalculateRate(0);
                }

            }
            else if (Customer is Individual)
            {
                if (months < 6)
                {
                    return base.CalculateRate(0);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            return base.ToString();
        }
    }
}
