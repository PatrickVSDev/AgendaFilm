﻿using AgendaFilm.Controller;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
using AgendaFilm.View.Cadastro.Cadastrar;
using AgendaFilm.View.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Fluent;
using System.Globalization;
using AgendaFilm.Utils;

namespace AgendaFilm.View.Cadastro
{
    public partial class FornecedorPage : Form
    {
        FornecedorRepositorio repository = new FornecedorRepositorio();
        Actions actions = new Actions();
        BindingList<Fornecedor> buscaFornecedores = new BindingList<Fornecedor>();
        BindingList<Fornecedor> fornecedores;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public FornecedorPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = fornecedores;
            EstiloDataGridView.AplicarEstiloPadrao(dataGridView1);
            ConfigurarColunasDataGridView();
        }

        public void ObterDados()
        {
            fornecedores = new BindingList<Fornecedor>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void AtualizarDataGridView()
        {
            ObterDados();
            ConfigurarColunasDataGridView();
        }

        private void ConfigurarColunasDataGridView()
        {
            var colunas = dataGridView1.Columns;

            if (colunas.Contains("id"))
            {
                colunas["id"].HeaderText = "ID";
                colunas["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colunas["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (colunas.Contains("nome"))
            {
                colunas["nome"].HeaderText = "Nome";
                colunas["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colunas["nome"].DisplayIndex = colunas["id"].DisplayIndex + 1;
            }

            if (colunas.Contains("documento"))
            {
                colunas["documento"].HeaderText = "Documento";
                colunas["documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("telefone"))
            {
                colunas["telefone"].HeaderText = "Telefone";
                colunas["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("email"))
            {
                colunas["email"].HeaderText = "Email";
                colunas["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            if (colunas.Contains("dataAlteracao"))
            {
                colunas["dataAlteracao"].HeaderText = "Última Alteração";
                colunas["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                colunas["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("dataCriacao"))
                colunas["dataCriacao"].Visible = false;
            if (colunas.Contains("funcionario_fk"))
                colunas["funcionario_fk"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroFornecedorPage novoFormulario = new CadastroFornecedorPage(); ;
            novoFormulario.RefreshGrid += AtualizarDataGridView;
            novoFormulario.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.DarkSlateGray;
            int espessuraBorda = 8;
            int raio = 10;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Size textSize = TextRenderer.MeasureText(box.Text, box.Font);
            Rectangle rect = new Rectangle(0, textSize.Height / 2, box.Width - 1, box.Height - textSize.Height / 2 - 1);

            e.Graphics.Clear(box.BackColor);

            using (Pen pen = new Pen(corBorda, espessuraBorda))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.Left, rect.Top, raio, raio, 180, 90);
                path.AddArc(rect.Right - raio, rect.Top, raio, raio, 270, 90);
                path.AddArc(rect.Right - raio, rect.Bottom - raio, raio, raio, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - raio, raio, raio, 90, 90);
                path.CloseFigure();

                e.Graphics.DrawPath(pen, path);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                Fornecedor forncedorSelecionado = dataGridViewRow.DataBoundItem as Fornecedor;

                EditarFornecedorPage editPage = new EditarFornecedorPage(forncedorSelecionado);
                int index = fornecedores.IndexOf(forncedorSelecionado);
                editPage.RefreshGrid += AtualizarDataGridView;
                editPage.ShowDialog();


                if (editPage.DialogResult == DialogResult.OK)
                {
                    fornecedores[index] = editPage.fornecedor;
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("É possivel editar apenas um fornecedor por vez!", "Error", MessageBoxButtons.OK);
            }
        }

        private void FornecedorPage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscaFornecedores.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaFornecedores;

            if (radioTodos.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = fornecedores;
                ConfigurarColunasDataGridView();
            }
            else
            {
                if (!(string.IsNullOrWhiteSpace(textBoxPesquisar.Text)))
                {
                    if (radioNome.Checked)
                    {

                        bool clienteExiste = false;

                        foreach (var cliente in fornecedores)
                        {
                            if (cliente.nome.Contains(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaFornecedores.Add(cliente);

                                clienteExiste = true;
                            }
                        }

                        if (!clienteExiste)
                        {
                            MessageBox.Show("Fornecedor não está cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioId.Checked)
                    {
                        bool clienteExiste = false;

                        try
                        {
                            int numId = int.Parse(textBoxPesquisar.Text);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Você tem que digitar apenas numeros", "Error", MessageBoxButtons.OK);
                            return;
                        }


                        foreach (var fornecedor in fornecedores)
                        {
                            if (fornecedor.id == int.Parse(textBoxPesquisar.Text))
                            {
                                buscaFornecedores.Add(fornecedor);

                                clienteExiste = true;
                            }
                        }

                        if (!clienteExiste)
                        {
                            MessageBox.Show("Fornecedor não cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioTelefone.Checked)
                    {
                        bool fornecedorExiste = false;

                        foreach (var fornecedor in fornecedores)
                        {
                            if (fornecedor.telefone.Contains(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaFornecedores.Add(fornecedor);

                                fornecedorExiste = true;
                            }
                        }

                        if (!fornecedorExiste)
                        {
                            MessageBox.Show("Não há nenhum fornecedor com este telefone", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Marque uma das opções de busca!", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Você não digitou nenhum termo para ser pesquisado!", "Error", MessageBoxButtons.OK);
                }
            }
            textBoxPesquisar.Clear();
            ConfigurarColunasDataGridView();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.DarkSlateGray;
            int espessuraBorda = 8;
            int raio = 10;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Size textSize = TextRenderer.MeasureText(box.Text, box.Font);
            Rectangle rect = new Rectangle(0, textSize.Height / 2, box.Width - 1, box.Height - textSize.Height / 2 - 1);

            e.Graphics.Clear(box.BackColor);

            using (Pen pen = new Pen(corBorda, espessuraBorda))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.Left, rect.Top, raio, raio, 180, 90);
                path.AddArc(rect.Right - raio, rect.Top, raio, raio, 270, 90);
                path.AddArc(rect.Right - raio, rect.Bottom - raio, raio, raio, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - raio, raio, raio, 90, 90);
                path.CloseFigure();

                e.Graphics.DrawPath(pen, path);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                Fornecedor fornecedorSelecionado = dataGridViewRow.DataBoundItem as Fornecedor;

                if (fornecedorSelecionado == null)
                {
                    MessageBox.Show("Erro ao tentar recuperar o fornecedor selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (repository.FornecedorTemRelacionamentos(fornecedorSelecionado.id))
                {
                    MessageBox.Show("Este fornecedor possui produtos vinculados e não pode ser excluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmacao = MessageBox.Show(
                    $"Tem certeza que deseja excluir o fornecedor '{fornecedorSelecionado.nome}'?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacao == DialogResult.No)
                    return;

                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dataGridViewRow = dataGridView1.SelectedRows[i];
                    fornecedorSelecionado = dataGridViewRow.DataBoundItem as Fornecedor;

                    if (fornecedorSelecionado != null)
                    {
                        fornecedores.Remove(fornecedorSelecionado);
                        buscaFornecedores.Remove(fornecedorSelecionado);
                        repository.RemoveFornecedor(fornecedorSelecionado);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum fornecedor selecionado!", "Erro", MessageBoxButtons.OK);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você quer gerar o relatorio em PDF?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                bool fornecedorExiste = false;
                List<Fornecedor> fornecedoresRelatorio = new List<Fornecedor>();

                string pesquisa = RelatorioTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    fornecedoresRelatorio.AddRange(fornecedores);
                    fornecedorExiste = fornecedoresRelatorio.Count > 0;
                }
                else
                {
                    foreach (var fornecedor in fornecedores)
                    {
                        if (fornecedor.nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            fornecedoresRelatorio.Add(fornecedor);
                            fornecedorExiste = true;
                        }
                    }
                }

                if (!fornecedorExiste)
                {
                    MessageBox.Show("Nenhum fornecedor com este nome!", "Error", MessageBoxButtons.OK);
                    return;
                }

                var funcionarioRepo = new FuncionarioRepositorio();
                var funcionarios = funcionarioRepo.GetAll();

                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string dataAtual = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                string titulo = $"Relatório De Fornecedores Por Nome - {dataAtual}";
                string nomeArquivo = $"relatorio-Fornecedores-Por-Nome-{dataAtual}.pdf";

                string tempFolder = Path.GetTempPath();
                string caminhoCompleto = Path.Combine(tempFolder, nomeArquivo);

                var relatorio = new RelatorioFornecedores(fornecedoresRelatorio, titulo, funcionarios);
                relatorio.GeneratePdf(caminhoCompleto);

                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = caminhoCompleto,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Relatório gerado, mas não foi possível abrir automaticamente.\n{ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
