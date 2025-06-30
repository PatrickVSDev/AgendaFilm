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
using static System.Runtime.InteropServices.JavaScript.JSType;
using AgendaFilm.View.Agendamento;
using AgendaFilm.View.Cadastro;
using static System.Windows.Forms.DataFormats;
using static AgendaFilm.Utils.EstiloDataGridView;

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

        private Button btnFechar; // Botão "X"

        public event Action RefreshGrid;

        public CadastroProdutoPage()
        {
            ObterDados();
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            BotaoFecharUtils.AplicarBotaoFechar(this);
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxes.Clear();
            textBoxes.Add(textNome.Text);
            textBoxes.Add(textMarca.Text);
            textBoxes.Add(textGarantia.Text);

            actions.verifyBlanksTextboxes(textBoxes);

            int numGarantia;
            if (!int.TryParse(textGarantia.Text.Trim(), out numGarantia) || numGarantia < 0)
            {
                MessageBox.Show("Informe um valor numérico válido para a garantia (número inteiro positivo).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var text in produtos)
            {
                if (text.nome.Equals(textNome.Text))
                {
                    MessageBox.Show("Este produto já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            if (fornecedorSelecionado == null)
            {
                MessageBox.Show("Selecione um fornecedor!");
                return;
            }

            int fornecedorId = fornecedorSelecionado.id;

            Produto produto = new Produto(id, textNome.Text.Trim().ToUpper(), fornecedorId, textMarca.Text.Trim(), numGarantia, dataAtual, dataAtual, Global.funcionarioLogado);

            produtos.Add(produto);
            repository.Add(produto);

            id++;

            textNome.Clear();
            textMarca.Clear();
            textGarantia.Clear();

            RefreshGrid?.Invoke();
            this.Close();
        }

        private Fornecedor fornecedorSelecionado = null;

        private void button1_Click_1(object sender, EventArgs e)
        {
            SelecionarFornecedor formSelecionar = new SelecionarFornecedor();
            if (formSelecionar.ShowDialog() == DialogResult.OK)
            {
                fornecedorSelecionado = formSelecionar.FornecedorSelecionado;
                labelFornecedorSelecionado.Text = fornecedorSelecionado.nome;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // ============== Borda Preta ==============
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

        // ============== Botão "X" ==============
        
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

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.Black;
            int espessuraBorda = 1;

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
 