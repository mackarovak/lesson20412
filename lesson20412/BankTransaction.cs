using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class BankTransaction
    {
        public enum TypeTransaction
        {
            Withdrawalofmoney,
            Replenishment,
            Transfer
        }
        public readonly DateTime dateTime = new DateTime();
        public double summa { get;}
        public TypeTransaction typeTransaction { get; }
        public BankTransaction(double summa)
        {
            this.summa = summa;
            dateTime = DateTime.Now;
        }
    }
}
