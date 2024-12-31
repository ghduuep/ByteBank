using ByteBank.Menus;
using ByteBank.Modelos;
internal class MenuRealizarSaque : Menu
{
    public override void Executar(Banco banco)
    {
        base.Executar(banco);
        ExibirTituloDaOpcao("Saques");
        Console.Write("Digite a agência: ");
        int agencia = int.Parse(Console.ReadLine()!);
        Console.Write("Agora digite o número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o valor do saque: ");
        double valorSaque = double.Parse(Console.ReadLine()!);
        Conta contaEncontrada = banco.BuscarConta(numeroConta, agencia);
        contaEncontrada.Sacar(valorSaque);
        MenuRodape();
    }
}