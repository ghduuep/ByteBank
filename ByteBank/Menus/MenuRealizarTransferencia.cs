using ByteBank.Modelos;

namespace ByteBank.Menus;
internal class MenuRealizarTransferencia : Menu
{
    public override void Executar(Banco banco)
    {
        base.Executar(banco);
        ExibirTituloDaOpcao("Realizar transferência");
        Console.WriteLine("Primero precisamos de seus dados");
        Console.Write("Digite a agência: ");
        int agencia = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o número da conta: ");
        int numero = int.Parse(Console.ReadLine()!);
        Conta contaOrigem = banco.BuscarConta(numero, agencia);
        Console.Write("Digite o valor a ser transferido: ");
        double valor = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Agora precisamos dos dados da conta de destino");
        Console.Write("Digite a agência: ");
        int agenciaDestino = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o número da conta: ");
        int numeroDestino = int.Parse(Console.ReadLine()!);
        Conta contaDestino = banco.BuscarConta(numeroDestino, agenciaDestino);
        Console.WriteLine($"Ok, vamos transferir R${valor} para a conta de destino.");
        contaOrigem.Transferir(valor, contaDestino);

        MenuRodape();
    }
}
