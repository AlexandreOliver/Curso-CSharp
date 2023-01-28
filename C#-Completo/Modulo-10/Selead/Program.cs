using Entities;


Account contaBase = new Account(1023, "Alex", 200);
BusinessAccount contaEmpresa = new BusinessAccount(1023, "Alex", 200, 100);
Conta_poupanca contaPoup = new Conta_poupanca(1023, "Alex", 200, 0.01);

contaBase.Withdraw(10); // Tira 15
contaEmpresa.Withdraw(10); // Tira 15
contaPoup.Withdraw(10); // Tira 10

Console.WriteLine("Saldos: ");
Console.WriteLine(contaBase.Balance);
Console.WriteLine(contaEmpresa.Balance);
Console.WriteLine(contaPoup.Balance);


