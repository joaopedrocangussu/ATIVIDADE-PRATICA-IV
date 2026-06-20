namespace Cenario03_EmpresaServicosTecnicos.Models;

public class Instalacao : Servico
{
    public Instalacao(string descricao, decimal valorBase) : base(descricao, valorBase)
    {
    }

    public override string Executar()
    {
        return "Instalacao concluida com configuracao e teste de funcionamento.";
    }

    public override decimal CalcularPreco()
    {
        return ValorBase + 95m;
    }
}
