using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
using AgendaFilm.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace AgendaFilm
{
    public partial class CadastroFuncionarioPage : Form
    {

        FuncionarioRepositorio repository = new FuncionarioRepositorio();
        Actions actions = new Actions();
        BindingList<Funcionario> buscaFuncionarios = new BindingList<Funcionario>();
        BindingList<Funcionario> funcionarios;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public CadastroFuncionarioPage()
        {
            InitializeComponent();
            ObterDados();
        }

        public void ObterDados()
        {
            funcionarios = new BindingList<Funcionario>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CadastroFuncionarioPage_Load(object sender, EventArgs e)
        {

        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            textBoxes.Clear();
            textBoxes.Add(txtLogin.Text);
            textBoxes.Add(txtNome.Text);
            textBoxes.Add(txtSenha.Text);
            textBoxes.Add(txtTelefone.Text);
            textBoxes.Add(txtCargo.Text);
            textBoxes.Add(txtNivelAcesso.Text);

            actions.verifyBlanksTextboxes(textBoxes);

            int numNivelAcesso;
            if (int.TryParse(txtNivelAcesso.Text, out numNivelAcesso))
            {

            }
            else
            {
                MessageBox.Show("Para o nivel de acesso esse número não é válido.");
            }


            Funcionario funcionario = new Funcionario(id, txtNome.Text.Trim(), txtTelefone.Text.Trim(), txtLogin.Text.Trim(), txtSenha.Text.Trim(), txtCargo.Text.Trim(), numNivelAcesso, dataAtual, dataAtual, Global.funcionarioLogado);
            funcionarios.Add(funcionario);
            repository.Add(funcionario);

            id++;

            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();
            txtCargo.Clear();
            txtNivelAcesso.Clear();

            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNivelAcesso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
