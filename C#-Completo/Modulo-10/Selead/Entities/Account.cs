
namespace Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; } = null!;
        public double Balance { get; protected set; }
        
        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double valor)
        {
            Balance -= valor + 5;
        }

        public void Deposit(double valor)
        {
            Balance += valor;
        }

    } 
}