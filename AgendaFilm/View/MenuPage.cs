using AgendaFilm.Controller;
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
using AgendaFilm.Model.Repositories;
using AgendaFilm.View.Agendamento;
using AgendaFilm.View.OrdemDeServiço;
using System.Drawing.Drawing2D;
namespace AgendaFilm
{
    public partial class MenuPage : Form
    {
        Actions actions = new Actions();
        FuncionarioRepositorio repositoryFuncionario = new FuncionarioRepositorio();

        private Button btnFechar;
        DateTime time;

        public MenuPage()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1280, 680);
            this.WindowState = FormWindowState.Normal;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.FormClosed += MenuPage_FormClosed;

            lbUsuarioLogado.Text = repositoryFuncionario.getNameById(Global.funcionarioLogado);

            InicializarBotaoFechar();

            // >>> NÃO chamar o arredondamento aqui
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

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
                return;

            base.WndProc(ref m);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        // >>> MÉTODO PARA ARREDONDAR A PICTUREBOX
        private void ArredondarPictureBox(PictureBox pic, int raio, Color corBorda, int espessuraBorda)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, raio, raio, 180, 90);
            gp.AddArc(pic.Width - raio, 0, raio, raio, 270, 90);
            gp.AddArc(pic.Width - raio, pic.Height - raio, raio, raio, 0, 90);
            gp.AddArc(0, pic.Height - raio, raio, raio, 90, 90);
            gp.CloseFigure();

            pic.Region = new Region(gp);

            pic.Paint += (sender, e) =>
            {
                using (Pen pen = new Pen(corBorda, espessuraBorda))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, gp);
                }
            };
        }

        // >>> CHAMAR ARREDONDAMENTO NO LOAD DO FORM
        private void MenuPage_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CadastroPage novoFormulario = new CadastroPage();
            novoFormulario.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) { }


        private void PaginaRestrita_Load(object sender, EventArgs e) 
        {
            ArredondarPictureBox(pictureBox4, 30 ,Color.DarkSlateGray, 3);
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            AgendamentoPage novoFormulario = new AgendamentoPage();
            novoFormulario.ShowDialog();
        }

        private void AplicarEstilo() { }

        private void Relatorios_Click(object sender, EventArgs e)
        {
            OrdemDeServiço novoFormulario = new OrdemDeServiço();
            novoFormulario.ShowDialog();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e) { }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time = DateTime.Now;
            lDataMenu.Text = time.ToShortDateString() + " " + time.ToLongTimeString();
        }

        private void MenuPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbUsuarioLogado_Click(object sender, EventArgs e) { }

        private void pictureBox3_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void pictureBox4_Click(object sender, EventArgs e) { }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaginaLogin novoFormulario = new PaginaLogin();
            novoFormulario.ShowDialog();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.DarkSlateGray;  // Cor da borda
            int espessuraBorda = 3;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Calcula espaço do texto
            Size textSize = TextRenderer.MeasureText(box.Text, box.Font);
            Rectangle rect = new Rectangle(0, textSize.Height / 2, box.Width - 1, box.Height - textSize.Height / 2 - 1);

            // Limpa o fundo para remover a borda padrão
            e.Graphics.Clear(box.BackColor);

            using (Pen pen = new Pen(corBorda, espessuraBorda))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Adiciona um retângulo com cantos quadrados
                path.AddRectangle(rect);

                // Desenha a borda
                e.Graphics.DrawPath(pen, path);
            }

            // Desenha o texto do GroupBox
            using (SolidBrush brush = new SolidBrush(box.ForeColor))
            {
                e.Graphics.DrawString(box.Text, box.Font, brush, 10, 0);
            }
        }
    }
}
