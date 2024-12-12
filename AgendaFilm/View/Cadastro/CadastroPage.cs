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

        private Form formularioAberto;
        private Button botaoSelecionado = null;

        

        public CadastroPage()
        {
            InitializeComponent();

           
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void pictureBox4_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new FuncionarioPage(),
                new Point(this.Location.X + button1.Location.X + 242, this.Location.Y + button1.Location.Y - 535));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new FornecedorPage(),
                new Point(this.Location.X + button1.Location.X + 242, this.Location.Y + button1.Location.Y - 535));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new ProdutoPage(),
                new Point(this.Location.X + button1.Location.X + 242, this.Location.Y + button1.Location.Y - 535));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new ClientePage(),
                new Point(this.Location.X + button1.Location.X + 242, this.Location.Y + button1.Location.Y - 535));
        }

        private void Veíc_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new VeiculoPage(),
                new Point(this.Location.X + button1.Location.X + 242, this.Location.Y + button1.Location.Y - 535));
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
            formularioAberto.StartPosition = FormStartPosition.Manual;
            formularioAberto.Location = localizacao;
            formularioAberto.Show();
        }

        private void CadastroPage_Load(object sender, EventArgs e) { }

        private void CadastroPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (formularioAberto != null && !formularioAberto.IsDisposed)
            {
                formularioAberto.Close();
            }
        }

        private void lbUsuarioLogado_Click(object sender, EventArgs e) { }
    }
}
