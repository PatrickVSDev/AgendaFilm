using AgendaFilm.Controller;
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
using static System.Net.Mime.MediaTypeNames;

namespace AgendaFilm.View.Cadastro.Cadastrar
{
    public partial class CadastroVeiculoPage : Form
    {
        public int clienteIdRecebido { get; set; }

        VeiculoRepositorio repository = new VeiculoRepositorio();
        Actions actions = new Actions();
        BindingList<Veiculo> buscaVeiculos = new BindingList<Veiculo>();
        BindingList<Veiculo> veiculos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public event Action RefreshGrid;

        public CadastroVeiculoPage()
        {
            InitializeComponent();
            ObterDados();
        }

        public void AtualizarId(int clienteId)
        {
            clienteIdRecebido = clienteId;
        }

        public void ObterDados()
        {
            veiculos = new BindingList<Veiculo>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EscolherClientePage novoFormulario = new EscolherClientePage(); ;
            novoFormulario.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            textBoxes.Clear();
            textBoxes.Add(txtMarca.Text);
            textBoxes.Add(txtModelo.Text);
            textBoxes.Add(txtPlaca.Text);

            actions.verifyBlanksTextboxes(textBoxes);




            foreach (var text in veiculos)
            {
                if (text.placa.Equals(txtPlaca.Text))
                {
                    MessageBox.Show("Esta placa já esta cadastrada!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            try
            {
                string placa = txtPlaca.Text.Trim();
                string padraoPlaca = @"^[A-Z]{3}[0-9][A-Z0-9][0-9]{2}$";


                if (!System.Text.RegularExpressions.Regex.IsMatch(placa, padraoPlaca))
                {
                    MessageBox.Show("A placa não está no formato válido (AAA0A00).");
                    return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int ano = int.Parse(txtAno.Text);

            Veiculo veiculo = new Veiculo(id, txtPlaca.Text.Trim().ToUpper(), txtModelo.Text.Trim(), ano, txtMarca.Text.Trim(), dataAtual, dataAtual, Global.funcionarioLogado, clienteIdRecebido);
            veiculos.Add(veiculo);
            repository.Add(veiculo);

            id++;

            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            txtAno.Clear();

            RefreshGrid?.Invoke();
            this.Close();
        }

        private void CadastroVeiculoPage_Load(object sender, EventArgs e)
        {

        }
    }
}
