using ByteBank.Menus;
using ByteBank.Modelos;

Banco banco = new();

void ExibirLogo()
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

void ExibirOpcoesMenu()
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
        case 1:
            new MenuCriarConta().Executar(banco);
            ExibirOpcoesMenu();
            break;
        case 6:
            new MenuListarContas().Executar(banco);
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

ExibirOpcoesMenu();