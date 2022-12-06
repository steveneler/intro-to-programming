﻿
using Banking.Domain;

namespace Banking.UnitTests;

public class NewAccounts
{
    [Fact]
    public void HaveTheCorrectOpeningBalance()
    {
        //Given
        var account = new BankAccount();

        //When
        decimal balance = account.GetBalance();

        //Then
        Assert.Equal(5000M, balance);
    }
}
