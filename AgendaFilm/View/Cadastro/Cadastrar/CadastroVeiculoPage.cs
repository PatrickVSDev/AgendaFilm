using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaFilm.View.Cadastro.Cadastrar
{
    public partial class CadastroVeiculoPage : Form
    {
        public CadastroVeiculoPage()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EscolherClientePage novoFormulario = new EscolherClientePage(); ;
            novoFormulario.Show();
        }
    }
}
