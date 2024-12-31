using ByteBank.Modelos;
using ByteBank.Modelos.Contas;

namespace ByteBank.Menus;
internal class MenuCriarConta : Menu
{
    public override void Executar(Banco banco)
    {
        base.Executar(banco);
        ExibirTituloDaOpcao("Criar conta");
        Console.WriteLine("Vamos começar com os dados do titular");
        Console.Write("Digite o nome do titular: ");
        string nomeTitular = Console.ReadLine()!;
        Console.Write("Digite o CPF do titular: ");
        string cpfTitular = Console.ReadLine()!;
        Titular titular = new(nomeTitular, cpfTitular);
        Console.WriteLine("Titular cadastrado com sucesso!");
        Console.Write("\nDigite o número da agência: ");
        int agencia = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o número da conta: ");
        int numero = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Temos essas opções atualmente:");
        Console.WriteLine("1 - Poupança");
        Console.WriteLine("2 - Corrente");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                banco.AdicionarConta(new ContaPoupanca(titular, agencia, numero));
                break;
            case 2:
                banco.AdicionarConta(new Conta(titular, agencia, numero));
                break;
            default:
                Console.WriteLine("Opção inválida. Dê início ao processo de abertura de conta novamente!");
                return;
        }

        MenuRodape();
    }
}
