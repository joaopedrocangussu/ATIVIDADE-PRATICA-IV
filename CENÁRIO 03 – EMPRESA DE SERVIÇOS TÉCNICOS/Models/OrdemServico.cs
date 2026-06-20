using Cenario03_EmpresaServicosTecnicos.Exceptions;

namespace Cenario03_EmpresaServicosTecnicos.Models;

public class OrdemServico
{
    public int Id { get; set; }
    public string Cliente { get; set; } = string.Empty;
    public string TelefoneCliente { get; set; } = string.Empty;
    public string Tecnico { get; set; } = string.Empty;
    public string TipoServico { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal ValorBase { get; set; }
    public decimal ValorFinal { get; set; }
    public string Status { get; set; } = "Criada";

    public void Abrir()
    {
        if (Status == "Finalizada")
        {
            throw new OrdemJaFinalizadaException("Nao e possivel abrir uma ordem ja finalizada.");
        }

        Status = "Aberta";
    }

    public void AtribuirTecnico(Tecnico tecnico)
    {
        if (Status == "Finalizada")
        {
            throw new OrdemJaFinalizadaException("Nao e possivel alterar uma ordem finalizada.");
        }

        tecnico.ValidarDisponibilidade();
        Tecnico = tecnico.Nome;
        Status = "Em atendimento";
    }

    public void Finalizar(Servico? servico)
    {
        if (Status == "Finalizada")
        {
            throw new OrdemJaFinalizadaException("A ordem ja esta finalizada.");
        }

        if (servico is null)
        {
            throw new ServicoInexistenteException("Selecione um tipo de servico valido.");
        }

        ValorFinal = CalcularValor(servico);
        Status = "Finalizada";
    }

    public decimal CalcularValor(Servico servico)
    {
        return servico.CalcularPreco();
    }
}
