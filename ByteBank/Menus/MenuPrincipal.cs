using ByteBank.Modelos;

namespace ByteBank.Menus;

internal class MenuPrincipal : Menu
{
    private void ExibirLogo()
    {
        Console.WriteLine(@"
██████╗░██╗░░░██╗████████╗███████╗██████╗░░█████╗░███╗░░██╗██╗░░██╗
██╔══██╗╚██╗░██╔╝╚══██╔══╝██╔════╝██╔══██╗██╔══██╗████╗░██║██║░██╔╝
██████╦╝░╚████╔╝░░░░██║░░░█████╗░░██████╦╝███████║██╔██╗██║█████═╝░
██╔══██╗░░╚██╔╝░░░░░██║░░░██╔══╝░░██╔══██╗██╔══██║██║╚████║██╔═██╗░
██████╦╝░░░██║░░░░░░██║░░░███████╗██████╦╝██║░░██║██║░╚███║██║░╚██╗
╚═════╝░░░░╚═╝░░░░░░╚═╝░░░╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝");
        Console.WriteLine("Boas-vindas ao ByteBank, a sua solução financeira!");
    }

    public override void Executar(Banco banco)
    {
        ExibirLogo();
        Console.WriteLine("\n1 - Criar conta");
        Console.WriteLine("2 - Realizar saque");
        Console.WriteLine("3 - Realizar depósito");
        Console.WriteLine("4 - Realizar transferência");
        Console.WriteLine("5 - Gerar rendimento");
        Console.WriteLine("6 - Exibir contas");
        Console.WriteLine("\n0 - Sair");
        Console.Write("Digite a sua opção:");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 0:
                new MenuSair().Executar(banco);
                break;
            case 1:
                new MenuCriarConta().Executar(banco);
                Executar(banco);
                break;
            case 2:
                new MenuRealizarSaque().Executar(banco);
                Executar(banco);
                break;
            case 3:
                new MenuRealizarDeposito().Executar(banco);
                Executar(banco);
                break;
            case 4:
                new MenuRealizarTransferencia().Executar(banco);
                Executar(banco);
                break;
            case 5:
                new MenuGerarRendimento().Executar(banco);
                Executar(banco);
                break;
            case 6:
                new MenuListarContas().Executar(banco);
                Executar(banco);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                Executar(banco);
                break;
        }
    }
}
