using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.BankOfKurtovoKonare.Interfaces
{
    public interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal IntRate { get; set; }
    }
}
