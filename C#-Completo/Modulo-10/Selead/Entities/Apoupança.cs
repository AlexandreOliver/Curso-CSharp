namespace Entities;

class Conta_poupanca : Account
{
    public double cTaxa {get; set;} = 0;

    public Conta_poupanca(int number, string holder, double balance, double taxa)
        : base(number, holder, balance)
    {
        Taxa = taxa;
    }


     public sealed override void Withdraw(double valor)
    {
        base.Balance -= valor;
    }
}