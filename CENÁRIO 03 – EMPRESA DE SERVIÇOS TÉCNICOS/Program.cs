namespace Cenario03_EmpresaServicosTecnicos;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.ThreadException += (_, e) =>
        {
            MessageBox.Show(e.Exception.Message, "Erro no sistema");
        };

        AppDomain.CurrentDomain.UnhandledException += (_, e) =>
        {
            if (e.ExceptionObject is Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado");
            }
        };

        try
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao iniciar");
        }
    }
}
