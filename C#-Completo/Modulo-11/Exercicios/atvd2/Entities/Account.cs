using Entities.Exceptions;

namespace Entities;

class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }
 

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
    }

    public void deposit(double amount)
    {
        Balance += amount;
    }

    public void withdraw(double amount)
    {
        if (amount > Balance)
        {
            throw new DomainException("Saldo Insuficiente!");
        }
        if (amount > WithdrawLimit)
        {
            throw new DomainException($"O valor é superior ao limite de saque R$ {WithdrawLimit}");
        }

        Balance -= amount;
    }

    public override string ToString()
    {
        return $"New Balance: {Balance}";
    }

}