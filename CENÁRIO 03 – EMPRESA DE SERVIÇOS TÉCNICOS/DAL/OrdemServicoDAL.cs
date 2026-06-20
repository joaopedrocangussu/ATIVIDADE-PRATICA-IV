using Cenario03_EmpresaServicosTecnicos.Models;
using Microsoft.Data.SqlClient;

namespace Cenario03_EmpresaServicosTecnicos.DAL;

public class OrdemServicoDAL
{
    private readonly Conexao conexao = new();

    public void Salvar(OrdemServico ordem)
    {
        const string sql = @"
            INSERT INTO OrdemServico
            (
                Cliente,
                TelefoneCliente,
                Tecnico,
                TipoServico,
                Descricao,
                ValorBase,
                ValorFinal,
                Status
            )
            VALUES
            (
                @Cliente,
                @TelefoneCliente,
                @Tecnico,
                @TipoServico,
                @Descricao,
                @ValorBase,
                @ValorFinal,
                @Status
            )";

        using SqlConnection conn = conexao.ObterConexao();
        conn.Open();

        using SqlCommand cmd = new(sql, conn);
        cmd.Parameters.AddWithValue("@Cliente", ordem.Cliente);
        cmd.Parameters.AddWithValue("@TelefoneCliente", ordem.TelefoneCliente);
        cmd.Parameters.AddWithValue("@Tecnico", ordem.Tecnico);
        cmd.Parameters.AddWithValue("@TipoServico", ordem.TipoServico);
        cmd.Parameters.AddWithValue("@Descricao", ordem.Descricao);
        cmd.Parameters.AddWithValue("@ValorBase", ordem.ValorBase);
        cmd.Parameters.AddWithValue("@ValorFinal", ordem.ValorFinal);
        cmd.Parameters.AddWithValue("@Status", ordem.Status);
        cmd.ExecuteNonQuery();
    }

    public List<OrdemServico> Listar()
    {
        List<OrdemServico> lista = [];

        const string sql = @"
            SELECT
                Id,
                Cliente,
                TelefoneCliente,
                Tecnico,
                TipoServico,
                Descricao,
                ValorBase,
                ValorFinal,
                Status
            FROM OrdemServico
            ORDER BY Id DESC";

        using SqlConnection conn = conexao.ObterConexao();
        conn.Open();

        using SqlCommand cmd = new(sql, conn);
        using SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            lista.Add(new OrdemServico
            {
                Id = Convert.ToInt32(dr["Id"]),
                Cliente = dr["Cliente"].ToString() ?? string.Empty,
                TelefoneCliente = dr["TelefoneCliente"].ToString() ?? string.Empty,
                Tecnico = dr["Tecnico"].ToString() ?? string.Empty,
                TipoServico = dr["TipoServico"].ToString() ?? string.Empty,
                Descricao = dr["Descricao"].ToString() ?? string.Empty,
                ValorBase = Convert.ToDecimal(dr["ValorBase"]),
                ValorFinal = Convert.ToDecimal(dr["ValorFinal"]),
                Status = dr["Status"].ToString() ?? string.Empty
            });
        }

        return lista;
    }
}
