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
using AgendaFilm.Utils;
using static AgendaFilm.Utils.EstiloDataGridView;

namespace AgendaFilm.View.OrdemDeServiço
{
    public partial class SelecionarProduto : Form
    {
        ProdutoRepositorio repository = new ProdutoRepositorio();
        BindingList<Produto> produtos;
        public List<OrdemProduto> ProdutosSelecionados { get; private set; } = new List<OrdemProduto>();

        private Button btnFechar;

        public SelecionarProduto()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            BotaoFecharUtils.AplicarBotaoFechar(this);
            ObterDados();
            InicializarDataGridView();
            EstiloDataGridView.AplicarEstiloPadrao(dgvProdutos);
        }

        private void ObterDados()
        {
            produtos = new BindingList<Produto>(repository.GetAll());
        }

        private void InicializarDataGridView()
        {
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.Columns.Clear();

            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                HeaderText = "ID",
                Name = "ProdutoId",
                ReadOnly = true,
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nome",
                HeaderText = "Nome",
                Name = "Nome",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Preço Unitário",
                Name = "PrecoUnitario",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantidade",
                Name = "Quantidade",
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvProdutos.DataSource = produtos;

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["PrecoUnitario"].Value = 0.00m;
                    row.Cells["Quantidade"].Value = 1;
                }
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            ProdutosSelecionados.Clear();

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (row.IsNewRow) continue;

                var isPrecoOk = decimal.TryParse(row.Cells["PrecoUnitario"].Value?.ToString(), out decimal preco);
                var isQtdOk = int.TryParse(row.Cells["Quantidade"].Value?.ToString(), out int qtd);

                if (isPrecoOk && isQtdOk && preco > 0 && qtd > 0)
                {
                    var produtoId = Convert.ToInt32(row.Cells["ProdutoId"].Value);

                    ProdutosSelecionados.Add(new OrdemProduto
                    {
                        ProdutoId = produtoId,
                        PrecoUnitario = preco,
                        Quantidade = qtd
                    });
                }
                else if (isPrecoOk || isQtdOk)
                {
                    MessageBox.Show("Preencha corretamente o preço unitário e a quantidade para todos os produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (ProdutosSelecionados.Count == 0)
            {
                MessageBox.Show("Informe ao menos um produto com preço e quantidade válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
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

        

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.DarkSlateGray;
            int espessuraBorda = 5;
            int raio = 10;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Size textSize = TextRenderer.MeasureText(box.Text, box.Font);
            Rectangle rect = new Rectangle(0, textSize.Height / 2, box.Width - 1, box.Height - textSize.Height / 2 - 1);

            e.Graphics.Clear(box.BackColor);

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

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            string termo = textBoxPesquisar.Text.Trim().ToUpper();
            List<Produto> todos = repository.GetAll();

            var valoresManuais = new Dictionary<int, (decimal preco, int qtd)>();

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (!row.IsNewRow &&
                    int.TryParse(row.Cells["ProdutoId"].Value?.ToString(), out int produtoId) &&
                    decimal.TryParse(row.Cells["PrecoUnitario"].Value?.ToString(), out decimal preco) &&
                    int.TryParse(row.Cells["Quantidade"].Value?.ToString(), out int qtd))
                {
                    valoresManuais[produtoId] = (preco, qtd);
                }
            }

            List<Produto> listaFiltrada;

            if (radioTodos.Checked)
            {
                listaFiltrada = todos;
            }
            else if (radioNome.Checked)
            {
                listaFiltrada = todos
                    .Where(p => p.nome != null && p.nome.ToUpper().Contains(termo))
                    .ToList();
            }
            else if (radioId.Checked && int.TryParse(termo, out int id))
            {
                listaFiltrada = todos
                    .Where(p => p.id == id)
                    .ToList();
            }
            else
            {
                MessageBox.Show("Informe um valor válido para a pesquisa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            produtos = new BindingList<Produto>(listaFiltrada);
            dgvProdutos.DataSource = produtos;

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (!row.IsNewRow &&
                    int.TryParse(row.Cells["ProdutoId"].Value?.ToString(), out int produtoId) &&
                    valoresManuais.ContainsKey(produtoId))
                {
                    row.Cells["PrecoUnitario"].Value = valoresManuais[produtoId].preco;
                    row.Cells["Quantidade"].Value = valoresManuais[produtoId].qtd;
                }
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelecionarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
