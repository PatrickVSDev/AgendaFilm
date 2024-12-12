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

namespace AgendaFilm.View
{
    public partial class VeiculoPage : Form
    {
        VeiculoRepositorio repository = new VeiculoRepositorio();
        Actions actions = new Actions();
        BindingList<Veiculo> buscaVeiculos = new BindingList<Veiculo>();
        BindingList<Veiculo> veiculos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;
        public VeiculoPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = veiculos;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["placa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ano"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionario_fk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["cliente_fk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void ObterDados()
        {
            veiculos = new BindingList<Veiculo>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroVeiculoPage novoFormulario = new CadastroVeiculoPage(); ;
            novoFormulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditarVeiculoPage novoFormulario = new EditarVeiculoPage(); ;
            novoFormulario.ShowDialog();
        }

        private void VeiculoPage_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você quer gerar o relatorio em PDF?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                bool veiculoExiste = false;
                List<Veiculo> veiculosRelatorio = new List<Veiculo>();

                string pesquisa = RelatorioTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    foreach (var veiculo in veiculos)
                    {
                        veiculosRelatorio.Add(veiculo);
                        veiculoExiste = true;
                    }
                }
                else
                {
                    foreach (var veiculo in veiculos)
                    {
                        if (veiculo.modelo.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            veiculosRelatorio.Add(veiculo);
                            veiculoExiste = true;
                        }
                    }
                }

                if (!veiculoExiste)
                {
                    MessageBox.Show("Nenhum produto com este nome!", "Error", MessageBoxButtons.OK);
                }



                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string dataAtual = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                string titulo = $"Relatório De Veículo Por Modelo - {dataAtual}";

                string diretorio = @"C:\Users\patri\OneDrive\Área de Trabalho\Relatórios";
                if (!Directory.Exists(diretorio))
                {
                    MessageBox.Show("Diretorio Incorreto, verificar!", "Error", MessageBoxButtons.OK);
                    return;
                }

                string nomeArquivo = Path.Combine(diretorio, $"relatorio-Veiculos-Por-Modelo-{dataAtual}.pdf");

                var relatorio = new RelatorioVeiculos(veiculosRelatorio, titulo);
                relatorio.GeneratePdf(nomeArquivo);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
