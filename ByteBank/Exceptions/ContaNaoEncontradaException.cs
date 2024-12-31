namespace ByteBank.Exceptions;
internal class ContaNaoEncontradaException : Exception
{
    public ContaNaoEncontradaException(int agencia, int numero) : base($"Conta não encontrada na agência {agencia} e número {numero}.") { }
}
