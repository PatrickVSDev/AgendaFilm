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

namespace AgendaFilm.View.Agendamento
{
    public partial class AgendarPage : Form
    {
        AgendamentoRepositorio repository = new AgendamentoRepositorio();
        Actions actions = new Actions();
        BindingList<dynamic> buscaAgendamentos = new BindingList<dynamic>();
        BindingList<dynamic> agendamentos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        DateTime dataHoraAgendamento;
        string observacoes;
        int id;

        public event Action RefreshGrid;

        public int clienteIdRecebido { get; set; } = -1;
        public int produtoIdRecebido { get; set; } = -1;
        public int veiculoIdRecebido { get; set; } = -1;

        public AgendarPage()
        {
            InitializeComponent();
            ObterDados();
        }

        public void ObterDados()
        {
            agendamentos = new BindingList<dynamic>(repository.getAll());
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

        private void AgendarPage_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Value = DateTime.Now;
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

            if (produtoIdRecebido == -1)
            {
                MessageBox.Show("Por favor, selecione um produto antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbIdCliente.Text = null;
            lbNomeCliente.Text = null;
            lbIdProduto.Text = null;
            lbNomeProduto.Text = null;
            lbIdVeiculo.Text = null;
            lbPlacaVeiculo.Text = null;

            Agendamentos agendamento = new Agendamentos(id, clienteIdRecebido, veiculoIdRecebido, produtoIdRecebido, dataHoraAgendamento, observacoes, dataAtual, dataAtual, Global.funcionarioLogado);
            agendamentos.Add(agendamento);
            repository.Add(agendamento);

            id++;
            txtObservacoes.Clear();

            RefreshGrid?.Invoke();
            this.Close();
        }
    }
}