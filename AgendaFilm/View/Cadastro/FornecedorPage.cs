using AgendaFilm.View.Cadastro.Cadastrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaFilm.View.Cadastro
{
    public partial class FornecedorPage : Form
    {
        public FornecedorPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroFornecedorPage  novoFormulario = new CadastroFornecedorPage(); ;
            novoFormulario.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
