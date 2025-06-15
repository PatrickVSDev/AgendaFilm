using AgendaFilm.Controller;
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

        public event Action RefreshGrid;

        public CadastroFornecedorPage()
        {
            ObterDados();
            InitializeComponent();
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
                numCnpj = long.Parse(textDocumento.Text.Trim());
                numTel = long.Parse(textTelefone.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Você tem que digitar apenas numeros no campo de Documento", "Error", MessageBoxButtons.OK);
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
    }
}
