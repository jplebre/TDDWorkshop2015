using System;
using NUnit.Framework;

namespace TDDWorkshop
{
    [TestFixture]
    public class BankingTests
    {

        [Test]
        public void TransferTestOne()
        {
            BankAccount payerAccount = new BankAccount(0);
            BankAccount payeeAccount = new BankAccount(0);

            payerAccount.Credit(100); //give the payer some money

            int transferableAmount = 50;

            payerAccount.Transfer(payeeAccount, transferableAmount);

            Assert.AreEqual(50, payerAccount.GetAccountBalance());
            Assert.AreEqual(50, payeeAccount.GetAccountBalance());
        }

       
    }
}

