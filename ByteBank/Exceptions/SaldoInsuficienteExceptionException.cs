namespace ByteBank.Exceptions;
internal class SaldoInsuficienteExceptionException : Exception
{
    public SaldoInsuficienteExceptionException(double saldo, double valor) : base($"Saldo insuficiente para a operação desejada.") { }
}
