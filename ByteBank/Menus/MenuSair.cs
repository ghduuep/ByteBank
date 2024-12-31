using ByteBank.Modelos;

namespace ByteBank.Menus;
internal class MenuSair : Menu
{
    public override void Executar(Banco banco)
    {
        base.Executar(banco);
        Console.WriteLine("Obrigado por utilizar nossos serviços! Tenha um bom dia.");
    }
}
