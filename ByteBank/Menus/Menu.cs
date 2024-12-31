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

    public void MenuRodape()
    {
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
    }

    public virtual void Executar(Banco banco)
    {
        Console.Clear();
    }
}
