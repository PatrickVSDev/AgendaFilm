using AgendaFilm.Controller;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
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
    public partial class AgendamentoPage : Form
    {
        AgendamentoRepositorio repository = new AgendamentoRepositorio();
        Actions actions = new Actions();
        BindingList<dynamic> buscaAgendamentos = new BindingList<dynamic>();
        BindingList<dynamic> agendamentos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public AgendamentoPage()
        {
            InitializeComponent();
            ObterDados();
            ConfigurarDataGridView();
        }

        public void ObterDados()
        {
            agendamentos = new BindingList<dynamic>(repository.getAll());
            id = repository.getHighestId() + 1;
        }

        private void AtualizarDataGridView()
        {
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = agendamentos;

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["nome_cliente"].HeaderText = "Cliente";
            dataGridView1.Columns["placa_veiculo"].HeaderText = "Veículo";
            dataGridView1.Columns["nome_produto"].HeaderText = "Produto";
            dataGridView1.Columns["dataHoraAgendamento"].HeaderText = "Data/Hora";
            dataGridView1.Columns["observacoes"].HeaderText = "Observações";
            dataGridView1.Columns["dataCriacao"].HeaderText = "Data Criação";
            dataGridView1.Columns["dataAlteracao"].HeaderText = "Última Alteração";
            dataGridView1.Columns["nome_funcionario"].HeaderText = "Funcionário";

            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = agendamentos;

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["nome_cliente"].HeaderText = "Cliente";
            dataGridView1.Columns["placa_veiculo"].HeaderText = "Veículo";
            dataGridView1.Columns["nome_produto"].HeaderText = "Produto";
            dataGridView1.Columns["dataHoraAgendamento"].HeaderText = "Data/Hora";
            dataGridView1.Columns["observacoes"].HeaderText = "Observações";
            dataGridView1.Columns["dataCriacao"].HeaderText = "Data Criação";
            dataGridView1.Columns["dataAlteracao"].HeaderText = "Última Alteração";
            dataGridView1.Columns["nome_funcionario"].HeaderText = "Funcionário";

            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.ValueType == typeof(string))
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                else
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgendarPage novoFormulario = new AgendarPage();
            novoFormulario.RefreshGrid += AtualizarDataGridView;
            novoFormulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    var dataGridViewRow = dataGridView1.SelectedRows[i];
                    var agendamentoSelecionado = dataGridViewRow.DataBoundItem as dynamic;

                    if (agendamentoSelecionado != null)
                    {
                        agendamentos.Remove(agendamentoSelecionado);
                        buscaAgendamentos.Remove(agendamentoSelecionado);
                        repository.RemoveAgendamento(agendamentoSelecionado.id);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum agendamento selecionado", "Error", MessageBoxButtons.OK);
            }
        }

        private void AgendamentoPage_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}