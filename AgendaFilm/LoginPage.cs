using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaFilm
{
    public partial class PaginaLogin : Form
    {
        public List<Funcionario> funcionarios;

        public PaginaLogin()
        {
            InitializeComponent();
            ObterFuncionarios();
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
                if (funcionario.login.Equals(txtUsuario.Text) && funcionario.senha.Equals(txtSenha.Text))
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
    }
}
