using ByteBank.Modelos;

namespace ByteBank.Menus;
internal class MenuListarContas : Menu
{
    public override void Executar(Banco banco)
    {
        base.Executar(banco);
        ExibirTituloDaOpcao("Contas registradas");
        banco.ExibirContasCadastradas();
        MenuRodape();
    }
}
