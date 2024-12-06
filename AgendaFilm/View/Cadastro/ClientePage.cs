using AgendaFilm.Controller;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
using AgendaFilm.View.Editar;
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
        ClienteRepositorio repository = new ClienteRepositorio();
        Actions actions = new Actions();
        BindingList<Cliente> buscaClientes = new BindingList<Cliente>();
        BindingList<Cliente> clientes;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public ClientePage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["tipo_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionario_fk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void ObterDados()
        {
            clientes = new BindingList<Cliente>(repository.GetAll());
            id = repository.getHighestId() + 1;
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


            CadastroClientePage novoFormulario = new CadastroClientePage(); ;

            novoFormulario.ShowDialog();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                Cliente clienteSelecionado = dataGridViewRow.DataBoundItem as Cliente;

                EditarClientePage editPage = new EditarClientePage(clienteSelecionado);
                int index = clientes.IndexOf(clienteSelecionado);
                editPage.ShowDialog();


                if (editPage.DialogResult == DialogResult.OK)
                {
                    clientes[index] = editPage.cliente;
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("É possivel editar apenas um cliente por vez!", "Error", MessageBoxButtons.OK);
            }
        }

        private void ClientePage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado;
            DataGridViewRow dataGridViewRow;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dataGridViewRow = dataGridView1.SelectedRows[i];
                    clienteSelecionado = dataGridViewRow.DataBoundItem as Cliente;


                    if (clienteSelecionado != null)
                    {
                        clientes.Remove(clienteSelecionado);
                        buscaClientes.Remove(clienteSelecionado);
                        repository.RemoveCliente(clienteSelecionado);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum Cliente selecionado!", "Error", MessageBoxButtons.OK);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscaClientes.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaClientes;

            if (radioTodos.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clientes;
            }
            else
            {
                if (!(string.IsNullOrWhiteSpace(textBoxPesquisar.Text)))
                {
                    if (radioNome.Checked)
                    {

                        bool clienteExiste = false;

                        foreach (var cliente in clientes)
                        {
                            if (cliente.nome.Contains(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaClientes.Add(cliente);

                                clienteExiste = true;
                            }
                        }

                        if (!clienteExiste)
                        {
                            MessageBox.Show("Cliente não está cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioId.Checked)
                    {
                        bool clienteExiste = false;

                        try
                        {
                            int numId = int.Parse(textBoxPesquisar.Text);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Você tem que digitar apenas numeros", "Error", MessageBoxButtons.OK);
                            return;
                        }


                        foreach (var cliente in clientes)
                        {
                            if (cliente.id == int.Parse(textBoxPesquisar.Text))
                            {
                                buscaClientes.Add(cliente);

                                clienteExiste = true;
                            }
                        }

                        if (!clienteExiste)
                        {
                            MessageBox.Show("Cliente não cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioTelefone.Checked)
                    {
                        bool clienteExiste = false;

                        foreach (var cliente in clientes)
                        {
                            if (cliente.telefone.Contains(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaClientes.Add(cliente);

                                clienteExiste = true;
                            }
                        }

                        if (!clienteExiste)
                        {
                            MessageBox.Show("Não há nenhum cliente com este telefone", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Marque uma das opções de busca!", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Você não digitou nenhum termo para ser pesquisado!", "Error", MessageBoxButtons.OK);
                }
            }
            textBoxPesquisar.Clear();
        }
    }
}
