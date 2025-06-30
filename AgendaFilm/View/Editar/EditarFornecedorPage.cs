using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
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
    public partial class EditarFornecedorPage : Form
    {
        FornecedorRepositorio repository = new FornecedorRepositorio();
        public Fornecedor fornecedor { get; set; }
        Actions actions = new Actions();

        public event Action RefreshGrid;
        private Button btnFechar; // Botão "X"

        public EditarFornecedorPage(Fornecedor fornecedor)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;
            textDocumento.Text = fornecedor.documento.Trim();
            textNome.Text = fornecedor.nome.Trim();
            textTelefone.Text = fornecedor.telefone.Trim();
            textEmail.Text = fornecedor.email.Trim();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            BotaoFecharUtils.AplicarBotaoFechar(this);
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void groupBox7_Enter(object sender, EventArgs e) { }

        private void groupBox4_Enter(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void EditarFornecedorPage_Load(object sender, EventArgs e) { }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string documento = textDocumento.Text.Trim();
            string nome = textNome.Text.Trim();
            string telefone = textTelefone.Text.Trim();
            string email = textEmail.Text.Trim();

            var fornecedores = repository.GetAll();
            foreach (var f in fornecedores)
            {
                if (f.documento == documento && f.id != fornecedor.id)
                {
                    MessageBox.Show("Este CNPJ já está cadastrado no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!DocumentoUtils.ValidarCNPJ(documento))
            {
                MessageBox.Show("CNPJ inválido. Verifique o valor informado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(telefone, out long telefoneNumerico) || telefone.Length != 11)
            {
                MessageBox.Show("O telefone deve conter apenas números e ter 11 dígitos (incluindo DDD).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fornecedor.documento = documento;
            fornecedor.nome = nome;
            fornecedor.telefone = telefone;
            fornecedor.email = email;
            fornecedor.dataAlteracao = DateTime.Today;
            fornecedor.funcionario_fk = Global.funcionarioLogado;

            repository.UpdateFornecedor(fornecedor);
            RefreshGrid?.Invoke();
            this.Close();
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

        
    }
}
