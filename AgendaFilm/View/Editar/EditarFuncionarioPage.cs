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
using static AgendaFilm.Utils.EstiloDataGridView;


namespace AgendaFilm.View.Editar
{
    public partial class EditarFuncionarioPage : Form
    {
        FuncionarioRepositorio repository = new FuncionarioRepositorio();
        public Funcionario funcionario { get; set; }
        Actions actions = new Actions();
        BindingList<Funcionario> buscaFuncionarios = new BindingList<Funcionario>();
        BindingList<Funcionario> funcionarios;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        private Button btnFechar; // Botão X

        public event Action RefreshGrid;

        public EditarFuncionarioPage(Funcionario funcionario)
        {
            InitializeComponent();
            ObterDados();
            this.funcionario = funcionario;
            txtNome.Text = funcionario.nome.Trim();
            txtCargo.Text = funcionario.cargo.Trim();
            txtNivelAcesso.Text = funcionario.nivelAcesso.ToString().Trim();
            txtTelefone.Text = funcionario.telefone.Trim();

            // Ativando borda e botão X
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            BotaoFecharUtils.AplicarBotaoFechar(this);
        }

        public void ObterDados()
        {
            funcionarios = new BindingList<Funcionario>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void EditarFuncionarioPage_Load(object sender, EventArgs e) { }

        private void txtNome_TextChanged(object sender, EventArgs e) { }

        private void txtCargo_TextChanged(object sender, EventArgs e) { }

        private void txtNivelAcesso_TextChanged(object sender, EventArgs e) { }

        private void txtTelefone_TextChanged(object sender, EventArgs e) { }

        private void txtLogin_TextChanged(object sender, EventArgs e) { }

        private void txtSenha_TextChanged(object sender, EventArgs e) { }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string senhaHashDigitada = PasswordHasher.GerarHashSenha(txtSenha.Text.Trim());

            if (senhaHashDigitada == Global.senhaLogado && txtLogin.Text.Trim() == Global.loginLogado)
            {
                this.funcionario.nome = txtNome.Text.Trim();
                this.funcionario.cargo = txtCargo.Text.Trim();
                this.funcionario.telefone = txtTelefone.Text.Trim();
                this.funcionario.dataAlteracao = DateTime.Today;
                this.funcionario.funcionarioAlteracao = Global.funcionarioLogado;

                int numNivelAcesso;
                if (int.TryParse(txtNivelAcesso.Text, out numNivelAcesso))
                {
                }
                else
                {
                    MessageBox.Show("Para o nivel de acesso esse número não é válido.");
                }

                long numTel;

                try
                {
                    numTel = long.Parse(txtTelefone.Text.Trim());
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
                numTel = long.Parse(txtTelefone.Text.Trim());

                this.funcionario.nivelAcesso = (numNivelAcesso);
                repository.UpdateFuncionario(funcionario);

                RefreshGrid?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha ou login incorretos, tente novamente!", "Error", MessageBoxButtons.OK);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

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

        private void groupBox5_Enter(object sender, EventArgs e) { }

        private void groupBox5_Paint(object sender, PaintEventArgs e)
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

        private void label1_Click(object sender, EventArgs e) { }

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

        // ====================== BORDA E BOTÃO X =========================

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

        
        // ==================================================================
    }
}
