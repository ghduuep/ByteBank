namespace ByteBank.Exceptions;
internal class LimiteDeSaquesAlcancadoException : Exception
{
    public LimiteDeSaquesAlcancadoException() : base("Você atingiu o limite de saques na sua conta.") { }
}
