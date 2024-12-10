using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgendaFilm.View.Agendamento
{
    public partial class AgendarPage : Form
    {
        AgendamentoRepositorio repository = new AgendamentoRepositorio();
        Actions actions = new Actions();
        BindingList<Agendamentos> buscaAgendamentos = new BindingList<Agendamentos>();
        BindingList<Agendamentos> agendamentos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        DateTime dataHoraAgendamento;
        string observacoes;
        int id;


        public int clienteIdRecebido { get; set; }
        public int produtoIdRecebido { get; set; }
        public int veiculoIdRecebido { get; set; }

        public AgendarPage()
        {
            InitializeComponent();
            ObterDados();

        }

        public void ObterDados()
        {
            agendamentos = new BindingList<Agendamentos>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }


        public void AtualizarIdCliente(int clienteId)
        {
            clienteIdRecebido = clienteId;
        }

        public void AtualizarIdProduto(int produtoId)
        {
            produtoIdRecebido = produtoId;
        }

        public void AtualizarIdVeiculo(int veiculoId)
        {
            veiculoIdRecebido = veiculoId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgendarPage_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelecionarVeiculoAgenda novoFormulario = new SelecionarVeiculoAgenda(clienteIdRecebido, this);
            novoFormulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelecionarClienteAgenda novoFormulario = new SelecionarClienteAgenda(this);
            novoFormulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelecionarProdutoAgenda novoFormulario = new SelecionarProdutoAgenda(this);
            novoFormulario.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataHoraAgendamento = dateTimePicker1.Value;
            this.dataHoraAgendamento = dataHoraAgendamento;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            observacoes = txtObeservacoes.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbIdCliente.Text = "";
            lbNomeCliente.Text = "";
            lbIdProduto.Text = "";
            lbNomeProduto.Text = "";
            lbIdVeiculo.Text = "";
            lbPlacaVeiculo.Text = "";

            Agendamentos agendamento = new Agendamentos(id, clienteIdRecebido, veiculoIdRecebido, produtoIdRecebido, dataHoraAgendamento, observacoes, dataAtual, dataAtual, Global.funcionarioLogado);
            agendamentos.Add(agendamento);
            repository.Add(agendamento);

            id++;
        }
    }
}