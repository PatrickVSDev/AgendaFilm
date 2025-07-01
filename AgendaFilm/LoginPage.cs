using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static AgendaFilm.Controller.Actions;
using static AgendaFilm.Utils.EstiloDataGridView;

namespace AgendaFilm
{
    public partial class PaginaLogin : Form
    {
        public List<Funcionario> funcionarios;

        public PaginaLogin()
        {
            InitializeComponent();
            ObterFuncionarios();
            BotaoFecharUtils.AplicarBotaoFechar(this);
        }

        private void ObterFuncionarios()
        {
            var repository = new FuncionarioRepositorio();
            funcionarios = repository.GetAll();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            foreach (var funcionario in funcionarios)
            {
                string senhaDigitadaHash = Actions.PasswordHasher.GerarHashSenha(txtSenha.Text.Trim());

                if (funcionario.login.Equals(txtUsuario.Text.Trim()) && funcionario.senha.Equals(senhaDigitadaHash))
                {
                    Global.funcionarioLogado = funcionario.id;
                    Global.loginLogado = funcionario.login;
                    Global.senhaLogado = funcionario.senha;

                    Logger.Log($"Login realizado com sucesso para o usuário {funcionario.login}", "INFO", funcionario.login);

                    this.DialogResult = DialogResult.OK;
                    return;
                }
            }

            Logger.Log($"Tentativa de login inválida para o usuário {txtUsuario.Text}", "WARNING", txtUsuario.Text);
            MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void txtUsuario_TextChanged(object sender, EventArgs e) { }
        private void txtSenha_TextChanged(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e)
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
