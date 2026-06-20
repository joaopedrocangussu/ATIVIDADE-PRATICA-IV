using Microsoft.Data.SqlClient;

namespace Cenario03_EmpresaServicosTecnicos.DAL;

public class Conexao
{
    private readonly string connectionString =
        @"Server=(localdb)\MSSQLLocalDB;Database=ServicosTecnicosJP;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }
}
