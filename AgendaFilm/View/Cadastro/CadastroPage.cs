using AgendaFilm.Controller;
using AgendaFilm.Model.Repositories;
using AgendaFilm.View;
using AgendaFilm.View.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

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

            // Define a espessura da borda
            int borderWidth = 4;

            // Cor da borda
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

            this.Shown += CadastroPage_Shown;
            this.FormClosed += CadastroPage_FormClosed;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            InicializarBotaoFechar();
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void pictureBox4_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new FuncionarioPage(),
                new Point(this.Location.X + 237, this.Location.Y + 116));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new FornecedorPage(),
                new Point(this.Location.X + 237, this.Location.Y + 116));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new ProdutoPage(),
                new Point(this.Location.X + 237, this.Location.Y + 116));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new ClientePage(),
                new Point(this.Location.X + 237, this.Location.Y + 116));
        }

        private void Veíc_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new VeiculoPage(),
                new Point(this.Location.X + 237, this.Location.Y + 116));
        }

        private void SelecionarBotao(Button botao)
        {
            if (botaoSelecionado != null)
            {
                botaoSelecionado.BackColor = SystemColors.ActiveCaption;
                botaoSelecionado.ForeColor = SystemColors.ControlText;
            }

           
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

        private void CadastroPage_Load(object sender, EventArgs e) {

            


        }

        private void CadastroPage_Shown(object sender, EventArgs e)
        {


        
            clientePage = new ClientePage();
            AbrirFormulario(clientePage, new Point(this.Location.X + 237, this.Location.Y + 116));
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


        private void InicializarBotaoFechar()
        {
            btnFechar = new Button();
            btnFechar.Text = "✕"; // Um X mais estilizado
            btnFechar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnFechar.Size = new Size(35, 35);
            btnFechar.Location = new Point(this.Width - 40, 5);
            btnFechar.BackColor = Color.FromArgb(220, 53, 69); // Vermelho Bootstrap
            btnFechar.ForeColor = Color.White;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Evento de clique para fechar
            btnFechar.Click += (s, e) => this.Close();

            // Evento de hover para clarear
            btnFechar.MouseEnter += (s, e) =>
            {
                btnFechar.BackColor = Color.FromArgb(255, 99, 117);
            };
            btnFechar.MouseLeave += (s, e) =>
            {
                btnFechar.BackColor = Color.FromArgb(220, 53, 69);
            };

            // Cantos arredondados
            btnFechar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFechar.Width, btnFechar.Height, 10, 10));

            this.Controls.Add(btnFechar);
            btnFechar.BringToFront();
        }

        // Importação para cantos arredondados
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);


        private void lbUsuarioLogado_Click(object sender, EventArgs e) { }
    }
}
