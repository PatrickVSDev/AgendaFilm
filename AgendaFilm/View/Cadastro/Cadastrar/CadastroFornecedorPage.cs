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
using static AgendaFilm.Controller.Actions;

namespace AgendaFilm.View.Cadastro.Cadastrar
{
    public partial class CadastroFornecedorPage : Form
    {
        FornecedorRepositorio repository = new FornecedorRepositorio();
        Actions actions = new Actions();
        BindingList<Fornecedor> buscaFornecedores = new BindingList<Fornecedor>();
        BindingList<Fornecedor> fornecedores;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        private Button btnFechar; // Botão "X"

        public event Action RefreshGrid;

        public CadastroFornecedorPage()
        {
            ObterDados();
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarBotaoFechar();
        }

        public void ObterDados()
        {
            fornecedores = new BindingList<Fornecedor>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void CadastroFornecedorPage_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxes.Clear();
            textBoxes.Add(textNome.Text);
            textBoxes.Add(textDocumento.Text);
            textBoxes.Add(textTelefone.Text);
            textBoxes.Add(textEmail.Text);

            actions.verifyBlanksTextboxes(textBoxes);

            foreach (var text in fornecedores)
            {
                if (text.nome.Equals(textNome.Text))
                {
                    MessageBox.Show("Este fornecedor já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            foreach (var f in fornecedores)
            {
                if (f.documento == textDocumento.Text.Trim())
                {
                    MessageBox.Show("Este CNPJ já está cadastrado no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            long numCnpj;
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
                numTel = long.Parse(textTelefone.Text.Trim());
                if (numTel.ToString().Length != 11)
                {
                    MessageBox.Show("O campo de telefone precisa ter 11 números, incluindo DDD!");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Você tem que digitar apenas números no campo de Telefone", "Erro", MessageBoxButtons.OK);
                return;
            }

            bool cnpjValido = DocumentoUtils.ValidarCNPJ(textDocumento.Text.Trim());
            if (!cnpjValido)
            {
                MessageBox.Show("CNPJ inválido. Verifique o número informado.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fornecedor fornecedor = new Fornecedor(id, textNome.Text.Trim().ToUpper(), textDocumento.Text.Trim(), textTelefone.Text.Trim(), textEmail.Text.Trim(), dataAtual, dataAtual, Global.funcionarioLogado);
            fornecedores.Add(fornecedor);
            repository.Add(fornecedor);

            id++;

            textNome.Clear();
            textDocumento.Clear();
            textTelefone.Clear();
            textEmail.Clear();

            RefreshGrid?.Invoke();
            this.Close();
        }

        // ====================== ADICIONADO: BORDA E BOTÃO "X" ======================

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Label label = sender as Label;

            if (label == null)
                return; // Não faz nada se for nulo (evita erro)

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox8_Paint(object sender, PaintEventArgs e)
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
    }
}