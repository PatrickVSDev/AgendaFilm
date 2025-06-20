using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
using AgendaFilm.Controller;
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
    public partial class CadastroFuncionarioPage : Form
    {
        FuncionarioRepositorio repository = new FuncionarioRepositorio();
        Actions actions = new Actions();
        BindingList<Funcionario> buscaFuncionarios = new BindingList<Funcionario>();
        BindingList<Funcionario> funcionarios;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        private Button btnFechar; // Botão "X"

        public event Action RefreshGrid;

        public CadastroFuncionarioPage()
        {
            InitializeComponent();
            ObterDados();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarBotaoFechar();
        }

        public void ObterDados()
        {
            funcionarios = new BindingList<Funcionario>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CadastroFuncionarioPage_Load(object sender, EventArgs e)
        {

        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            textBoxes.Clear();
            textBoxes.Add(txtLogin.Text);
            textBoxes.Add(txtNome.Text);
            textBoxes.Add(txtSenha.Text);
            textBoxes.Add(txtTelefone.Text);
            textBoxes.Add(txtCargo.Text);
            textBoxes.Add(txtNivelAcesso.Text);

            actions.verifyBlanksTextboxes(textBoxes);

            int numNivelAcesso;
            if (int.TryParse(txtNivelAcesso.Text, out numNivelAcesso))
            {

            }
            else
            {
                MessageBox.Show("Para o nivel de acesso esse número não é válido.");
            }

            Funcionario funcionario = new Funcionario(id, txtNome.Text.Trim(), txtTelefone.Text.Trim(), txtLogin.Text.Trim(), txtSenha.Text.Trim(), txtCargo.Text.Trim(), numNivelAcesso, dataAtual, dataAtual, Global.funcionarioLogado);
            funcionarios.Add(funcionario);
            repository.Add(funcionario);

            id++;

            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();
            txtCargo.Clear();
            txtNivelAcesso.Clear();

            RefreshGrid?.Invoke();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNivelAcesso_TextChanged(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }


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
    }
}
