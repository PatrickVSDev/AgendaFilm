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
    public partial class ClientePage : Form
    {
        public ClientePage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Point buttonScreenPosition = button1.PointToScreen(Point.Empty);

            // Defina a posição do novo formulário usando o ponto do botão
            CadastroClientePage novoFormulario = new CadastroClientePage();
            //novoFormulario.StartPosition = FormStartPosition.Manual; // Defina a posição manualmente
            //novoFormulario.Location = new Point(buttonScreenPosition.X + 100, buttonScreenPosition.Y - 50);
            novoFormulario.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
