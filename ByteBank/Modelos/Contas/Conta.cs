using ByteBank.Exceptions;

namespace ByteBank.Modelos;
internal class Conta
{
    public Conta(Titular titular, int agencia, int numero)
    {
        Titular = titular;
        Agencia = agencia;
        Numero = numero;
        Saldo = 0.0;
    }
    public Titular Titular { get; }
    public int Agencia { get; }
    public int Numero { get; }
    public double Saldo { get; set; }

    public virtual void Sacar(double valor)
    {
        if (valor < 0)
        {
            throw new ArgumentException("O valor do saque deve ser superior a R$0,00.", nameof(valor));
        }
        if (valor > Saldo)
        {
            throw new SaldoInsuficienteExceptionException(Saldo, valor);
        }
        Saldo -= valor;
        Console.WriteLine($"Valor de R${valor} debitado de sua conta.");
    }

    public void Depositar(double valor)
    {
        if (valor < 0) {
            throw new ArgumentException("O valor do depósito deve ser superior a R$0,00.", nameof(valor));
        }
        Saldo += valor;
        Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
    }

    public virtual void Transferir(double valor, Conta contaDestino)
    {
        if (valor < 0)
        {
            throw new ArgumentException("O valor da transferência deve ser superior a R$0,00.", nameof(valor));
        }
        if (valor > Saldo)
        {
            throw new SaldoInsuficienteExceptionException(Saldo, valor);
        }
        Sacar(valor);
        contaDestino.Depositar(valor);
    }
}
