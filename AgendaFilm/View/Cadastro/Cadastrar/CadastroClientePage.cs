using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgendaFilm
{
    public partial class CadastroClientePage : Form
    {
        ClienteRepositorio repository = new ClienteRepositorio();
        Actions actions = new Actions();
        BindingList<Cliente> buscaClientes = new BindingList<Cliente>();
        BindingList<Cliente> clientes;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public event Action RefreshGrid;

        public CadastroClientePage()
        {
            ObterDados();
            InitializeComponent();
        }
        public void ObterDados()
        {
            clientes = new BindingList<Cliente>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CadastroClientePage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxes.Clear();
            textBoxes.Add(comboTipoCliente.Text);
            textBoxes.Add(textDocumento.Text);
            textBoxes.Add(textNome.Text);
            textBoxes.Add(textTelefone.Text);

            actions.verifyBlanksTextboxes(textBoxes);




            foreach (var text in clientes)
            {
                if (text.nome.Equals(textNome.Text))
                {
                    MessageBox.Show("Este cliente já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            long numCPF;
            long numTel;


            try
            {
                numTel = long.Parse(textTelefone.Text.Trim());
                if (numTel.ToString().Length != 11)
                {
                    MessageBox.Show("O campo de telefone precisa ter 11 numeros, incluindo DDD!");
                    return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Você tem que digitar apenas numeros no campo de Telefone", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                numCPF = long.Parse(textDocumento.Text.Trim());
                numTel = long.Parse(textTelefone.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Você tem que digitar apenas numeros no campo de CPF", "Error", MessageBoxButtons.OK);
                return;
            }

            Cliente cliente = new Cliente(id, comboTipoCliente.Text.Trim().ToUpper(), textDocumento.Text.Trim(), textNome.Text.Trim(), textTelefone.Text.Trim(), dataAtual, dataAtual, Global.funcionarioLogado);
            clientes.Add(cliente);
            repository.Add(cliente);

            id++;

            textDocumento.Clear();
            textNome.Clear();
            textTelefone.Clear();

            RefreshGrid?.Invoke();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
