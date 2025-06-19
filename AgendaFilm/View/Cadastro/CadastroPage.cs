using AgendaFilm.Controller;
using AgendaFilm.Model.Repositories;
using AgendaFilm.View;
using AgendaFilm.View.Cadastro;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AgendaFilm
{
    public partial class CadastroPage : Form
    {
        Actions actions = new Actions();
        FuncionarioRepositorio repositoryFuncionario = new FuncionarioRepositorio();
        private ClientePage clientePage;

        private Form formularioAberto;
        private Button botaoSelecionado = null;
        private Button btnFechar;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 4;
            Color borderColor = Color.Black;

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        public CadastroPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(316, 180);
            this.Shown += CadastroPage_Shown;
            this.FormClosed += CadastroPage_FormClosed;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;

            
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new FuncionarioPage(),
                new Point(this.Location.X + 218, this.Location.Y + 94));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new FornecedorPage(),
                new Point(this.Location.X + 218, this.Location.Y + 94));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new ProdutoPage(),
                new Point(this.Location.X + 218, this.Location.Y + 94));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new ClientePage(),
                new Point(this.Location.X + 218, this.Location.Y + 94));
        }

        private void Veíc_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new VeiculoPage(),
                new Point(this.Location.X + 218, this.Location.Y + 94));
        }

        // ✅ Aqui é onde faz o botão ficar selecionado e desmarcar os outros
        private void SelecionarBotao(Button botao)
        {
            if (botaoSelecionado != null)
            {
                // Voltar para a cor padrão do botão anterior
                botaoSelecionado.BackColor = Color.DarkSlateGray;
                botaoSelecionado.ForeColor = Color.Black;
            }

            // Aplicar cor de botão selecionado
            botao.BackColor = Color.LightSeaGreen;
            botao.ForeColor = Color.Black;

            botaoSelecionado = botao;
        }

        private void AbrirFormulario(Form novoFormulario, Point localizacao)
        {
            if (formularioAberto != null)
            {
                formularioAberto.Close();
                formularioAberto = null;
            }
            formularioAberto = novoFormulario;
            formularioAberto.Owner = this;
            formularioAberto.StartPosition = FormStartPosition.Manual;
            formularioAberto.Location = localizacao;
            formularioAberto.Show();
        }

        private void CadastroPage_Load(object sender, EventArgs e) { }

        private void CadastroPage_Shown(object sender, EventArgs e)
        {
            clientePage = new ClientePage();
            AbrirFormulario(clientePage, new Point(this.Location.X + 217, this.Location.Y + 92));
        }

        private void CadastroPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (formularioAberto != null && !formularioAberto.IsDisposed)
            {
                formularioAberto.Close();
            }

            if (clientePage != null && !clientePage.IsDisposed)
            {
                clientePage.Close();
            }
        }

        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void lbUsuarioLogado_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuPage novoFormulario = new MenuPage();
            novoFormulario.ShowDialog();
            this.Close();
        }
    }
}
