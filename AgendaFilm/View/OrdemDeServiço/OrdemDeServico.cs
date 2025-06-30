using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaFilm.View.OrdemDeServiço
{
    public partial class OrdemDeServico : Form
    {
        private Form formularioAberto;
        private Button botaoSelecionado = null;

        public OrdemDeServico()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(316, 180);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        private void OrdemDeServiço_Load(object sender, EventArgs e)
        {
            CriarOrdemDeServiço criarOrdem = new CriarOrdemDeServiço();
            criarOrdem.StartPosition = FormStartPosition.Manual;
            criarOrdem.Location = new Point(this.Location.X + 218, this.Location.Y + 98);  // 👉 Aqui você define onde ele vai abrir na tela
            criarOrdem.Owner = this;
            criarOrdem.Show();

        }
       
        // ✅ Função para selecionar botão (fica colorido)
        private void SelecionarBotao(Button botao)
        {
            if (botaoSelecionado != null)
            {
                botaoSelecionado.BackColor = Color.DarkSlateGray;
                botaoSelecionado.ForeColor = Color.Black;
            }

            botao.BackColor = Color.LightSeaGreen;
            botao.ForeColor = Color.Black;

            botaoSelecionado = botao;
        }

        // ✅ Função para abrir formulário dentro deste
        private void AbrirFormulario(Form novoFormulario, Point localizacao)
        {
            if (formularioAberto != null)
            {
                formularioAberto.Close();
                formularioAberto = null;
            }

            formularioAberto = novoFormulario;
            formularioAberto.Owner = this;
            formularioAberto.StartPosition = FormStartPosition.Manual;
            formularioAberto.Location = localizacao;
            formularioAberto.FormBorderStyle = FormBorderStyle.None;
            formularioAberto.TopLevel = true;
            formularioAberto.Show();
        }

        // ✅ Botão "Criar Ordem de Serviço"
        private void button1_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new CriarOrdemDeServiço(),
                new Point(this.Location.X + 218, this.Location.Y + 98));
        }

        // ✅ Botão "Finalizar Ordem de Serviço"
        private void button2_Click(object sender, EventArgs e)
        {
            SelecionarBotao((Button)sender);
            AbrirFormulario(new FinalizarOrdemDeServiço(),
                new Point(this.Location.X + 218, this.Location.Y + 98));
        }

        // ✅ Validação de valores em reais no TextBox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            string textoLimpo = txt.Text.Replace("R$", "").Trim();

            if (!decimal.TryParse(textoLimpo, out decimal valor))
            {
                if (txt.Text != "")
                {
                    MessageBox.Show("Digite somente valores em reais!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Text = "";
                }
            }
        }

        // ✅ Desenhar borda arredondada no groupBox
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

        // ✅ Desenhar borda no próprio formulário
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

        // 🔸 Eventos que você pode implementar se quiser
        private void label1_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void button6_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
