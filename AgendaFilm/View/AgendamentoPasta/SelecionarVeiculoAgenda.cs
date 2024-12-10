using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaFilm.View.Agendamento
{
    public partial class SelecionarVeiculoAgenda : Form
    {
        private VeiculoRepositorio veiculoRepositorio = new VeiculoRepositorio();
        private AgendarPage agendaPage;
        private int clienteId;

        VeiculoRepositorio repository = new VeiculoRepositorio();
        Actions actions = new Actions();
        BindingList<Veiculo> buscaVeiculos = new BindingList<Veiculo>();
        BindingList<Veiculo> veiculos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public SelecionarVeiculoAgenda(int clienteId, AgendarPage mainform)
        {
            InitializeComponent();
            this.clienteId = clienteId;
            agendaPage = mainform;
        }

        public void ObterDados()
        {
            veiculos = new BindingList<Veiculo>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void SelecionarVeiculoAgenda_Load(object sender, EventArgs e)
        {
            var veiculosFiltrados = veiculoRepositorio.GetAll()
                .Where(v => v.cliente_fk == clienteId)
                .ToList();

            dataGridView1.DataSource = veiculosFiltrados;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int veiculoId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                agendaPage.lbIdVeiculo.Text = veiculoId.ToString();
                var placaVeiculo = repository.getPlacaById(veiculoId);
                agendaPage.lbPlacaVeiculo.Text = placaVeiculo;


                AgendarPage agendarPage = (AgendarPage)Application.OpenForms["AgendarPage"];

                if (agendarPage != null)
                {
                    agendarPage.veiculoIdRecebido = veiculoId;
                }
                else
                {
                    MessageBox.Show("A tela de destino não está aberta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
