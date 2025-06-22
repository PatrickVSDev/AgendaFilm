using System;
using System.Windows.Forms;

namespace AgendaFilm.View.OrdemDeServiço
{
    public partial class EditarStatusOrdemForm : Form
    {
        public string NovoStatus { get; private set; }

        public EditarStatusOrdemForm(string statusAtual)
        {
            InitializeComponent();

            comboBoxStatus.Items.AddRange(new string[] { "A FAZER", "EM ANDAMENTO", "FINALIZADO" });
            comboBoxStatus.SelectedItem = statusAtual;
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecione um status.");
                return;
            }

            NovoStatus = comboBoxStatus.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
