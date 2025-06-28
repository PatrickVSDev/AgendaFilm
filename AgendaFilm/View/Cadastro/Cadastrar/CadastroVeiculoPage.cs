using AgendaFilm.Controller;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
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
using static System.Net.Mime.MediaTypeNames;

namespace AgendaFilm.View.Cadastro.Cadastrar
{
    public partial class CadastroVeiculoPage : Form
    {
        public int clienteIdRecebido { get; set; }
        private Cliente clienteSelecionado = null;

        VeiculoRepositorio repository = new VeiculoRepositorio();
        Actions actions = new Actions();
        BindingList<Veiculo> buscaVeiculos = new BindingList<Veiculo>();
        BindingList<Veiculo> veiculos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        private Button btnFechar; // Botão "X"

        public event Action RefreshGrid;

        public CadastroVeiculoPage()
        {
            InitializeComponent();
            ObterDados();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarBotaoFechar();
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

        public void SetarNomeCliente(string nomeCliente)
        {
            lbNomeCliente.Text = nomeCliente.ToUpper();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            EscolherClientePage formSelecionar = new EscolherClientePage();
            if (formSelecionar.ShowDialog() == DialogResult.OK)
            {
                clienteSelecionado = formSelecionar.ClienteSelecionado;
                clienteIdRecebido = clienteSelecionado.id;
                lbNomeCliente.Text = clienteSelecionado.nome.ToUpper();
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(lbNomeCliente.Text) || clienteIdRecebido < 0)
            {
                MessageBox.Show("Selecione um cliente antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            btnFechar.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold); ;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.Black;
            int espessuraBorda = 3;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Size textSize = TextRenderer.MeasureText(box.Text, box.Font);
            Rectangle rect = new Rectangle(0, textSize.Height / 2, box.Width - 1, box.Height - textSize.Height / 2 - 1);

            e.Graphics.Clear(box.BackColor);

            using (Pen pen = new Pen(corBorda, espessuraBorda))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddRectangle(rect);
                e.Graphics.DrawPath(pen, path);
            }

            using (SolidBrush brush = new SolidBrush(box.ForeColor))
            {
                e.Graphics.DrawString(box.Text, box.Font, brush, 10, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Label label = sender as Label;

            Color corBorda = Color.Black;
            int espessuraBorda = 2;
            int raio = 8;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, label.Width - 1, label.Height - 1);

            using (Pen pen = new Pen(corBorda, espessuraBorda))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.Left, rect.Top, raio, raio, 180, 90);
                path.AddArc(rect.Right - raio, rect.Top, raio, raio, 270, 90);
                path.AddArc(rect.Right - raio, rect.Bottom - raio, raio, raio, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - raio, raio, raio, 90, 90);
                path.CloseFigure();

                e.Graphics.DrawPath(pen, path);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
