using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            BankAccount bankAccount = new BankAccount();
            

            // what you test
            //act
            double balance = bankAccount.Deposit(-1000.00);
            // test
            //assert
            // check assumptions are correct


            //Assert.ThrowsException<ArgumentOutOfRangeException>(() => bankAccount.Deposit(-1000.00));
            Assert.AreNotEqual(99000.00, bankAccount.Balance);
            


        }
    }
}