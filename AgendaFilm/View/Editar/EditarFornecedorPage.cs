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

namespace AgendaFilm.View.Editar
{
    public partial class EditarFornecedorPage : Form
    {
        FornecedorRepositorio repository = new FornecedorRepositorio();
        public Fornecedor fornecedor { get; set; }
        Actions actions = new Actions();

        public event Action RefreshGrid;
        public EditarFornecedorPage(Fornecedor fornecedor)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;
            textDocumento.Text = fornecedor.documento.Trim();
            textNome.Text = fornecedor.nome.Trim();
            textTelefone.Text = fornecedor.telefone.Trim();
            textEmail.Text = fornecedor.email.Trim();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarFornecedorPage_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            this.fornecedor.documento = textDocumento.Text.Trim();
            this.fornecedor.nome = textNome.Text.Trim();
            this.fornecedor.telefone = textTelefone.Text.Trim();
            this.fornecedor.email = textEmail.Text.Trim();
            this.fornecedor.dataAlteracao = DateTime.Today;
            this.fornecedor.funcionario_fk = Global.funcionarioLogado;
            repository.UpdateFornecedor(fornecedor);

            RefreshGrid?.Invoke();
            this.Close();
        }
    }
}
