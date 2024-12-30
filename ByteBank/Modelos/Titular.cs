namespace ByteBank.Modelos;
internal class Titular
{
    public Titular(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }
    public string Nome { get; }
    public string CPF { get; }
}
