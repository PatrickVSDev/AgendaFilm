using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Utils;
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

namespace AgendaFilm.View.Cadastro.Cadastrar
{
    public partial class SelecionarFornecedor : Form
    {
        FornecedorRepositorio repository = new FornecedorRepositorio();
        Actions actions = new Actions();
        BindingList<Fornecedor> buscaFornecedores = new BindingList<Fornecedor>();
        BindingList<Fornecedor> fornecedores;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;
        private Button btnFechar;
        public SelecionarFornecedor()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = fornecedores;
            ConfigurarColunasDataGridView();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            BotaoFecharUtils.AplicarBotaoFechar(this);
            EstiloDataGridView.AplicarEstiloPadrao(dataGridView1);

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
        public void ObterDados()
        {
            fornecedores = new BindingList<Fornecedor>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void ConfigurarColunasDataGridView()
        {
            var colunas = dataGridView1.Columns;

            if (colunas.Contains("id"))
            {
                colunas["id"].HeaderText = "ID";
                colunas["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colunas["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (colunas.Contains("nome"))
            {
                colunas["nome"].HeaderText = "Nome";
                colunas["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colunas["nome"].DisplayIndex = colunas["id"].DisplayIndex + 1;
            }

            if (colunas.Contains("documento"))
            {
                colunas["documento"].HeaderText = "Documento";
                colunas["documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("telefone"))
            {
                colunas["telefone"].HeaderText = "Telefone";
                colunas["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("email"))
            {
                colunas["email"].HeaderText = "Email";
                colunas["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            if (colunas.Contains("dataCriacao"))
                colunas["dataCriacao"].Visible = false;
            if (colunas.Contains("funcionario_fk"))
                colunas["funcionario_fk"].Visible = false;
            if (colunas.Contains("dataAlteracao"))
                colunas["dataAlteracao"].Visible = false;
        }

        public Fornecedor FornecedorSelecionado { get; private set; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FornecedorSelecionado = (Fornecedor)dataGridView1.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisaNome.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(termo))
            {
                dataGridView1.DataSource = fornecedores;
                ConfigurarColunasDataGridView();
                return;
            }

            var resultado = fornecedores
                .Where(f => f.nome != null && f.nome.ToLower().Contains(termo))
                .ToList();

            dataGridView1.DataSource = new BindingList<Fornecedor>(resultado);
            ConfigurarColunasDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


