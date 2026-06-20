using Cenario03_EmpresaServicosTecnicos.DAL;
using Cenario03_EmpresaServicosTecnicos.Models;

namespace Cenario03_EmpresaServicosTecnicos;

public partial class Form1 : Form
{
    private readonly OrdemServicoDAL ordemServicoDAL = new();

    public Form1()
    {
        InitializeComponent();
        ConfigurarFormulario();
        CarregarOrdens();
    }

    private void ConfigurarFormulario()
    {
        cmbTipoServico.Items.Add("Manutencao");
        cmbTipoServico.Items.Add("Instalacao");
        cmbTipoServico.Items.Add("Suporte");
        cmbTipoServico.SelectedIndex = 0;

        nudValorBase.DecimalPlaces = 2;
        nudValorBase.Minimum = 0;
        nudValorBase.Maximum = 100000;
        nudValorBase.ThousandsSeparator = true;
        nudValorBase.TextAlign = HorizontalAlignment.Right;
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            Servico servico = CriarServico();

            var cliente = new Cliente
            {
                Nome = txtCliente.Text.Trim(),
                Telefone = txtTelefone.Text.Trim()
            };

            var tecnico = new Tecnico
            {
                Nome = txtTecnico.Text.Trim(),
                Especialidade = cmbTipoServico.Text
            };

            var ordem = new OrdemServico
            {
                Cliente = cliente.Nome,
                TelefoneCliente = cliente.Telefone,
                TipoServico = cmbTipoServico.Text,
                Descricao = txtDescricao.Text.Trim(),
                ValorBase = nudValorBase.Value
            };

            ValidarCampos(ordem, cliente, tecnico);

            ordem.Abrir();
            ordem.AtribuirTecnico(tecnico);
            ordem.Finalizar(servico);

            ordemServicoDAL.Salvar(ordem);
            CarregarOrdens();
            LimparCampos();

            MessageBox.Show(servico.Executar(), "Ordem finalizada");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Atencao");
        }
    }

    private Servico CriarServico()
    {
        string descricao = txtDescricao.Text.Trim();
        decimal valorBase = nudValorBase.Value;

        return cmbTipoServico.Text switch
        {
            "Manutencao" => new Manutencao(descricao, valorBase),
            "Instalacao" => new Instalacao(descricao, valorBase),
            "Suporte" => new Suporte(descricao, valorBase),
            _ => throw new Exception("Tipo de servico invalido.")
        };
    }

    private static void ValidarCampos(OrdemServico ordem, Cliente cliente, Tecnico tecnico)
    {
        if (string.IsNullOrWhiteSpace(cliente.Nome))
        {
            throw new Exception("Informe o nome do cliente.");
        }

        if (string.IsNullOrWhiteSpace(tecnico.Nome))
        {
            throw new Exception("Informe o nome do tecnico.");
        }

        if (string.IsNullOrWhiteSpace(ordem.Descricao))
        {
            throw new Exception("Informe a descricao do servico.");
        }
    }

    private void CarregarOrdens()
    {
        try
        {
            dgvOrdens.DataSource = ordemServicoDAL.Listar();
        }
        catch
        {
            dgvOrdens.DataSource = null;
        }
    }

    private void LimparCampos()
    {
        txtCliente.Clear();
        txtTelefone.Clear();
        txtTecnico.Clear();
        txtDescricao.Clear();
        nudValorBase.Value = 0;
        cmbTipoServico.SelectedIndex = 0;
        txtCliente.Focus();
    }
}
