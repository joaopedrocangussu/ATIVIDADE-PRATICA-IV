namespace Cenario03_EmpresaServicosTecnicos.Exceptions;

public class ServicoInexistenteException : Exception
{
    public ServicoInexistenteException(string message) : base(message)
    {
    }
}
