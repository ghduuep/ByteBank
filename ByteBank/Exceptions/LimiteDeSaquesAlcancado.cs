namespace ByteBank.Exceptions;
internal class LimiteDeSaquesAlcancado : Exception
{
    public LimiteDeSaquesAlcancado() : base("Você atingiu o limite de saques na sua conta.") { }
}
