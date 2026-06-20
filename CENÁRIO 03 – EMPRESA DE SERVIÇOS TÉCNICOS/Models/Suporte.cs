namespace Cenario03_EmpresaServicosTecnicos.Models;

public class Suporte : Servico
{
    public Suporte(string descricao, decimal valorBase) : base(descricao, valorBase)
    {
    }

    public override string Executar()
    {
        return "Suporte prestado com diagnostico e orientacao ao cliente.";
    }

    public override decimal CalcularPreco()
    {
        return ValorBase + 40m;
    }
}
