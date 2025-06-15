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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgendaFilm.View.Editar
{
    public partial class EditarClientePage : Form
    {
        ClienteRepositorio repository = new ClienteRepositorio();
        public Cliente cliente { get; set; }
        Actions actions = new Actions();

        public event Action RefreshGrid;

        public EditarClientePage(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            comboTipoCliente.SelectedItem = cliente.tipo_cliente.Trim();
            textDocumento.Text = cliente.documento.Trim();
            textNome.Text = cliente.nome.Trim();
            textTelefone.Text = cliente.telefone.Trim();
        }
        private void EditarClientePage_Load(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            this.cliente.tipo_cliente = comboTipoCliente.Text.Trim();
            this.cliente.documento = textDocumento.Text.Trim();
            this.cliente.nome = textNome.Text.Trim();
            this.cliente.telefone = textTelefone.Text.Trim();
            this.cliente.dataAlteracao = DateTime.Today;
            this.cliente.funcionario_fk = Global.funcionarioLogado;
            repository.UpdateCliente(cliente);

            RefreshGrid?.Invoke();
            this.Close();
        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
