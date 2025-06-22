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

namespace AgendaFilm.View.OrdemDeServiço
{
    public partial class SelecionarAgendamento : Form
    {
        private Button btnFechar;

        AgendamentoRepositorio repository = new AgendamentoRepositorio();
        Actions actions = new Actions();
        BindingList<dynamic> buscaAgendamentos = new BindingList<dynamic>();
        BindingList<AgendamentoDTO> agendamentos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public SelecionarAgendamento()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarBotaoFechar();
            ObterDados(DateTime.Today);
            ConfigurarDataGridView();
        }

        public void ObterDados(DateTime? dataFiltro = null)
        {
            var todos = repository.getAll();

            if (dataFiltro.HasValue)
            {
                todos = todos
                    .Where(a => a.dataHoraAgendamento.Date == dataFiltro.Value.Date)
                    .ToList();
            }

            agendamentos = new BindingList<AgendamentoDTO>(todos);
            id = repository.getHighestId() + 1;
        }

        private void AtualizarDataGridView(DateTime? dataFiltro = null)
        {
            ObterDados(dataFiltro);

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = agendamentos;

            ConfigurarColunas();
        }



        private void AtualizarDataGridView()
        {
            AtualizarDataGridView(DateTime.Today);
        }



        private void ConfigurarDataGridView()
        {

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = agendamentos;

            ConfigurarColunas();

        }

        private void ConfigurarColunas()
        {
            if (dataGridView1.Columns.Contains("id"))
                dataGridView1.Columns["id"].HeaderText = "ID";

            if (dataGridView1.Columns.Contains("nome_cliente"))
                dataGridView1.Columns["nome_cliente"].HeaderText = "Cliente";

            if (dataGridView1.Columns.Contains("placa_veiculo"))
                dataGridView1.Columns["placa_veiculo"].HeaderText = "Placa";

            if (dataGridView1.Columns.Contains("modelo_veiculo"))
                dataGridView1.Columns["modelo_veiculo"].HeaderText = "Veículo";

            if (dataGridView1.Columns.Contains("dataHoraAgendamento"))
                dataGridView1.Columns["dataHoraAgendamento"].HeaderText = "Data/Hora";

            if (dataGridView1.Columns.Contains("observacoes"))
                dataGridView1.Columns["observacoes"].HeaderText = "Observações";

            if (dataGridView1.Columns.Contains("dataCriacao"))
            {
                dataGridView1.Columns["dataCriacao"].HeaderText = "Data Criação";
                dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dataGridView1.Columns.Contains("dataAlteracao"))
            {
                dataGridView1.Columns["dataAlteracao"].HeaderText = "Última Alteração";
                dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dataGridView1.Columns.Contains("nome_funcionario"))
                dataGridView1.Columns["nome_funcionario"].HeaderText = "Funcionário";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.ValueType == typeof(string))
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                else
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void SelecionarAgendamento_Load(object sender, EventArgs e)
        {

        }

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

        private void InicializarBotaoFechar()
        {
            btnFechar = new Button();
            btnFechar.Text = "✕";
            btnFechar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnFechar.Size = new Size(35, 35);
            btnFechar.Location = new Point(this.Width - 45, 5);
            btnFechar.BackColor = Color.FromArgb(220, 53, 69);
            btnFechar.ForeColor = Color.White;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnFechar.Click += (s, e) => this.Close();
            btnFechar.MouseEnter += (s, e) => btnFechar.BackColor = Color.FromArgb(255, 99, 117);
            btnFechar.MouseLeave += (s, e) => btnFechar.BackColor = Color.FromArgb(220, 53, 69);

            btnFechar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFechar.Width, btnFechar.Height, 10, 10));
            this.Controls.Add(btnFechar);
            btnFechar.BringToFront();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        public AgendamentoDTO AgendamentoSelecionado { get; private set; }


        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                AgendamentoSelecionado = agendamentos.FirstOrDefault(a => a.id == idSelecionado);

                if (AgendamentoSelecionado != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Agendamento não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um agendamento.");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFiltro_ValueChanged(object sender, EventArgs e)
        {
            AtualizarDataGridView(dateTimePickerFiltro.Value.Date);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
