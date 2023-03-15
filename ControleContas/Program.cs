using ControleContas.Model;

Conta conta = new Conta("1234" , 1000.99m);
Conta conta2 = new Conta("654321", 2341.42m);
Console.WriteLine($"Conta: {conta.Numero}; Saldo: {conta.Saldo}");
Console.WriteLine($"Conta2: {conta2.Numero}; Saldo: {conta2.Saldo}");
Console.WriteLine($"Soma Conta + Conta2 = : {conta.Saldo + conta2.Saldo}");
Console.WriteLine($"O Saldo Total de todas as contas é: {conta2.SaldoTotal}");