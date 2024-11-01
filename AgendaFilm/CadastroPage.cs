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
            FuncionarioPage novoFormulario = new FuncionarioPage();
            novoFormulario.Location = new Point(this.Location.X + button1.Location.X + 242,
                                        this.Location.Y + button1.Location.Y + -535);
            novoFormulario.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientePage novoFormulario = new ClientePage();
            novoFormulario.Location = new Point(this.Location.X + button1.Location.X + 242,
                                        this.Location.Y + button1.Location.Y + -535);
            novoFormulario.Show();
        }
    }
}
