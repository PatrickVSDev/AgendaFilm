using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
using AgendaFilm.Controller;

namespace AgendaFilm.View.OrdemDeServiço
{
    public partial class FinalizarOrdemDeServiço : Form
    {
        public FinalizarOrdemDeServiço()
        {
            InitializeComponent();
            ObterDados();
            AdicionarColunaEditarStatus();
            dataGridView1.CellPainting += dataGridView1_CellPainting;


        }

        private void ObterDados()
        {
            var repositorio = new OrdemServicoRepositorio();
            DateTime hoje = DateTime.Today;

            var ordens = repositorio.GetByDataCriacao(hoje);
            dataGridView1.DataSource = ordens;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["DataAlteracao"].Visible = false;
            dataGridView1.Columns["ClienteNome"].HeaderText = "Cliente";
            dataGridView1.Columns["VeiculoModelo"].HeaderText = "Modelo";
            dataGridView1.Columns["VeiculoPlaca"].HeaderText = "Placa";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["DataHoraAgendada"].HeaderText = "Data/Hora Agendada";
            dataGridView1.Columns["FuncionarioNome"].HeaderText = "Funcionário";
            dataGridView1.Columns["Produtos"].HeaderText = "Produtos";
            dataGridView1.Columns["ValorTotal"].HeaderText = "Total";
            dataGridView1.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
        }


        private void AdicionarColunaEditarStatus()
        {
            if (!dataGridView1.Columns.Contains("EditarStatus"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
                {
                    HeaderText = "Editar",
                    Name = "EditarStatus",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    Width = 70
                };
                dataGridView1.Columns.Insert(0, btnEditar);
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
            Color corBorda = Color.DarkSlateGray;
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



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.Black;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label2_Paint(object sender, PaintEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "EditarStatus")
            {
                int ordemId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                string statusAtual = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                using var form = new EditarStatusOrdemForm(statusAtual);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string novoStatus = form.NovoStatus;

                    var repo = new OrdemServicoRepositorio();
                    var ordem = repo.GetById(ordemId);
                    ordem.Status = novoStatus;
                    ordem.DataAlteracao = DateTime.Now;

                    repo.Update(ordem);

                    MessageBox.Show("Status atualizado com sucesso.");
                    ObterDados();
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "EditarStatus")
            {
                e.PaintBackground(e.CellBounds, true);

                Color corFundo = Color.DarkOrange;
                Color corTexto = Color.White;
                Color corBorda = Color.Chocolate;

                Rectangle rect = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2,
                                               e.CellBounds.Width - 4, e.CellBounds.Height - 4);

                using (SolidBrush brush = new SolidBrush(corFundo))
                using (Pen pen = new Pen(corBorda, 2))
                using (StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                {
                    e.Graphics.FillRectangle(brush, rect);

                    e.Graphics.DrawRectangle(pen, rect);

                    e.Graphics.DrawString("Editar", dataGridView1.Font, Brushes.White, rect, sf);
                }

                e.Handled = true;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var repositorio = new OrdemServicoRepositorio();

            string statusSelecionado = null;

            if (rbAFazer.Checked)
                statusSelecionado = "A FAZER";
            else if (rbEmAndamento.Checked)
                statusSelecionado = "EM ANDAMENTO";
            else if (rbFinalizado.Checked)
                statusSelecionado = "FINALIZADO";

            DateTime dataSelecionada = dtInicio.Value.Date;

            var ordens = repositorio.GetByStatusEData(statusSelecionado, dataSelecionada);

            dataGridView1.DataSource = ordens;
            dataGridView1.Columns["DataAlteracao"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma ordem de serviço para imprimir.");
                return;
            }

            int ordemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            var ordemRepo = new OrdemServicoRepositorio();
            var agendamentoRepo = new AgendamentoRepositorio();

            try
            {
                var ordem = ordemRepo.GetById(ordemId);
                if (ordem == null)
                {
                    MessageBox.Show("Ordem de serviço não encontrada.");
                    return;
                }

                var agendamento = agendamentoRepo.GetDTOById(ordem.AgendamentoId);
                if (agendamento == null)
                {
                    MessageBox.Show("Agendamento vinculado à ordem não encontrado.");
                    return;
                }

                var produtos = ordemRepo.GetProdutosByOrdemId(ordemId);
                if (produtos == null || produtos.Count == 0)
                {
                    MessageBox.Show("Nenhum produto vinculado à ordem de serviço.");
                    return;
                }

                string caminhoPdf = PdfOrdemServico.GerarPdfOrdemServico(ordem, agendamento, produtos);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = caminhoPdf,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF: " + ex.Message);
            }
        }

        private void FinalizarOrdemDeServiço_Load(object sender, EventArgs e)
        {

        }

        
    }
}
