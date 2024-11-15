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
    public partial class EditarFuncionarioPage : Form
    {
        FuncionarioRepositorio repository = new FuncionarioRepositorio();
        public Funcionario funcionario { get; set; }
        Actions actions = new Actions();
        BindingList<Funcionario> buscaFuncionarios = new BindingList<Funcionario>();
        BindingList<Funcionario> funcionarios;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public event Action RefreshGrid;

        public EditarFuncionarioPage(Funcionario funcionario)
        {
            InitializeComponent();
            ObterDados();
            this.funcionario = funcionario;
            txtNome.Text = funcionario.nome.Trim();
            txtCargo.Text = funcionario.cargo.Trim();
            txtNivelAcesso.Text = funcionario.nivelAcesso.ToString().Trim();
            txtTelefone.Text = funcionario.telefone.Trim();
        }

        public void ObterDados()
        {
            funcionarios = new BindingList<Funcionario>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void EditarFuncionarioPage_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNivelAcesso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(Global.senhaLogado) && txtLogin.Text.Equals(Global.loginLogado))
                {
                this.funcionario.nome = txtNome.Text.Trim();
                this.funcionario.cargo = txtCargo.Text.Trim();
                this.funcionario.telefone = txtTelefone.Text.Trim();
                this.funcionario.dataAlteracao = DateTime.Today;
                this.funcionario.funcionarioAlteracao = Global.funcionarioLogado;

                int numNivelAcesso;
                if (int.TryParse(txtNivelAcesso.Text, out numNivelAcesso))
                {

                }
                else
                {
                    MessageBox.Show("Para o nivel de acesso esse número não é válido.");
                }
                this.funcionario.nivelAcesso = (numNivelAcesso);
                repository.UpdateFuncionario(funcionario);

                RefreshGrid?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha ou login incorretos, tente novamente!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
