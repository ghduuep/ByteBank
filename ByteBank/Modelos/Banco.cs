using ByteBank.Modelos.Contas;

namespace ByteBank.Modelos;
internal class Banco
{ 
    private List<Conta> contasCadastradas = new();

    public void ExibirContasCadastradas()
    {
        foreach(var conta in contasCadastradas)
        {
            Console.WriteLine($"Número: {conta.Numero}");
            Console.WriteLine($"Agência: {conta.Agencia}");
            Console.WriteLine($"Títular: {conta.Titular.Nome}");
            Console.WriteLine($"Saldo: {conta.Saldo}");
            Console.WriteLine($"Tipo de conta: {(conta is ContaPoupanca ? "Poupança" : "Corrente")}");
        }
    }
    public void AdicionarConta(Conta conta)
    {
        if (conta != null)
        {
            contasCadastradas.Add(conta);
            Console.WriteLine("Tudo certo! Agora você faz parte da família ByteBank :)");
        }else
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
}
