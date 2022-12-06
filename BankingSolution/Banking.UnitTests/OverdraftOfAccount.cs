

using Banking.Domain;

namespace Banking.UnitTests;

public class OverdraftOfAccount
{

    [Fact]
    public void CanTakeAllTheMoney()
    {
        var account = new BankAccount();

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }

    [Fact]
    public void OverdraftDoesNotDecreaseTheBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithDraw = openingBalance + .01M;

        try
        {
            account.Withdraw(amountToWithDraw);
        }
        catch (OverdraftException)
        {

            // Ignore it.
        }

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void OverdraftThrowsAnOverdraftException()
    {
        var account = new BankAccount();

        Assert.Throws<OverdraftException>(() =>
        {
            account.Withdraw(account.GetBalance() + 0.1M);
        });

    }
}
