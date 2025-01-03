using ByteBank.Modelos.Contas;
using ByteBank.Exceptions;

namespace ByteBank.Modelos;
internal class Banco
{
    private List<Conta> contasCadastradas = new();

    public void ExibirContasCadastradas()
    {
        contasCadastradas.Sort();
        foreach (var conta in contasCadastradas)
        {
            Console.WriteLine($"Agência: {conta.Agencia}");
            Console.WriteLine($"Número: {conta.Numero}");
            Console.WriteLine($"Títular: {conta.Titular.Nome}");
            Console.WriteLine($"Saldo: R${conta.Saldo}");
            Console.WriteLine($"Tipo de conta: {(conta is ContaPoupanca ? "Poupança" : "Corrente")}\n");
        }
    }
    public void AdicionarConta(Conta conta)
    {
        if (conta != null)
        {
            contasCadastradas.Add(conta);
            Console.WriteLine("Tudo certo! Agora você faz parte da família ByteBank :)");
        }
        else
        {
            throw new ArgumentNullException("Ops, algo deu errado! Verifique os dados da conta e tente novamente.");
        }
    }

    public void RemoverConta(Conta conta)
    {
        if (conta != null)
        {
            contasCadastradas.Remove(conta);
            Console.WriteLine("Conta removida com sucesso!");
        }
        else
        {
            throw new ArgumentNullException("Ops, algo deu errado! Verifique os dados da conta e tente novamente.");
        }
    }

    public Conta BuscarConta(int numeroConta, int agencia)
    {
        var conta = contasCadastradas.FirstOrDefault(conta => conta.Numero == numeroConta && conta.Agencia == agencia);
        if (conta != null)
        {
            return conta;
        }
        else
        {
            throw new ContaNaoEncontradaException(numeroConta, agencia);
        }
    }
}
