using AgendaFilm.View;
using AgendaFilm.View.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaFilm
{
    public partial class CadastroPage : Form
    {
        private Form formularioAberto;

        public CadastroPage()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FuncionarioPage(),
                new Point(this.Location.X + button1.Location.X + 242, this.Location.Y + button1.Location.Y - 535));


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario(new FornecedorPage(),
                new Point(this.Location.X + button1.Location.X + 242, this.Location.Y + button1.Location.Y - 535));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario(new ProdutoPage(),
                new Point(this.Location.X + button1.Location.X + 242, this.Location.Y + button1.Location.Y - 535));
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AbrirFormulario(new ClientePage(),
                new Point(this.Location.X + button1.Location.X + 242, this.Location.Y + button1.Location.Y - 535));


        }


        private void Veíc_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario(new VeiculoPage(),
                new Point(this.Location.X + button1.Location.X + 242, this.Location.Y + button1.Location.Y - 535));
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
    }
}