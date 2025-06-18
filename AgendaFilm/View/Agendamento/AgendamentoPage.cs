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
        BindingList<AgendamentoDTO> agendamentos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public AgendamentoPage()
        {
            InitializeComponent();
            ObterDados(DateTime.Today);
            ConfigurarDataGridView();
        }


        public void ObterDados(DateTime? dataFiltro = null)
        {
            var todos = repository.getAll();

            if (dataFiltro.HasValue)
            {
                todos = todos
                    .Where(a => a.dataHoraAgendamento.Date == dataFiltro.Value.Date)
                    .ToList();
            }

            agendamentos = new BindingList<AgendamentoDTO>(todos);
            id = repository.getHighestId() + 1;
        }

        private void AtualizarDataGridView(DateTime? dataFiltro = null)
        {
            ObterDados(dataFiltro);

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = agendamentos;

            ConfigurarColunas();
        }



        private void AtualizarDataGridView()
        {
            AtualizarDataGridView(DateTime.Today);
        }



        private void ConfigurarDataGridView()
        {

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = agendamentos;

            ConfigurarColunas();

        }

        private void ConfigurarColunas()
        {
            if (dataGridView1.Columns.Contains("id"))
                dataGridView1.Columns["id"].HeaderText = "ID";

            if (dataGridView1.Columns.Contains("nome_cliente"))
                dataGridView1.Columns["nome_cliente"].HeaderText = "Cliente";

            if (dataGridView1.Columns.Contains("placa_veiculo"))
                dataGridView1.Columns["placa_veiculo"].HeaderText = "Veículo";

            if (dataGridView1.Columns.Contains("nome_produto"))
                dataGridView1.Columns["nome_produto"].HeaderText = "Produto";

            if (dataGridView1.Columns.Contains("dataHoraAgendamento"))
                dataGridView1.Columns["dataHoraAgendamento"].HeaderText = "Data/Hora";

            if (dataGridView1.Columns.Contains("observacoes"))
                dataGridView1.Columns["observacoes"].HeaderText = "Observações";

            if (dataGridView1.Columns.Contains("dataCriacao"))
            {
                dataGridView1.Columns["dataCriacao"].HeaderText = "Data Criação";
                dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dataGridView1.Columns.Contains("dataAlteracao"))
            {
                dataGridView1.Columns["dataAlteracao"].HeaderText = "Última Alteração";
                dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dataGridView1.Columns.Contains("nome_funcionario"))
                dataGridView1.Columns["nome_funcionario"].HeaderText = "Funcionário";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.ValueType == typeof(string))
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                else
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFiltro_ValueChanged_1(object sender, EventArgs e)
        {
            AtualizarDataGridView(dateTimePickerFiltro.Value.Date);
        }
    }
}