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

namespace AgendaFilm.View.Cadastro.Cadastrar
{
    public partial class EscolherClientePage : Form
    {
        ClienteRepositorio repository = new ClienteRepositorio();
        Actions actions = new Actions();
        BindingList<Cliente> buscaClientes = new BindingList<Cliente>();
        BindingList<Cliente> clientes;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public EscolherClientePage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["tipo_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionario_fk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void ObterDados()
        {
            clientes = new BindingList<Cliente>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int clienteId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                CadastroVeiculoPage cadastroVeiculoPage = (CadastroVeiculoPage)Application.OpenForms["CadastroVeiculoPage"];

                if (cadastroVeiculoPage != null)
                {
                    cadastroVeiculoPage.clienteIdRecebido = clienteId;
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

        private void EscolherClientePage_Load(object sender, EventArgs e)
        {

        }
    }
}

