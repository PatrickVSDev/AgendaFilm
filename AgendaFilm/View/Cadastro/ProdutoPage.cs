using AgendaFilm.Controller;
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
using AgendaFilm.Model.DTO;

namespace AgendaFilm.View
{
    public partial class ProdutoPage : Form
    {
        ProdutoRepositorio repository = new ProdutoRepositorio();
        Actions actions = new Actions();
        BindingList<ProdutoDTO> buscaProdutos = new BindingList<ProdutoDTO>();
        BindingList<ProdutoDTO> produtos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public ProdutoPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produtos;
            EstiloDataGridView.AplicarEstiloPadrao(dataGridView1);
            ConfigurarColunasDataGridView();
        }

        private void AtualizarDataGridView()
        {
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produtos;
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

            if (colunas.Contains("marca"))
            {
                colunas["marca"].HeaderText = "Marca";
                colunas["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            if (colunas.Contains("garantia"))
            {
                colunas["garantia"].HeaderText = "Garantia";
                colunas["garantia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("fornecedorNome"))
            {
                colunas["fornecedorNome"].HeaderText = "Fornecedor";
                colunas["fornecedorNome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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
            if (colunas.Contains("funcionarioNome"))
                colunas["funcionarioNome"].Visible = false;
        }

        public void ObterDados()
        {
            var fornecedorRepo = new FornecedorRepositorio();
            var fornecedores = fornecedorRepo.GetAll();

            var funcionarioRepo = new FuncionarioRepositorio();
            var funcionarios = funcionarioRepo.GetAll();

            var produtosOriginais = repository.GetAll();

            produtos = new BindingList<ProdutoDTO>(
                produtosOriginais
                .OrderBy(p => p.id)
                .Select(p => new ProdutoDTO
                {
                    id = p.id,
                    nome = p.nome,
                    marca = p.marca,
                    garantia = p.garantia,
                    fornecedorNome = fornecedores.FirstOrDefault(f => f.id == p.fornecedor_fk)?.nome ?? "Desconhecido",
                    funcionarioNome = funcionarios.FirstOrDefault(f => f.id == p.funcionario_fk)?.nome ?? "Desconhecido",
                    dataCriacao = p.dataCriacao,
                    dataAlteracao = p.dataAlteracao,
                    funcionario_fk = p.funcionario_fk
                }).ToList()
            );

            id = produtosOriginais.Any() ? produtosOriginais.Max(p => p.id) + 1 : 1;
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
                var dto = dataGridView1.SelectedRows[0].DataBoundItem as ProdutoDTO;

                if (dto == null)
                {
                    MessageBox.Show("Erro ao tentar recuperar o produto.", "Erro", MessageBoxButtons.OK);
                    return;
                }

                var produto = repository.getById(dto.id);
                if (produto == null)
                {
                    MessageBox.Show("Produto não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK);
                    return;
                }

                var editarPage = new EditarProdutoPage(produto);
                editarPage.RefreshGrid += AtualizarDataGridView;
                editarPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione apenas um produto!", "Erro", MessageBoxButtons.OK);
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
            var fornecedorRepositorio = new FornecedorRepositorio();
            var fornecedores = fornecedorRepositorio.GetAll().ToList();

            var funcionarioRepositorio = new FuncionarioRepositorio();
            var funcionarios = funcionarioRepositorio.GetAll().ToList();

            var produtoRepositorio = new ProdutoRepositorio();

            DialogResult resultado = MessageBox.Show("Você quer gerar o relatório em PDF?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                bool produtoExiste = false;
                List<Produto> produtosRelatorio = new List<Produto>();
                string pesquisa = RelatorioTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    produtosRelatorio.AddRange(produtos.Select(p => produtoRepositorio.getById(p.id)));
                    produtoExiste = produtosRelatorio.Count > 0;
                }
                else
                {
                    foreach (var dto in produtos)
                    {
                        if (dto.fornecedorNome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            var produto = produtoRepositorio.getById(dto.id);
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
                var relatorio = new RelatorioProdutos(produtosRelatorio, titulo, fornecedores, funcionarios);
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

            if (radioTodos.Checked)
            {
                dataGridView1.DataSource = produtos;
                ConfigurarColunasDataGridView();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPesquisar.Text))
            {
                MessageBox.Show("Você não digitou nenhum termo para ser pesquisado!", "Erro", MessageBoxButtons.OK);
                return;
            }

            string termo = textBoxPesquisar.Text.Trim();
            bool encontrou = false;

            if (radioNome.Checked)
            {
                foreach (var p in produtos)
                {
                    if (p.nome.Contains(termo, StringComparison.OrdinalIgnoreCase))
                    {
                        buscaProdutos.Add(p);
                        encontrou = true;
                    }
                }
            }
            else if (radioId.Checked)
            {
                if (!int.TryParse(termo, out int idBusca))
                {
                    MessageBox.Show("Digite um número válido para o ID.", "Erro", MessageBoxButtons.OK);
                    return;
                }

                foreach (var p in produtos)
                {
                    if (p.id == idBusca)
                    {
                        buscaProdutos.Add(p);
                        encontrou = true;
                        break;
                    }
                }
            }
            else if (radioFornecedor.Checked)
            {
                foreach (var p in produtos)
                {
                    if (p.fornecedorNome.Contains(termo, StringComparison.OrdinalIgnoreCase))
                    {
                        buscaProdutos.Add(p);
                        encontrou = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um tipo de busca!", "Erro", MessageBoxButtons.OK);
                return;
            }

            if (!encontrou)
            {
                MessageBox.Show("Nenhum produto encontrado!", "Aviso", MessageBoxButtons.OK);
            }

            dataGridView1.DataSource = buscaProdutos;
            ConfigurarColunasDataGridView();
            textBoxPesquisar.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                ProdutoDTO dto = selectedRow.DataBoundItem as ProdutoDTO;

                if (dto == null)
                {
                    MessageBox.Show("Erro ao tentar recuperar o produto selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Produto produtoSelecionado = repository.getById(dto.id);


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
                    dto = selectedRow.DataBoundItem as ProdutoDTO;

                    if (dto != null)
                    {
                        var produto = repository.getById(dto.id);

                        produtos.Remove(dto);
                        buscaProdutos.Remove(dto);
                        repository.RemoveProduto(produto);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!", "Erro", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
