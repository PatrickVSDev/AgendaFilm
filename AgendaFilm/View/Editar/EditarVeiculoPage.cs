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

namespace AgendaFilm.View.Editar
{
    public partial class EditarVeiculoPage : Form
    {

        VeiculoRepositorio repository = new VeiculoRepositorio();
        public Veiculo veiculo { get; set; }
        Actions actions = new Actions();

        public event Action RefreshGrid;

        public EditarVeiculoPage(Veiculo veiculo)
        {
            InitializeComponent();
            this.veiculo = veiculo;
            textPlaca.Text = veiculo.placa.Trim();
            textModelo.Text = veiculo.modelo.Trim();
            textAno.Text = veiculo.ano.ToString();
            textMarca.Text = veiculo.marca.Trim();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditarVeiculoPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string placa = textPlaca.Text.Trim();
                string padraoPlaca = @"^[A-Z]{3}[0-9][A-Z0-9][0-9]{2}$";

                if (!System.Text.RegularExpressions.Regex.IsMatch(placa, padraoPlaca))
                {
                    MessageBox.Show("A placa não está no formato válido (AAA0A00 ou AAA0000).");
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
            this.veiculo.modelo = textModelo.Text.Trim();

            if (int.TryParse(textAno.Text.Trim(), out int valor))
            {
                this.veiculo.ano = valor;
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido para o ano.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.veiculo.placa = textPlaca.Text.Trim();
            this.veiculo.marca = textMarca.Text.Trim();
            this.veiculo.dataAlteracao = DateTime.Today;
            this.veiculo.funcionario_fk = Global.funcionarioLogado;
            repository.UpdateVeiculo(veiculo);

            RefreshGrid?.Invoke();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
