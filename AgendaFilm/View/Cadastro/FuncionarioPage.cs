using AgendaFilm.Controller;
using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Utils;
using AgendaFilm.View.Editar;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace AgendaFilm
{
    public partial class FuncionarioPage : Form
    {
        FuncionarioRepositorio repository = new FuncionarioRepositorio();
        Actions actions = new Actions();
        BindingList<Funcionario> buscaFuncionarios = new BindingList<Funcionario>();
        BindingList<Funcionario> funcionarios;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public FuncionarioPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = funcionarios;
            EstiloDataGridView.AplicarEstiloPadrao(dataGridView1);
            ConfigurarColunasDataGridView();
        }

        public void ObterDados()
        {
            var todos = repository.GetAll();

            var filtrados = todos
                .Where(f => !f.nome.Equals("ADMINISTRADOR", StringComparison.OrdinalIgnoreCase))
                .ToList();

            funcionarios = new BindingList<Funcionario>(filtrados);
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

            if (colunas.Contains("telefone"))
            {
                colunas["telefone"].HeaderText = "Telefone";
                colunas["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("cargo"))
            {
                colunas["cargo"].HeaderText = "Cargo";
                colunas["cargo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            if (colunas.Contains("nivelAcesso"))
            {
                colunas["nivelAcesso"].HeaderText = "Nivel de Acesso";
                colunas["nivelAcesso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("dataAlteracao"))
            {
                colunas["dataAlteracao"].HeaderText = "Última Alteração";
                colunas["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                colunas["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (colunas.Contains("dataCriacao"))
                colunas["dataCriacao"].Visible = false;
            if (colunas.Contains("funcionarioAlteracao"))
                colunas["funcionarioAlteracao"].Visible = false;
            dataGridView1.Columns["senha"].Visible = false;
            dataGridView1.Columns["login"].Visible = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Point buttonScreenPosition = button1.PointToScreen(Point.Empty);

            // Defina a posição do novo formulário usando o ponto do botão
            CadastroFuncionarioPage novoFormulario = new CadastroFuncionarioPage();
            //novoFormulario.StartPosition = FormStartPosition.CenterScreen; // Defina a posição manualmente
            //novoFormulario.Location = new Point(buttonScreenPosition.X + 100, buttonScreenPosition.Y - 50);
            novoFormulario.RefreshGrid += AtualizarDataGridView;
            novoFormulario.ShowDialog();
        }

        private void AtualizarDataGridView()
        {
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = funcionarios;
            ConfigurarColunasDataGridView();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[i];
                    Funcionario funcionarioSelecionado = row.DataBoundItem as Funcionario;

                    if (funcionarioSelecionado == null)
                        continue;

                    if (funcionarioSelecionado.id == Global.funcionarioLogado)
                    {
                        MessageBox.Show("Você não pode excluir o próprio usuário logado.", "Operação não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    if (repository.FuncionarioTemRelacionamentos(funcionarioSelecionado.id))
                    {
                        MessageBox.Show($"Não é possível excluir o funcionário '{funcionarioSelecionado.nome}' pois ele está vinculado a registros no sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    DialogResult confirmacao = MessageBox.Show(
                        $"Tem certeza que deseja excluir o funcionário '{funcionarioSelecionado.nome}'?",
                        "Confirmação de Exclusão",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmacao == DialogResult.Yes)
                    {
                        funcionarios.Remove(funcionarioSelecionado);
                        buscaFuncionarios.Remove(funcionarioSelecionado);
                        repository.RemoveFuncionario(funcionarioSelecionado);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum funcionário selecionado", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                Funcionario funcionarioSelecionado = dataGridViewRow.DataBoundItem as Funcionario;

                EditarFuncionarioPage novoFormulario = new EditarFuncionarioPage(funcionarioSelecionado);
                int index = funcionarios.IndexOf(funcionarioSelecionado);
                novoFormulario.RefreshGrid += AtualizarDataGridView;
                novoFormulario.ShowDialog();


                if (novoFormulario.DialogResult == DialogResult.OK)
                {
                    funcionarios[index] = novoFormulario.funcionario;
                }
            }
            else
            {
                MessageBox.Show("É possivel editar apenas um funcionário por vez!", "Error", MessageBoxButtons.OK);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            buscaFuncionarios.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaFuncionarios;
            ConfigurarColunasDataGridView();

            if (radioTodos.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = funcionarios;
                ConfigurarColunasDataGridView();
            }
            else
            {
                if (!(string.IsNullOrWhiteSpace(textBoxPesquisar.Text)))
                {
                    if (radioNome.Checked)
                    {

                        bool funcionarioExiste = false;

                        foreach (var funcionario in funcionarios)
                        {
                            if (funcionario.nome.Contains(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaFuncionarios.Add(funcionario);

                                funcionarioExiste = true;
                            }
                        }

                        if (!funcionarioExiste)
                        {
                            MessageBox.Show("Funcionário não está cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioId.Checked)
                    {
                        bool funcionarioExiste = false;

                        try
                        {
                            int numId = int.Parse(textBoxPesquisar.Text);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Você tem que digitar apenas numeros", "Error", MessageBoxButtons.OK);
                            return;
                        }


                        foreach (var funcionario in funcionarios)
                        {
                            if (funcionario.id == int.Parse(textBoxPesquisar.Text))
                            {
                                buscaFuncionarios.Add(funcionario);

                                funcionarioExiste = true;
                            }
                        }

                        if (!funcionarioExiste)
                        {
                            MessageBox.Show("Funcionário não está cadastrado", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else if (radioCargo.Checked)
                    {
                        bool funcionarioExiste = false;

                        foreach (var funcionario in funcionarios)
                        {
                            if (funcionario.cargo.Equals(textBoxPesquisar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                buscaFuncionarios.Add(funcionario);

                                funcionarioExiste = true;
                            }
                        }

                        if (!funcionarioExiste)
                        {
                            MessageBox.Show("Não há nenhum funcionário com este cargo, ou cargo inexistente", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Marque uma das opções de busca!", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Você não digitou nenhum termo para ser pesquisado!", "Error", MessageBoxButtons.OK);
                }
            }
            textBoxPesquisar.Clear();
            ConfigurarColunasDataGridView();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você quer gerar o relatorio em PDF?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                bool funcionarioExiste = false;
                List<Funcionario> funcionariosRelatorio = new List<Funcionario>();

                string pesquisa = RelatorioTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    funcionariosRelatorio.AddRange(funcionarios);
                    funcionarioExiste = funcionariosRelatorio.Count > 0;
                }
                else
                {
                    foreach (var funcionario in funcionarios)
                    {
                        if (funcionario.nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            funcionariosRelatorio.Add(funcionario);
                            funcionarioExiste = true;
                        }
                    }
                }

                if (!funcionarioExiste)
                {
                    MessageBox.Show("Nenhum funcionário com este nome!", "Erro", MessageBoxButtons.OK);
                    return;
                }

                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string dataAtual = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                string titulo = $"Relatório De Funcionários Por Nome - {dataAtual}";
                string nomeArquivo = $"relatorio-Funcionarios-Por-Nome-{dataAtual}.pdf";

                string tempFolder = Path.GetTempPath();
                string caminhoCompleto = Path.Combine(tempFolder, nomeArquivo);

                var todosFuncionarios = repository.GetAll();
                var relatorio = new RelatorioFuncionarios(funcionariosRelatorio, titulo, todosFuncionarios);
                relatorio.GeneratePdf(caminhoCompleto);

                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = caminhoCompleto,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Relatório gerado, mas não foi possível abrir automaticamente.\n{ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.DarkSlateGray;  // Cor da borda
            int espessuraBorda = 8;
            int raio = 10;  // Raio do arredondamento

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Calcula espaço do texto
            Size textSize = TextRenderer.MeasureText(box.Text, box.Font);
            Rectangle rect = new Rectangle(0, textSize.Height / 2, box.Width - 1, box.Height - textSize.Height / 2 - 1);

            // Limpa o fundo para remover a borda padrão
            e.Graphics.Clear(box.BackColor);

            using (Pen pen = new Pen(corBorda, espessuraBorda))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Adiciona um retângulo com cantos arredondados ao caminho
                path.AddArc(rect.Left, rect.Top, raio, raio, 180, 90);
                path.AddArc(rect.Right - raio, rect.Top, raio, raio, 270, 90);
                path.AddArc(rect.Right - raio, rect.Bottom - raio, raio, raio, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - raio, raio, raio, 90, 90);
                path.CloseFigure();

                // Desenha a borda
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
