using Problem02.BankOfKurtovoKonare.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based). 
//Deposit accounts are allowed to deposit and withdraw money. Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest for a given period (in months) using the formula
//A = money * (1 + interest rate * months) 
//Loan accounts have no interest for the first 3 months if held by individuals and for the first 2
//months if held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 
//6 months for individuals.
//Write a program to model the bank system with classes and interfaces. You should identify the classes,
//interfaces, base classes and abstract actions and implement the calculation of the interest functionality
//through overridden methods. Write a program to demonstrate that your classes work correctly.

namespace Problem02.BankOfKurtovoKonare
{
    public class LoanAccount : Accounts, IAccount
    {
        public LoanAccount(Customer customer, decimal balance, decimal intRate)
            : base(customer, balance, intRate)
        {
        }

        public override decimal CalculateRate(int months)
        {
            if (Customer is Individual)
            {
                if (months >= 3)
                {
                    return base.CalculateRate(months - 3);
                }
                else
                {
                    return base.CalculateRate(0);
                }
            }
            else if (Customer is Company)
            {
                if (months >= 2)
                {
                    return base.CalculateRate(months - 2);
                }
                else
                {
                    return base.CalculateRate(0);
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
