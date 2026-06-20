namespace Cenario03_EmpresaServicosTecnicos;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblCliente = new Label();
        txtCliente = new TextBox();
        lblTelefone = new Label();
        txtTelefone = new TextBox();
        lblTecnico = new Label();
        txtTecnico = new TextBox();
        lblTipoServico = new Label();
        cmbTipoServico = new ComboBox();
        lblDescricao = new Label();
        txtDescricao = new TextBox();
        lblValorBase = new Label();
        nudValorBase = new NumericUpDown();
        btnSalvar = new Button();
        dgvOrdens = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)nudValorBase).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvOrdens).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.Location = new Point(24, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(617, 41);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "CENÁRIO 03 – EMPRESA DE SERVIÇOS TÉCNICOS";
        // 
        // lblCliente
        // 
        lblCliente.AutoSize = true;
        lblCliente.Location = new Point(28, 85);
        lblCliente.Name = "lblCliente";
        lblCliente.Size = new Size(58, 20);
        lblCliente.TabIndex = 1;
        lblCliente.Text = "Cliente";
        // 
        // txtCliente
        // 
        txtCliente.Location = new Point(28, 108);
        txtCliente.Name = "txtCliente";
        txtCliente.Size = new Size(330, 27);
        txtCliente.TabIndex = 2;
        // 
        // lblTelefone
        // 
        lblTelefone.AutoSize = true;
        lblTelefone.Location = new Point(378, 85);
        lblTelefone.Name = "lblTelefone";
        lblTelefone.Size = new Size(66, 20);
        lblTelefone.TabIndex = 3;
        lblTelefone.Text = "Telefone";
        // 
        // txtTelefone
        // 
        txtTelefone.Location = new Point(378, 108);
        txtTelefone.Name = "txtTelefone";
        txtTelefone.Size = new Size(220, 27);
        txtTelefone.TabIndex = 4;
        // 
        // lblTecnico
        // 
        lblTecnico.AutoSize = true;
        lblTecnico.Location = new Point(618, 85);
        lblTecnico.Name = "lblTecnico";
        lblTecnico.Size = new Size(60, 20);
        lblTecnico.TabIndex = 5;
        lblTecnico.Text = "Tecnico";
        // 
        // txtTecnico
        // 
        txtTecnico.Location = new Point(618, 108);
        txtTecnico.Name = "txtTecnico";
        txtTecnico.Size = new Size(270, 27);
        txtTecnico.TabIndex = 6;
        // 
        // lblTipoServico
        // 
        lblTipoServico.AutoSize = true;
        lblTipoServico.Location = new Point(28, 157);
        lblTipoServico.Name = "lblTipoServico";
        lblTipoServico.Size = new Size(112, 20);
        lblTipoServico.TabIndex = 7;
        lblTipoServico.Text = "Tipo de servico";
        // 
        // cmbTipoServico
        // 
        cmbTipoServico.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipoServico.FormattingEnabled = true;
        cmbTipoServico.Location = new Point(28, 180);
        cmbTipoServico.Name = "cmbTipoServico";
        cmbTipoServico.Size = new Size(220, 28);
        cmbTipoServico.TabIndex = 8;
        // 
        // lblDescricao
        // 
        lblDescricao.AutoSize = true;
        lblDescricao.Location = new Point(268, 157);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Size = new Size(74, 20);
        lblDescricao.TabIndex = 9;
        lblDescricao.Text = "Descricao";
        // 
        // txtDescricao
        // 
        txtDescricao.Location = new Point(268, 180);
        txtDescricao.Name = "txtDescricao";
        txtDescricao.Size = new Size(430, 27);
        txtDescricao.TabIndex = 10;
        // 
        // lblValorBase
        // 
        lblValorBase.AutoSize = true;
        lblValorBase.Location = new Point(718, 157);
        lblValorBase.Name = "lblValorBase";
        lblValorBase.Size = new Size(77, 20);
        lblValorBase.TabIndex = 11;
        lblValorBase.Text = "Valor base";
        // 
        // nudValorBase
        // 
        nudValorBase.DecimalPlaces = 2;
        nudValorBase.Location = new Point(718, 180);
        nudValorBase.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nudValorBase.Name = "nudValorBase";
        nudValorBase.Size = new Size(170, 27);
        nudValorBase.TabIndex = 12;
        nudValorBase.TextAlign = HorizontalAlignment.Right;
        // 
        // btnSalvar
        // 
        btnSalvar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnSalvar.Location = new Point(718, 228);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(170, 42);
        btnSalvar.TabIndex = 13;
        btnSalvar.Text = "Salvar ordem";
        btnSalvar.UseVisualStyleBackColor = true;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // dgvOrdens
        // 
        dgvOrdens.AllowUserToAddRows = false;
        dgvOrdens.AllowUserToDeleteRows = false;
        dgvOrdens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOrdens.BackgroundColor = SystemColors.ControlLightLight;
        dgvOrdens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvOrdens.Location = new Point(28, 292);
        dgvOrdens.Name = "dgvOrdens";
        dgvOrdens.ReadOnly = true;
        dgvOrdens.RowHeadersWidth = 51;
        dgvOrdens.Size = new Size(860, 250);
        dgvOrdens.TabIndex = 14;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(924, 573);
        Controls.Add(dgvOrdens);
        Controls.Add(btnSalvar);
        Controls.Add(nudValorBase);
        Controls.Add(lblValorBase);
        Controls.Add(txtDescricao);
        Controls.Add(lblDescricao);
        Controls.Add(cmbTipoServico);
        Controls.Add(lblTipoServico);
        Controls.Add(txtTecnico);
        Controls.Add(lblTecnico);
        Controls.Add(txtTelefone);
        Controls.Add(lblTelefone);
        Controls.Add(txtCliente);
        Controls.Add(lblCliente);
        Controls.Add(lblTitulo);
        Name = "Form1";
        Text = "CENÁRIO 03 – EMPRESA DE SERVIÇOS TÉCNICOS";
        ((System.ComponentModel.ISupportInitialize)nudValorBase).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvOrdens).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private Label lblCliente;
    private TextBox txtCliente;
    private Label lblTelefone;
    private TextBox txtTelefone;
    private Label lblTecnico;
    private TextBox txtTecnico;
    private Label lblTipoServico;
    private ComboBox cmbTipoServico;
    private Label lblDescricao;
    private TextBox txtDescricao;
    private Label lblValorBase;
    private NumericUpDown nudValorBase;
    private Button btnSalvar;
    private DataGridView dgvOrdens;
}
