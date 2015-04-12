using System;
using NUnit.Framework;

namespace TDDWorkshop
{
	class BankAccount
	{
        private int accountBalance;

        public BankAccount(int initialBalance)
        {
            this.accountBalance = initialBalance;
        }

     
        public int Credit(int amount)
        {
            accountBalance += amount;
            return accountBalance;
        }

        public void Transfer(BankAccount payeeAccount, int transferableAmount)
        {
            this.Credit(-transferableAmount);
            payeeAccount.Credit(transferableAmount);
        }

        public int GetAccountBalance(){
            return accountBalance;
        }
	}
}

