namespace ByteBank.Exceptions;
internal class TipoDeContaInvalidoException : Exception
{
    public TipoDeContaInvalidoException() : base("Tipo de conta inválido para a operação desejada.")
    {
    }
}
