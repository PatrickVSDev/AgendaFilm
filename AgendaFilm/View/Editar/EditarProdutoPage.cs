using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using AgendaFilm.View.Cadastro.Cadastrar;
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
using static AgendaFilm.Utils.EstiloDataGridView;

namespace AgendaFilm.View.Editar
{
    public partial class EditarProdutoPage : Form
    {
        private Button btnFechar;
        private ProdutoRepositorio repository = new ProdutoRepositorio();
        private FornecedorRepositorio fornecedorRepositorio = new FornecedorRepositorio();
        private Actions actions = new Actions();
        private Produto produto;
        private Fornecedor fornecedorSelecionado;
        public event Action RefreshGrid;

        public EditarProdutoPage(Produto produto)
        {
            InitializeComponent();

            this.produto = produto;
            textNome.Text = produto.nome.Trim();
            textMarca.Text = produto.marca.Trim();
            textGarantia.Text = produto.garantia.ToString();

            fornecedorSelecionado = fornecedorRepositorio.getById(produto.fornecedor_fk);

            labelFornecedorSelecionado.Text = fornecedorSelecionado?.nome ?? "Fornecedor não informado";

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            BotaoFecharUtils.AplicarBotaoFechar(this);
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

        private void EditarProdutoPage_Load(object sender, EventArgs e) { }
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

        

        private void btSalvar_Click_1(object sender, EventArgs e)
        {
            List<string> textBoxes = new List<string> { textNome.Text, textMarca.Text, textGarantia.Text };
            actions.verifyBlanksTextboxes(textBoxes);

            if (!int.TryParse(textGarantia.Text.Trim(), out int garantia) || garantia < 0)
            {
                MessageBox.Show("Informe uma garantia válida (número inteiro positivo).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fornecedorSelecionado == null)
            {
                MessageBox.Show("Selecione um fornecedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            produto.nome = textNome.Text.Trim().ToUpper();
            produto.marca = textMarca.Text.Trim();
            produto.garantia = garantia;
            produto.fornecedor_fk = fornecedorSelecionado.id;
            produto.dataAlteracao = DateTime.Today;
            produto.funcionario_fk = Global.funcionarioLogado;

            repository.UpdateProduto(produto);

            RefreshGrid?.Invoke();
            this.Close();
        }

        private void btSelecionarFornecedor_Click_1(object sender, EventArgs e)
        {
            var selecionarForm = new SelecionarFornecedor();
            if (selecionarForm.ShowDialog() == DialogResult.OK)
            {
                fornecedorSelecionado = selecionarForm.FornecedorSelecionado;
                labelFornecedorSelecionado.Text = fornecedorSelecionado.nome;
            }
        }
    }
}
