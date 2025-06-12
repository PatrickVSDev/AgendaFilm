using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private Button btnFechar; // Botão "X" para fechar

        public event Action RefreshGrid;

        public CadastroClientePage()
        {
            ObterDados();
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarBotaoFechar();
        }

        public void ObterDados()
        {
            clientes = new BindingList<Cliente>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 4;
            Color borderColor = Color.Black;

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        private void InicializarBotaoFechar()
        {
            btnFechar = new Button();
            btnFechar.Text = "✕";
            btnFechar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnFechar.Size = new Size(35, 35);
            btnFechar.Location = new Point(this.Width - 45, 5);
            btnFechar.BackColor = Color.FromArgb(220, 53, 69);
            btnFechar.ForeColor = Color.White;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnFechar.Click += (s, e) => this.Close();
            btnFechar.MouseEnter += (s, e) => btnFechar.BackColor = Color.FromArgb(255, 99, 117);
            btnFechar.MouseLeave += (s, e) => btnFechar.BackColor = Color.FromArgb(220, 53, 69);

            btnFechar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFechar.Width, btnFechar.Height, 10, 10));

            this.Controls.Add(btnFechar);
            btnFechar.BringToFront();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

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
            catch (FormatException)
            {
                MessageBox.Show("Você tem que digitar apenas numeros no campo de Telefone", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                numCPF = long.Parse(textDocumento.Text.Trim());
                numTel = long.Parse(textTelefone.Text.Trim());
            }
            catch (FormatException)
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

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void CadastroClientePage_Load(object sender, EventArgs e) { }
        private void groupBox6_Enter(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
    }
}
