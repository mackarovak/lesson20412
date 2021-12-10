using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework
{
	class Account : Indexcreation
	{
		public enum AccountType
		{
			Current,
			Savings
		}
		private Type accountType;
		private double balance;
		private int index;
		static int indexer = 0;
		private string cardHolder;
		private Queue<BankTransaction> transactions;
		public double Balans { get { return Balans; } }
		public AccountType Type { get { return Type; } }
		public string CardHolder{ get=> cardHolder; set => cardHolder=value; }
		public int Index { get => index; }
		static private int transIndex = 0;
		private BankTransaction[] BankTransaction;
		public BankTransaction this[int index]
        {
			get { return BankTransaction[index]; }
			set { BankTransaction[index] = value; }
        }
		public Account()
		{
			index = indexer++;
			transactions = new Queue<BankTransaction>();
			BankTransaction = new BankTransaction[10];
		}

		public Account(double balance)
		{
			index = indexer++;
			this.balance = balance;
			transactions = new Queue<BankTransaction>();
			BankTransaction = new BankTransaction[10];
		}

		public Account(Type accountType)
		{
			index = indexer++;
			this.accountType = accountType;
			transactions = new Queue<BankTransaction>();
			BankTransaction = new BankTransaction[10];
		}

		public Account(Type accountType, double balance) : this(accountType)
		{
			this.balance = balance;
		}

		public bool Draw(double summa)
		{
			if (summa <= balance)
			{
				balance -= summa;
				transactions.Enqueue(new BankTransaction(-summa));
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool Put(double summa)
		{
			if (summa > 0)
			{
				balance += summa;
				transactions.Enqueue(new BankTransaction(summa));
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool MakeTransfer(Account receiver, double summa)
		{
			if (Draw(summa))
			{
				receiver.Put(summa);
				return true;
			}
			else
			{
				return false;
			}
		}
		public void Dispose(string file)
		{
			StreamWriter sw = new StreamWriter(file);
			sw.Write(string.Join("\n", transactions));
			sw.Close();
			GC.SuppressFinalize(sw);
		}
		public override bool Equals(object obj)
		{
			if (obj is Account)
			{
				return this == (obj as Account);
			}
			else
			{
				return false;
			}
		}
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
		public override string ToString()
		{
			return $"{Index}. Тип: {accountType}, баланс: {Balans}";
		}
	}
}
