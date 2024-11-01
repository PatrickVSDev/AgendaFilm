namespace AgendaFilm
{
    public partial class PaginaLogin : Form
    {
        public PaginaLogin()
        {
            InitializeComponent();

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
            try
            {
                if (txtUsuario.Text.Equals("admin") && txtSenha.Text.Equals("admin"))
                {
                    var menu = new MenuPage();
                    menu.Show();

                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Usuário, ou senha incorretos!",
                                    "Desculpe.",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe.",
                                ex.Message,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
