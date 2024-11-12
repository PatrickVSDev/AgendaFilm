using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
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
    public partial class FuncionarioPage : Form
    {
        FuncionarioRepositorio repository = new FuncionarioRepositorio();
        Actions actions = new Actions();
        BindingList<Funcionario> buscaFuncionarios = new BindingList<Funcionario>();
        BindingList<Funcionario> funcionarios;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public FuncionarioPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = funcionarios;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["senha"].Visible = false;
        }

        public void ObterDados()
        {
            funcionarios = new BindingList<Funcionario>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Point buttonScreenPosition = button1.PointToScreen(Point.Empty);

            // Defina a posição do novo formulário usando o ponto do botão
            CadastroFuncionarioPage novoFormulario = new CadastroFuncionarioPage();
            //novoFormulario.StartPosition = FormStartPosition.CenterScreen; // Defina a posição manualmente
            //novoFormulario.Location = new Point(buttonScreenPosition.X + 100, buttonScreenPosition.Y - 50);
            novoFormulario.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioSelecionado;
            DataGridViewRow dataGridViewRow;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dataGridViewRow = dataGridView1.SelectedRows[i];
                    funcionarioSelecionado = dataGridViewRow.DataBoundItem as Funcionario;


                    if (funcionarioSelecionado != null)
                    {
                        funcionarios.Remove(funcionarioSelecionado);
                        buscaFuncionarios.Remove(funcionarioSelecionado);
                        repository.RemoveFuncionario(funcionarioSelecionado);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum Funcionário selecionado", "Error", MessageBoxButtons.OK);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            EditarFuncionarioPage novoFormulario = new EditarFuncionarioPage(); ;
            novoFormulario.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            buscaFuncionarios.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaFuncionarios;
            dataGridView1.Columns["senha"].Visible = false;

            if (radioTodos.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = funcionarios;
                dataGridView1.Columns["senha"].Visible = false;
            }
            else
            {
                if (!(string.IsNullOrWhiteSpace(textBoxPesquisar.Text)))
                {
                    if (radioNome.Checked)
                    {

                        bool funcionarioExiste = false;

                        foreach (var funcionario in funcionarios)
                        {
                            if (funcionario.nome.Contains(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaFuncionarios.Add(funcionario);

                                funcionarioExiste = true;
                            }
                        }

                        if (!funcionarioExiste)
                        {
                            MessageBox.Show("Funcionário não está cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioId.Checked)
                    {
                        bool funcionarioExiste = false;

                        try
                        {
                            int numId = int.Parse(textBoxPesquisar.Text);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Você tem que digitar apenas numeros", "Error", MessageBoxButtons.OK);
                            return;
                        }


                        foreach (var funcionario in funcionarios)
                        {
                            if (funcionario.id == int.Parse(textBoxPesquisar.Text))
                            {
                                buscaFuncionarios.Add(funcionario);

                                funcionarioExiste = true;
                            }
                        }

                        if (!funcionarioExiste)
                        {
                            MessageBox.Show("Funcionário não está cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioCargo.Checked)
                    {
                        bool funcionarioExiste = false;

                        foreach (var funcionario in funcionarios)
                        {
                            if (funcionario.cargo.Equals(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaFuncionarios.Add(funcionario);

                                funcionarioExiste = true;
                            }
                        }

                        if (!funcionarioExiste)
                        {
                            MessageBox.Show("Não há nenhum funcionário com este cargo, ou cargo inexistente", "Error", MessageBoxButtons.OK);
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

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
