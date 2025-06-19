using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using System;
using System.Windows.Forms;

namespace AgendaFilm.View.Agendamento
{
    public partial class AgendarPage : Form
    {
        private readonly AgendamentoRepositorio repository = new AgendamentoRepositorio();
        private readonly Actions actions = new Actions();
        private readonly DateTime dataAtual = DateTime.Today;
        private DateTime dataHoraAgendamento;
        private string observacoes;
        private int id;

        public event Action RefreshGrid;

        public int clienteIdRecebido { get; set; } = -1;
        public int veiculoIdRecebido { get; set; } = -1;

        public AgendarPage()
        {
            InitializeComponent();
            ObterDados();
        }

        public void ObterDados()
        {
            id = repository.getHighestId() + 1;
        }

        public void AtualizarIdCliente(int clienteId) => clienteIdRecebido = clienteId;
        public void AtualizarIdVeiculo(int veiculoId) => veiculoIdRecebido = veiculoId;

        private void AgendarPage_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new SelecionarVeiculoAgenda(clienteIdRecebido, this);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new SelecionarClienteAgenda(this);
            form.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataHoraAgendamento = dateTimePicker1.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            observacoes = txtObservacoes.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clienteIdRecebido == -1)
            {
                MessageBox.Show("Por favor, selecione um cliente antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (veiculoIdRecebido == -1)
            {
                MessageBox.Show("Por favor, selecione um veículo antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var novoAgendamento = new Agendamentos(
                id,
                clienteIdRecebido,
                veiculoIdRecebido,
                dataHoraAgendamento,
                observacoes,
                dataAtual,
                dataAtual,
                Global.funcionarioLogado
            );

            repository.Add(novoAgendamento);

            lbIdCliente.Text = string.Empty;
            lbNomeCliente.Text = string.Empty;
            lbIdVeiculo.Text = string.Empty;
            lbPlacaVeiculo.Text = string.Empty;
            txtObservacoes.Clear();

            id++;

            RefreshGrid?.Invoke();
            this.Close();
        }

        private void lbPlacaVeiculo_Click(object sender, EventArgs e)
        {
        }
    }
}
