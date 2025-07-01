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

namespace AgendaFilm.View.Agendamento
{
    public partial class SelecionarVeiculoAgenda : Form
    {
        private VeiculoRepositorio veiculoRepositorio = new VeiculoRepositorio();
        private AgendarPage agendaPage;
        private int clienteId;

        VeiculoRepositorio repository = new VeiculoRepositorio();
        Actions actions = new Actions();
        BindingList<Veiculo> buscaVeiculos = new BindingList<Veiculo>();
        BindingList<Veiculo> veiculos;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        private Button btnFechar;

        public SelecionarVeiculoAgenda(int clienteId, AgendarPage mainform)
        {
            InitializeComponent();
            this.clienteId = clienteId;
            agendaPage = mainform;

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            BotaoFecharUtils.AplicarBotaoFechar(this);
            EstiloDataGridView.AplicarEstiloPadrao(dataGridView1);
            ConfigurarColunasDataGridView();
        }

        public void ObterDados()
        {
            veiculos = new BindingList<Veiculo>(repository.GetAll());
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

            if (colunas.Contains("placa"))
            {
                colunas["placa"].HeaderText = "Placa";
                colunas["placa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colunas["placa"].DisplayIndex = colunas["id"].DisplayIndex + 1;
            }

            if (colunas.Contains("modelo"))
            {
                colunas["modelo"].HeaderText = "Modelo";
                colunas["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            if (colunas.Contains("ano"))
            {
                colunas["ano"].HeaderText = "Ano";
                colunas["ano"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("marca"))
            {
                colunas["marca"].HeaderText = "Marca";
                colunas["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            if (colunas.Contains("dataAlteracao"))
            {
                colunas["dataAlteracao"].HeaderText = "Última Alteração";
                colunas["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                colunas["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("dataCriacao"))
                colunas["dataCriacao"].Visible = false;
            if (colunas.Contains("dataAlteracao"))
                colunas["dataAlteracao"].Visible = false;
            if (colunas.Contains("funcionario_fk"))
                colunas["funcionario_fk"].Visible = false;
            if (colunas.Contains("cliente_fk"))
                colunas["cliente_fk"].Visible = false;
        }

        private void SelecionarVeiculoAgenda_Load(object sender, EventArgs e)
        {
            var veiculosFiltrados = veiculoRepositorio.GetAll()
                .Where(v => v.cliente_fk == clienteId)
                .ToList();

            dataGridView1.DataSource = veiculosFiltrados;
            ConfigurarColunasDataGridView();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int veiculoId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                agendaPage.lbIdVeiculo.Text = veiculoId.ToString();
                var placaVeiculo = repository.getPlacaById(veiculoId);
                agendaPage.lbPlacaVeiculo.Text = placaVeiculo;

                AgendarPage agendarPage = (AgendarPage)Application.OpenForms["AgendarPage"];

                if (agendarPage != null)
                {
                    agendarPage.veiculoIdRecebido = veiculoId;
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


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Paint(object sender, PaintEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RealizarBuscaVeiculo()
        {
            buscaVeiculos.Clear();
            dataGridView1.DataSource = null;

            if (radioTodos.Checked)
            {
                var todos = veiculoRepositorio.GetAll().Where(v => v.cliente_fk == clienteId).ToList();
                dataGridView1.DataSource = new BindingList<Veiculo>(todos);
                ConfigurarColunasDataGridView();
                return;
            }

            string termoBusca = textBoxPesquisar.Text.Trim();

            if (string.IsNullOrWhiteSpace(termoBusca))
            {
                MessageBox.Show("Você não digitou nenhum termo para ser pesquisado!", "Erro", MessageBoxButtons.OK);
                return;
            }

            bool veiculoExiste = false;

            var veiculosCliente = veiculoRepositorio.GetAll().Where(v => v.cliente_fk == clienteId).ToList();

            if (radioModelo.Checked)
            {
                foreach (var veiculo in veiculosCliente)
                {
                    if (veiculo.modelo.Contains(termoBusca, StringComparison.OrdinalIgnoreCase))
                    {
                        buscaVeiculos.Add(veiculo);
                        veiculoExiste = true;
                    }
                }

                if (!veiculoExiste)
                {
                    MessageBox.Show("Nenhum veículo encontrado com este modelo!", "Erro", MessageBoxButtons.OK);
                }
            }
            else if (radioId.Checked)
            {
                if (!int.TryParse(termoBusca, out int numId))
                {
                    MessageBox.Show("Você tem que digitar apenas números para pesquisar por ID", "Erro", MessageBoxButtons.OK);
                    return;
                }

                foreach (var veiculo in veiculosCliente)
                {
                    if (veiculo.id == numId)
                    {
                        buscaVeiculos.Add(veiculo);
                        veiculoExiste = true;
                        break;
                    }
                }

                if (!veiculoExiste)
                {
                    MessageBox.Show("Veículo não cadastrado com esse ID", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Marque uma das opções de busca!", "Erro", MessageBoxButtons.OK);
                return;
            }

            dataGridView1.DataSource = veiculoExiste ? buscaVeiculos : null;
            dataGridView1.Refresh();
            ConfigurarColunasDataGridView();
            textBoxPesquisar.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RealizarBuscaVeiculo();
        }
    }
}
