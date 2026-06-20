namespace Cenario03_EmpresaServicosTecnicos.Models;

public class Manutencao : Servico
{
    public Manutencao(string descricao, decimal valorBase) : base(descricao, valorBase)
    {
    }

    public override string Executar()
    {
        return "Manutencao realizada com revisao, troca de pecas e teste final.";
    }

    public override decimal CalcularPreco()
    {
        return ValorBase + 65m;
    }
}
