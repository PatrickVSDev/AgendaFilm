using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaFilm.View.OrdemDeServiço
{
    public partial class CriarOrdemDeServiço : Form
    {
        public CriarOrdemDeServiço()
        {
            this.StartPosition = FormStartPosition.Manual;
            InitializeComponent();
        }

        private AgendamentoDTO agendamentoSelecionado;
        private List<OrdemProduto> produtosSelecionados = new List<OrdemProduto>();


        private void CriarOrdemDeServiço_Load(object sender, EventArgs e)
        {
            if (dgvAgendamento.Columns.Count == 0)
            {
                dgvAgendamento.Columns.Add("Id", "ID");
                dgvAgendamento.Columns.Add("Cliente", "Cliente");
                dgvAgendamento.Columns.Add("Veiculo", "Veículo");
                dgvAgendamento.Columns.Add("DataHora", "Data/Hora");
                dgvAgendamento.Columns.Add("Observacoes", "Observações");
                dgvAgendamento.Columns.Add("Funcionario", "Funcionário");
            }

            dgvAgendamento.Columns["Id"].Width = 50;
            dgvAgendamento.Columns["Cliente"].Width = 150;
            dgvAgendamento.Columns["Veiculo"].Width = 120;
            dgvAgendamento.Columns["DataHora"].Width = 130;
            dgvAgendamento.Columns["Observacoes"].Width = 180;
            dgvAgendamento.Columns["Funcionario"].Width = 150;

            dgvAgendamento.ReadOnly = true;
            dgvAgendamento.AllowUserToAddRows = false;
            dgvAgendamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgvProdutos.Columns.Count == 0)
            {
                dgvProdutos.Columns.Add("ProdutoId", "Produto ID");
                dgvProdutos.Columns.Add("Nome", "Nome do Produto");
                dgvProdutos.Columns.Add("PrecoUnitario", "Preço Unitário");
                dgvProdutos.Columns.Add("Quantidade", "Quantidade");
            }

            dgvProdutos.ReadOnly = true;
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new SelecionarProduto())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    produtosSelecionados = form.ProdutosSelecionados; // propriedade pública no form filho

                    dgvProdutos.Rows.Clear();
                    foreach (var p in produtosSelecionados)
                    {
                        var produtoOriginal = new ProdutoRepositorio().getById(p.ProdutoId);
                        dgvProdutos.Rows.Add(p.ProdutoId, produtoOriginal?.nome ?? "Desconhecido", p.PrecoUnitario, p.Quantidade);
                    }

                    decimal total = produtosSelecionados.Sum(p => p.PrecoUnitario * p.Quantidade);
                    txtValor.Text = total.ToString("C");
                }
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.DarkSlateGray;
            int espessuraBorda = 8;
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.Black;
            int espessuraBorda = 4;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label3_Paint(object sender, PaintEventArgs e)
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

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
        private void groupBox2_Paint1(object sender, PaintEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            using (var form = new SelecionarAgendamento())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    agendamentoSelecionado = form.AgendamentoSelecionado;

                    dgvAgendamento.Rows.Clear();

                    dgvAgendamento.Rows.Add(
                        agendamentoSelecionado.id,
                        agendamentoSelecionado.nome_cliente,
                        agendamentoSelecionado.placa_veiculo,
                        agendamentoSelecionado.dataHoraAgendamento.ToString("dd/MM/yyyy HH:mm"),
                        agendamentoSelecionado.observacoes,
                        agendamentoSelecionado.nome_funcionario
                    );
                }
            }
        }


        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            if (agendamentoSelecionado == null || produtosSelecionados.Count == 0)
            {
                MessageBox.Show("Selecione um agendamento e pelo menos um produto.");
                return;
            }

            var ordem = new OrdemServico
            {
                AgendamentoId = agendamentoSelecionado.id,
                Observacoes = txtObservacoes.Text,
                Status = "a fazer",
                FuncionarioId = Global.funcionarioLogado, // se estiver usando controle de login
                DataCriacao = DateTime.Now,
                DataAlteracao = DateTime.Now
            };

            var controller = new OrdemServicoController();
            bool sucesso = controller.Cadastrar(ordem, produtosSelecionados);

            if (sucesso)
            {
                MessageBox.Show("Ordem de serviço criada com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao criar a ordem de serviço.");
            }
        }
    }
}
