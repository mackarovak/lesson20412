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
        private DateTime dateTime;
        private TimeSpan time;
        private double summa;
        public DateTime DateTime { get { return dateTime; } }
        public double Summa { get { return summa; } }
        public TimeSpan Time { get => time; }
        public TypeTransaction typeTransaction { get; }
        public BankTransaction(double summa)
        {
            this.summa = summa;
            dateTime = DateTime.Now.Date;
            time = DateTime.Now.TimeOfDay;
        }
    }
}
