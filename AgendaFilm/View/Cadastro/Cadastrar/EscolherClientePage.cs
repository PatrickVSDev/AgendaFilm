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
using static AgendaFilm.Utils.EstiloDataGridView;
using AgendaFilm.Utils;

namespace AgendaFilm.View.Cadastro.Cadastrar
{
    public partial class EscolherClientePage : Form
    {
        ClienteRepositorio repository = new ClienteRepositorio();
        Actions actions = new Actions();
        BindingList<Cliente> buscaClientes = new BindingList<Cliente>();
        BindingList<Cliente> clientes;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        private Button btnFechar;
        public Cliente ClienteSelecionado { get; private set; }

        public EscolherClientePage()
        {
            InitializeComponent();
            ObterDados();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            BotaoFecharUtils.AplicarBotaoFechar(this);
            EstiloDataGridView.AplicarEstiloPadrao(dataGridView1);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
            ConfigurarColunasDataGridView();
        }

        public void ObterDados()
        {
            clientes = new BindingList<Cliente>(repository.GetAll());
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

            if (colunas.Contains("tipo_cliente"))
            {
                colunas["tipo_cliente"].HeaderText = "Tipo de Cliente";
                colunas["tipo_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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

            if (colunas.Contains("funcionario_fk"))
            {
                colunas["funcionario_fk"].HeaderText = "Funcionário";
                colunas["funcionario_fk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("dataCriacao"))
            {
                colunas["dataCriacao"].HeaderText = "Data de Criação";
                colunas["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                colunas["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("funcionario_fk"))
                colunas["funcionario_fk"].Visible = false;
            if (colunas.Contains("dataCriacao"))
                colunas["dataCriacao"].Visible = false;
            if (colunas.Contains("dataAlteracao"))
                colunas["dataAlteracao"].Visible = false;
        }
        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int clienteId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                string clienteNome = dataGridView1.SelectedRows[0].Cells["nome"].Value.ToString();

                CadastroVeiculoPage cadastroVeiculoPage = (CadastroVeiculoPage)Application.OpenForms["CadastroVeiculoPage"];

                if (cadastroVeiculoPage != null)
                {
                    cadastroVeiculoPage.clienteIdRecebido = clienteId;
                    cadastroVeiculoPage.SetarNomeCliente(clienteNome);
                }
                else
                {
                    MessageBox.Show("A tela de destino não está aberta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void EscolherClientePage_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string termo = txtPesquisaNome.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(termo))
            {
                dataGridView1.DataSource = clientes;
                ConfigurarColunasDataGridView();
                return;
            }

            var resultado = clientes
                .Where(c => c.nome != null && c.nome.ToLower().Contains(termo))
                .ToList();

            dataGridView1.DataSource = new BindingList<Cliente>(resultado);
            ConfigurarColunasDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
