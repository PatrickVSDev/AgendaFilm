using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static AgendaFilm.Utils.EstiloDataGridView;

namespace AgendaFilm.View.Agendamento
{
    public partial class AgendarPage : Form
    {
        private readonly AgendamentoRepositorio repository = new AgendamentoRepositorio();
        private readonly Actions actions = new Actions();
        private readonly DateTime dataAtual = DateTime.Today;
        private DateTime dataHoraAgendamento;
        private string observacoes;
        private int id;

        public event Action RefreshGrid;

        public int clienteIdRecebido { get; set; } = -1;
        public int veiculoIdRecebido { get; set; } = -1;

        private Button btnFechar; 

        public AgendarPage()
        {
            InitializeComponent();
            ObterDados();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            BotaoFecharUtils.AplicarBotaoFechar(this);
        }

        public void ObterDados()
        {
            id = repository.getHighestId() + 1;
        }

        public void AtualizarIdCliente(int clienteId) => clienteIdRecebido = clienteId;
        public void AtualizarIdVeiculo(int veiculoId) => veiculoIdRecebido = veiculoId;

        private void AgendarPage_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new SelecionarVeiculoAgenda(clienteIdRecebido, this);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new SelecionarClienteAgenda(this);
            form.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataHoraAgendamento = dateTimePicker1.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            observacoes = txtObservacoes.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clienteIdRecebido == -1)
            {
                MessageBox.Show("Por favor, selecione um cliente antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (veiculoIdRecebido == -1)
            {
                MessageBox.Show("Por favor, selecione um veículo antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataHoraAgendamento = dateTimePicker1.Value;

            if (dataHoraAgendamento < DateTime.Now)
            {
                MessageBox.Show("Não é possível agendar para uma data e hora no passado.", "Data inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataHoraAgendamento.Hour < 8 || dataHoraAgendamento.Hour > 18)
            {
                DialogResult resultado = MessageBox.Show("O horário selecionado está fora do horário comercial (08:00 às 18:00). Deseja continuar?", "Horário fora do expediente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                    return;
            }

            var novoAgendamento = new Agendamentos(
                id,
                clienteIdRecebido,
                veiculoIdRecebido,
                dataHoraAgendamento,
                observacoes,
                dataAtual,
                dataAtual,
                Global.funcionarioLogado
            );

            repository.Add(novoAgendamento);

            lbIdCliente.Text = string.Empty;
            lbNomeCliente.Text = string.Empty;
            lbIdVeiculo.Text = string.Empty;
            lbPlacaVeiculo.Text = string.Empty;
            txtObservacoes.Clear();

            id++;

            RefreshGrid?.Invoke();
            this.Close();
        }


        private void lbPlacaVeiculo_Click(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
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

        private void groupBox2_Enter(object sender, EventArgs e) { }

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


       

        private void label5_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Paint(object sender, PaintEventArgs e)
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
    }
}
