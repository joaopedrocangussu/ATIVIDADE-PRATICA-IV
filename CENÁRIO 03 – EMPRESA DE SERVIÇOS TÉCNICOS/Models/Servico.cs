using Cenario03_EmpresaServicosTecnicos.Exceptions;
using Cenario03_EmpresaServicosTecnicos.Interfaces;

namespace Cenario03_EmpresaServicosTecnicos.Models;

public abstract class Servico : IExecutavel
{
    public string Descricao { get; }
    public decimal ValorBase { get; }

    protected Servico(string descricao, decimal valorBase)
    {
        if (valorBase <= 0)
        {
            throw new ValorInvalidoException("O valor base do servico deve ser maior que zero.");
        }

        Descricao = descricao;
        ValorBase = valorBase;
    }

    public abstract string Executar();
    public abstract decimal CalcularPreco();
}
