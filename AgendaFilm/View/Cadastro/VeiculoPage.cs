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
using AgendaFilm.Model.DTOs;

namespace AgendaFilm.View
{
    public partial class VeiculoPage : Form
    {
        VeiculoRepositorio repository = new VeiculoRepositorio();
        Actions actions = new Actions();
        BindingList<VeiculoDTO> buscaVeiculos = new BindingList<VeiculoDTO>();
        BindingList<VeiculoDTO> veiculos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;
        public VeiculoPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = veiculos;
            EstiloDataGridView.AplicarEstiloPadrao(dataGridView1);
            ConfigurarColunasDataGridView();
        }

        public void ObterDados()
        {
            var veiculosOriginais = repository.GetAll();
            var clienteRepo = new ClienteRepositorio();
            var funcionarioRepo = new FuncionarioRepositorio();

            veiculos = new BindingList<VeiculoDTO>(
            veiculosOriginais
            .OrderBy(v => v.id)
            .Select(v => new VeiculoDTO
            {
                id = v.id,
                placa = v.placa,
                modelo = v.modelo,
                ano = v.ano,
                marca = v.marca,
                clienteNome = clienteRepo.getById(v.cliente_fk)?.nome ?? "Desconhecido",
                dataCriacao = v.dataCriacao,
                dataAlteracao = v.dataAlteracao
            }).ToList()
            );

            id = veiculosOriginais.Max(v => v.id) + 1;
        }
        private void AtualizarDataGridView()
        {
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = veiculos;
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

            if (colunas.Contains("placa"))
            {
                colunas["placa"].HeaderText = "Placa";
                colunas["placa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colunas["placa"].DisplayIndex = colunas["id"].DisplayIndex + 1;
            }

            if (colunas.Contains("modelo"))
            {
                colunas["modelo"].HeaderText = "Modelo";
                colunas["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            if (colunas.Contains("ano"))
            {
                colunas["ano"].HeaderText = "Ano";
                colunas["ano"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("marca"))
            {
                colunas["marca"].HeaderText = "Marca";
                colunas["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            if (colunas.Contains("dataAlteracao"))
            {
                colunas["dataAlteracao"].HeaderText = "Última Alteração";
                colunas["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                colunas["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("clienteNome"))
            {
                colunas["clienteNome"].HeaderText = "Dono";
                colunas["clienteNome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            if (colunas.Contains("dataCriacao"))
                colunas["dataCriacao"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroVeiculoPage novoFormulario = new CadastroVeiculoPage(); ;
            novoFormulario.RefreshGrid += AtualizarDataGridView;
            novoFormulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                VeiculoDTO veiculoSelecionadoDTO = row.DataBoundItem as VeiculoDTO;

                if (veiculoSelecionadoDTO == null)
                    return;

                var veiculoOriginal = repository.getById(veiculoSelecionadoDTO.id);
                if (veiculoOriginal == null)
                {
                    MessageBox.Show("Veículo não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK);
                    return;
                }

                EditarVeiculoPage editPage = new EditarVeiculoPage(veiculoOriginal);
                editPage.RefreshGrid += AtualizarDataGridView;
                editPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("É possível editar apenas um veículo por vez!", "Erro", MessageBoxButtons.OK);
            }

        }

        private void VeiculoPage_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você quer gerar o relatório em PDF?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes)
                return;
            var veiculosRelatorioDTO = new List<VeiculoDTO>();

            string pesquisa = RelatorioTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                veiculosRelatorioDTO = veiculos.ToList();
            }
            else
            {
                veiculosRelatorioDTO = veiculos
                    .Where(v => v.modelo.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            if (!veiculosRelatorioDTO.Any())
            {
                MessageBox.Show("Nenhum veículo encontrado com este modelo!", "Erro", MessageBoxButtons.OK);
                return;
            }

            var veiculosRelatorio = veiculosRelatorioDTO
                .Select(dto => repository.getById(dto.id))
                .Where(v => v != null)
                .ToList();

            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            string dataAtual = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            string titulo = $"Relatório De Veículo Por Modelo - {dataAtual}";
            string nomeArquivo = $"relatorio-Veiculos-Por-Modelo-{dataAtual}.pdf";
            string caminhoCompleto = Path.Combine(Path.GetTempPath(), nomeArquivo);

            var relatorio = new RelatorioVeiculos(veiculosRelatorio, titulo);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscaVeiculos.Clear();
            dataGridView1.DataSource = null;
            if (radioTodos.Checked)
            {
                dataGridView1.DataSource = veiculos;
                ConfigurarColunasDataGridView();
                return;
            }

            string termoBusca = textBoxPesquisar.Text.Trim();

            if (string.IsNullOrWhiteSpace(termoBusca))
            {
                MessageBox.Show("Você não digitou nenhum termo para ser pesquisado!", "Erro", MessageBoxButtons.OK);
                return;
            }

            bool veiculoExiste = false;

            if (radioModelo.Checked)
            {
                foreach (var veiculo in veiculos)
                {
                    if (veiculo.modelo.Contains(termoBusca, StringComparison.OrdinalIgnoreCase))
                    {
                        buscaVeiculos.Add(veiculo);
                        veiculoExiste = true;
                    }
                }

                if (!veiculoExiste)
                {
                    MessageBox.Show("Nenhum veículo encontrado com este modelo!", "Erro", MessageBoxButtons.OK);
                }
            }
            else if (radioId.Checked)
            {
                if (!int.TryParse(termoBusca, out int numId))
                {
                    MessageBox.Show("Você tem que digitar apenas números para pesquisar por ID", "Erro", MessageBoxButtons.OK);
                    return;
                }

                foreach (var veiculo in veiculos)
                {
                    if (veiculo.id == numId)
                    {
                        buscaVeiculos.Add(veiculo);
                        veiculoExiste = true;
                        break;
                    }
                }

                if (!veiculoExiste)
                {
                    MessageBox.Show("Veículo não cadastrado com esse ID", "Erro", MessageBoxButtons.OK);
                }
            }
            else if (radioPlaca.Checked)
            {
                foreach (var veiculo in veiculos)
                {
                    if (veiculo.placa.Contains(termoBusca, StringComparison.OrdinalIgnoreCase))
                    {
                        buscaVeiculos.Add(veiculo);
                        veiculoExiste = true;
                    }
                }

                if (!veiculoExiste)
                {
                    MessageBox.Show("Não há nenhum veículo com esta placa", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Marque uma das opções de busca!", "Erro", MessageBoxButtons.OK);
                return;
            }

            dataGridView1.DataSource = veiculoExiste ? buscaVeiculos : null;
            dataGridView1.Refresh();
            ConfigurarColunasDataGridView();
            textBoxPesquisar.Clear();
        }

        private void radioId_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.DarkSlateGray;  // Cor da borda
            int espessuraBorda = 8;
            int raio = 10;  // Raio do arredondamento

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Calcula espaço do texto
            Size textSize = TextRenderer.MeasureText(box.Text, box.Font);
            Rectangle rect = new Rectangle(0, textSize.Height / 2, box.Width - 1, box.Height - textSize.Height / 2 - 1);

            // Limpa o fundo para remover a borda padrão
            e.Graphics.Clear(box.BackColor);

            using (Pen pen = new Pen(corBorda, espessuraBorda))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Adiciona um retângulo com cantos arredondados ao caminho
                path.AddArc(rect.Left, rect.Top, raio, raio, 180, 90);
                path.AddArc(rect.Right - raio, rect.Top, raio, raio, 270, 90);
                path.AddArc(rect.Right - raio, rect.Bottom - raio, raio, raio, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - raio, raio, raio, 90, 90);
                path.CloseFigure();

                // Desenha a borda
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.DarkSlateGray;  // Cor da borda
            int espessuraBorda = 8;
            int raio = 10;  // Raio do arredondamento

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Calcula espaço do texto
            Size textSize = TextRenderer.MeasureText(box.Text, box.Font);
            Rectangle rect = new Rectangle(0, textSize.Height / 2, box.Width - 1, box.Height - textSize.Height / 2 - 1);

            // Limpa o fundo para remover a borda padrão
            e.Graphics.Clear(box.BackColor);

            using (Pen pen = new Pen(corBorda, espessuraBorda))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Adiciona um retângulo com cantos arredondados ao caminho
                path.AddArc(rect.Left, rect.Top, raio, raio, 180, 90);
                path.AddArc(rect.Right - raio, rect.Top, raio, raio, 270, 90);
                path.AddArc(rect.Right - raio, rect.Bottom - raio, raio, raio, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - raio, raio, raio, 90, 90);
                path.CloseFigure();

                // Desenha a borda
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void a(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                var veiculoSelecionadoDTO = row.DataBoundItem as VeiculoDTO;

                if (veiculoSelecionadoDTO == null)
                    return;

                var veiculoOriginal = repository.getById(veiculoSelecionadoDTO.id);
                if (veiculoOriginal == null)
                {
                    MessageBox.Show("Veículo não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK);
                    return;
                }

                if (repository.VeiculoTemRelacionamentos(veiculoOriginal.id))
                {
                    MessageBox.Show("Este veículo está vinculado a registros e não pode ser excluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("Deseja realmente excluir este veículo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    repository.RemoveVeiculo(veiculoOriginal);
                    AtualizarDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Selecione um veículo para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
