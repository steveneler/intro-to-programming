

using Banking.Domain;

namespace Banking.UnitTests.TestDoubles;

public class StubbedBonusCalculator : ICalculateBonuses
{
    public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
    {
        return currentBalance == 500M && amountOfDeposit == 92.42M ? 42 : 0;
    }
}
