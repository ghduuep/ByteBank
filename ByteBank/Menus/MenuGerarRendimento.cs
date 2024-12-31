using ByteBank.Exceptions;
using ByteBank.Modelos;
using ByteBank.Modelos.Contas;

namespace ByteBank.Menus;
internal class MenuGerarRendimento : Menu
{
    public override void Executar(Banco banco)
    {
        base.Executar(banco);
        ExibirTituloDaOpcao("Gerar rendimento");
        Console.WriteLine("Aqui você pode conferir o rendimento de sua conta. Válido apenas para Poupança.");
        Thread.Sleep(2000);
        Console.Write("Digite a agência: ");
        int agencia = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o número da conta: ");
        int numero = int.Parse(Console.ReadLine()!);
        var conta = banco.BuscarConta(numero, agencia);
        if (conta is ContaPoupanca contaPoupanca)
        {
            contaPoupanca.GerarRendimento();
        }
        else
        {
            throw new TipoDeContaInvalidoException();
        }
        MenuRodape();
    }
}
