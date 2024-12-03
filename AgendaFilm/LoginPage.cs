using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Controller;


namespace AgendaFilm
{
    public partial class PaginaLogin : Form
    {
        public List<Funcionario> funcionarios;

        public PaginaLogin()
        {
            InitializeComponent();
            ObterFuncionarios();
        }

        private void ObterFuncionarios()
        {
            var repository = new FuncionarioRepositorio();
            funcionarios = repository.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            bool funcExiste = false;

            foreach (var funcionario in funcionarios)
            {
                if (funcionario.login.Equals(txtUsuario.Text) && funcionario.senha.Equals(txtSenha.Text))
                {
                    funcExiste = true;
                    Global.funcionarioLogado = funcionario.id;
                    Global.loginLogado = funcionario.login;
                    Global.senhaLogado = funcionario.senha;
                    this.Hide();
                    MenuPage adminHomePage = new MenuPage();
                    adminHomePage.Show();
                    break;
                }
            }

            if (!funcExiste)
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
