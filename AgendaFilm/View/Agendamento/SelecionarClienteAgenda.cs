using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaFilm.View.Agendamento
{
    public partial class SelecionarClienteAgenda : Form
    {
        private BindingList<Cliente> clientes;
        private ClienteRepositorio repository = new ClienteRepositorio();

        public SelecionarClienteAgenda()
        {
            InitializeComponent();

        }
        
        private void SelecionarClienteAgenda_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
