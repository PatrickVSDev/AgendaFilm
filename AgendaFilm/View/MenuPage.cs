using AgendaFilm.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaFilm.Model.Repositories;
using AgendaFilm.View.Agendamento;

namespace AgendaFilm
{
    public partial class MenuPage : Form
    {
        Actions actions = new Actions();
        FuncionarioRepositorio repositoryFuncionario = new FuncionarioRepositorio();

        public MenuPage()
        {
            InitializeComponent();
            this.FormClosed += MenuPage_FormClosed;
            lbUsuarioLogado.Text = repositoryFuncionario.getNameById(Global.funcionarioLogado);
        }

        DateTime time;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            CadastroPage novoFormulario = new CadastroPage(); // Substitua "Form2" pelo nome do seu formulário
            novoFormulario.ShowDialog(); // Abre o novo formulário sem fechar o atual
                                         // Use novoFormulario.ShowDialog(); para abrir como uma janela modal


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PaginaRestrita_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgendamentoPage novoFormulario = new AgendamentoPage(); // Substitua "Form2" pelo nome do seu formulário
            novoFormulario.ShowDialog();
        }

        private void Relatorios_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time = DateTime.Now;
            lDataMenu.Text = time.ToShortDateString() + " " + time.ToLongTimeString();
        }

        private void MenuPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbUsuarioLogado_Click(object sender, EventArgs e)
        {

        }
    }

}

