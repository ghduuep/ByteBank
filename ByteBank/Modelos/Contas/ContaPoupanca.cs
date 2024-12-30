using ByteBank.Exceptions;

namespace ByteBank.Modelos.Contas;
internal class ContaPoupanca : Conta
{
    public int numeroDeSaques = 0;
    public int limiteSaques = 10;
    private double taxaRendimento = 0.01;
    public ContaPoupanca(Titular titular, int agencia, int numero) : base(titular, agencia, numero)
    {
    }

    public void GerarRendimento()
    {
        var rendimento = Saldo * taxaRendimento;
        Console.WriteLine($"Seu saldo rendeu R${rendimento}.");
        Saldo += rendimento;
    }
    public override void Sacar(double valor)
    {
        if (numeroDeSaques >= limiteSaques)
        {
            throw new LimiteDeSaquesAlcancado();
        }
        base.Sacar(valor);
        numeroDeSaques++;
    }

    public override void Transferir(double valor, Conta contaDestino)
    {
        var taxa = 0.05;
        var novoValor = GerarTaxa(valor, taxa);
        Console.WriteLine($"O valor atualizado com as taxas referentes à sua conta é de R${novoValor}. Certifique-se de ter o valor em conta!");
        base.Transferir(novoValor, contaDestino);
    }

    private double GerarTaxa(double valor, double taxa)
    {
        return valor + (valor * taxa);
    }
}
