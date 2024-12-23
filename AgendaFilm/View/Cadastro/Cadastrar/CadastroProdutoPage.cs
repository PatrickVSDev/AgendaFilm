﻿using AgendaFilm.Controller;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgendaFilm.View.Cadastro.Cadastrar
{
    public partial class CadastroProdutoPage : Form
    {

        ProdutoRepositorio repository = new ProdutoRepositorio();
        Actions actions = new Actions();
        BindingList<Produto> buscaPrrodutos = new BindingList<Produto>();
        BindingList<Produto> produtos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public CadastroProdutoPage()
        {
            ObterDados();
            InitializeComponent();
        }

        public void ObterDados()
        {
            produtos = new BindingList<Produto>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarCategoria novoFormulario = new CadastrarCategoria(); ;
            novoFormulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxes.Clear();
            textBoxes.Add(textNome.Text);
            textBoxes.Add(comboBoxFornecedor.Text);
            textBoxes.Add(textMarca.Text);
            textBoxes.Add(textGarantia.Text);

            actions.verifyBlanksTextboxes(textBoxes);

            int numGarantia;
            numGarantia = int.Parse(textGarantia.Text.Trim());

            foreach (var text in produtos)
            {
                if (text.nome.Equals(textNome.Text))
                {
                    MessageBox.Show("Este produto já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            int testeFornecedor_fk = 0;

            Produto produto = new Produto(id, textNome.Text.Trim().ToUpper(), testeFornecedor_fk , textMarca.Text.Trim(), numGarantia, dataAtual, dataAtual, Global.funcionarioLogado);
            produtos.Add(produto);
            repository.Add(produto);

            id++;

            textNome.Clear();
            textMarca.Clear();
            textGarantia.Clear();
        }
    }
}
