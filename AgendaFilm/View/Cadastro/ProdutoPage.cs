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

namespace AgendaFilm.View
{
    public partial class ProdutoPage : Form
    {
        ProdutoRepositorio repository = new ProdutoRepositorio();
        Actions actions = new Actions();
        BindingList<Produto> buscaProdutos = new BindingList<Produto>();
        BindingList<Produto> produtos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public ProdutoPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produtos;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["fornecedor_fk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["garantia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionario_fk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void AtualizarDataGridView()
        {
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produtos;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["fornecedor_fk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["garantia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionario_fk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void ObterDados()
        {
            produtos = new BindingList<Produto>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CadastroProdutoPage novoFormulario = new CadastroProdutoPage(); ;
            novoFormulario.RefreshGrid += AtualizarDataGridView;
            novoFormulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Produto produtoSelecionado = selectedRow.DataBoundItem as Produto;

                if (produtoSelecionado == null)
                {
                    MessageBox.Show("Erro ao tentar recuperar o produto selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EditarProdutoPage editarPage = new EditarProdutoPage(produtoSelecionado);
                editarPage.RefreshGrid += () =>
                {
                    int index = produtos.IndexOf(produtoSelecionado);

                    produtos[index] = repository.getById(produtoSelecionado.id);

                    dataGridView1.Refresh();
                };

                editarPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("É possível editar apenas um produto por vez!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        private void ProdutoPage_Load(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            FornecedorRepositorio repository = new FornecedorRepositorio();
            var fornecedores = repository.GetAll();

            DialogResult resultado = MessageBox.Show("Você quer gerar o relatório em PDF?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                bool produtoExiste = false;
                List<Produto> produtosRelatorio = new List<Produto>();
                string pesquisa = RelatorioTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    produtosRelatorio.AddRange(produtos);
                    produtoExiste = produtosRelatorio.Count > 0;
                }
                else
                {
                    foreach (var produto in produtos)
                    {
                        var fornecedor = fornecedores.FirstOrDefault(f => f.id == produto.fornecedor_fk);
                        if (fornecedor != null && fornecedor.nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            produtosRelatorio.Add(produto);
                            produtoExiste = true;
                        }
                    }
                }

                if (!produtoExiste)
                {
                    MessageBox.Show("Nenhum produto que tenha fornecedor com este nome!", "Erro", MessageBoxButtons.OK);
                    return;
                }

                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string dataAtual = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                string titulo = $"Relatório De Produtos Por Nome Do Fornecedor - {dataAtual}";
                string nomeArquivo = $"relatorio-Produtos-Por-Nome-Do-Fornecedor-{dataAtual}.pdf";

                string caminhoCompleto = Path.Combine(Path.GetTempPath(), nomeArquivo);
                var relatorio = new RelatorioProdutos(produtosRelatorio, titulo, fornecedores);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscaProdutos.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaProdutos;

            if (radioTodos.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = produtos;
            }
            else
            {
                if (!(string.IsNullOrWhiteSpace(textBoxPesquisar.Text)))
                {
                    if (radioNome.Checked)
                    {

                        bool produtoExiste = false;

                        foreach (var produto in produtos)
                        {
                            if (produto.nome.Contains(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaProdutos.Add(produto);

                                produtoExiste = true;
                            }
                        }

                        if (!produtoExiste)
                        {
                            MessageBox.Show("Produto não está cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioId.Checked)
                    {
                        bool produtoExiste = false;

                        try
                        {
                            int numId = int.Parse(textBoxPesquisar.Text);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Você tem que digitar apenas numeros", "Error", MessageBoxButtons.OK);
                            return;
                        }


                        foreach (var produto in produtos)
                        {
                            if (produto.id == int.Parse(textBoxPesquisar.Text))
                            {
                                buscaProdutos.Add(produto);

                                produtoExiste = true;
                            }
                        }

                        if (!produtoExiste)
                        {
                            MessageBox.Show("Produto não cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioFornecedor.Checked)
                    {
                        FornecedorRepositorio fornecedorRepositorio = new FornecedorRepositorio();
                        var fornecedores = fornecedorRepositorio.GetAll();
                        bool produtoExiste = false;

                        string nomeFornecedor = textBoxPesquisar.Text.Trim();

                        var fornecedoresEncontrados = fornecedores
                            .Where(f => f.nome.Contains(nomeFornecedor, StringComparison.OrdinalIgnoreCase))
                            .ToList();

                        foreach (var produto in produtos)
                        {
                            if (fornecedoresEncontrados.Any(f => f.id == produto.fornecedor_fk))
                            {
                                buscaProdutos.Add(produto);
                                produtoExiste = true;
                            }
                        }

                        if (!produtoExiste)
                        {
                            MessageBox.Show("Nenhum produto encontrado com fornecedor com esse nome", "Erro", MessageBoxButtons.OK);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Produto produtoSelecionado = selectedRow.DataBoundItem as Produto;

                if (produtoSelecionado == null)
                {
                    MessageBox.Show("Erro ao tentar recuperar o produto selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (repository.ProdutoTemRelacionamentos(produtoSelecionado.id))
                {
                    MessageBox.Show("Este produto está vinculado a uma ou mais ordens de serviço e não pode ser excluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmacao = MessageBox.Show(
                    $"Tem certeza que deseja excluir o produto '{produtoSelecionado.nome}'?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacao == DialogResult.No)
                    return;

                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    selectedRow = dataGridView1.SelectedRows[i];
                    produtoSelecionado = selectedRow.DataBoundItem as Produto;

                    if (produtoSelecionado != null)
                    {
                        produtos.Remove(produtoSelecionado);
                        buscaProdutos.Remove(produtoSelecionado);
                        repository.RemoveProduto(produtoSelecionado);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!", "Erro", MessageBoxButtons.OK);
            }
        }

    }
}
