using System;
using Xunit;
using BankidyBanking;

namespace BankingTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(430)]
        [InlineData(0)]
        [InlineData(100.0001)]
        public void DepositTest(decimal num)
        {
            decimal startingBalance = Program._balance;
            Assert.Equal(startingBalance + num, Program.Deposit(num));
        }

        [Fact]
        public void DepositNegativeTest()
        {
            decimal startingBalance = Program._balance;
            Assert.Equal(startingBalance, Program.Deposit(-1));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(200)]
        [InlineData(400)]
        [InlineData(1.0000001)]
        public void WithdrawTest(decimal num)
        {
            Program._balance = 400;
            decimal startingBalance = Program._balance;
            Assert.Equal(startingBalance - num, Program.Withdraw(num));
        }

        [Fact]
        public void WithdrawNegativeTest()
        {
            decimal startingBalance = Program._balance;
            Assert.Equal(startingBalance, Program.Withdraw(-1));
        }

        [Fact]
        public void InsufficientFundsTest()
        {
            Program._balance = 400;
            Assert.Equal(400, Program.Withdraw(401));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(200)]
        [InlineData(400.000011014)]
        public void ViewBalanceTest(decimal num)
        {
            Program._balance = num;
            Assert.Equal(num, Program.ViewBalance());
        }
    }
}
