using AgendaFilm.Controller;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
using AgendaFilm.View.Cadastro.Cadastrar;
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

namespace AgendaFilm.View.Cadastro
{
    public partial class FornecedorPage : Form
    {
        FornecedorRepositorio repository = new FornecedorRepositorio();
        Actions actions = new Actions();
        BindingList<Fornecedor> buscaFornecedores = new BindingList<Fornecedor>();
        BindingList<Fornecedor> fornecedores;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public FornecedorPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = fornecedores;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionario_fk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void ObterDados()
        {
            fornecedores = new BindingList<Fornecedor>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroFornecedorPage novoFormulario = new CadastroFornecedorPage(); ;
            novoFormulario.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditarFornecedorPage novoFormulario = new EditarFornecedorPage(); ;
            novoFormulario.ShowDialog();
        }

        private void FornecedorPage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscaFornecedores.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaFornecedores;

            if (radioTodos.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = fornecedores;
            }
            else
            {
                if (!(string.IsNullOrWhiteSpace(textBoxPesquisar.Text)))
                {
                    if (radioNome.Checked)
                    {

                        bool clienteExiste = false;

                        foreach (var cliente in fornecedores)
                        {
                            if (cliente.nome.Contains(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaFornecedores.Add(cliente);

                                clienteExiste = true;
                            }
                        }

                        if (!clienteExiste)
                        {
                            MessageBox.Show("Fornecedor não está cadastrado", "Error", MessageBoxButtons.OK);
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


                        foreach (var fornecedor in fornecedores)
                        {
                            if (fornecedor.id == int.Parse(textBoxPesquisar.Text))
                            {
                                buscaFornecedores.Add(fornecedor);

                                clienteExiste = true;
                            }
                        }

                        if (!clienteExiste)
                        {
                            MessageBox.Show("Fornecedor não cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioTelefone.Checked)
                    {
                        bool fornecedorExiste = false;

                        foreach (var fornecedor in fornecedores)
                        {
                            if (fornecedor.telefone.Contains(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaFornecedores.Add(fornecedor);

                                fornecedorExiste = true;
                            }
                        }

                        if (!fornecedorExiste)
                        {
                            MessageBox.Show("Não há nenhum fornecedor com este telefone", "Error", MessageBoxButtons.OK);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
