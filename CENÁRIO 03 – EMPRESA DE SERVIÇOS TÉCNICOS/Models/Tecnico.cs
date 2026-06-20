using Cenario03_EmpresaServicosTecnicos.Exceptions;

namespace Cenario03_EmpresaServicosTecnicos.Models;

public class Tecnico
{
    public string Nome { get; set; } = string.Empty;
    public string Especialidade { get; set; } = string.Empty;
    public bool Disponivel { get; set; } = true;

    public void ValidarDisponibilidade()
    {
        if (!Disponivel)
        {
            throw new TecnicoIndisponivelException("O tecnico informado esta indisponivel.");
        }
    }
}
