namespace ByteBank.Exceptions;
internal class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(double saldo, double valor) : base($"Saldo insuficiente para a operação desejada.") { }
}
