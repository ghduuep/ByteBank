using ByteBank.Menus;
using ByteBank.Modelos;
using ByteBank.Modelos.Contas;

Banco banco = new Banco();
MenuPrincipal menuPrincipal = new MenuPrincipal();
try
{
    menuPrincipal.Executar(banco);
} catch(Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Voltando para o menu principal...");
    Thread.Sleep(2000);
    menuPrincipal.Executar(banco);
} 