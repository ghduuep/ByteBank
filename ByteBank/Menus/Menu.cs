using ByteBank.Modelos;

namespace ByteBank.Menus;
internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos);
    }

    public virtual void Executar(Banco banco)
    {
        Console.Clear();
    }
}
