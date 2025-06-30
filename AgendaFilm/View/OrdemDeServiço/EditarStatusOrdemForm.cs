using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static AgendaFilm.Utils.EstiloDataGridView;

namespace AgendaFilm.View.OrdemDeServiço
{
    public partial class EditarStatusOrdemForm : Form
    {
        public string NovoStatus { get; private set; }

        private Button btnFechar; // Botão "X"

        public EditarStatusOrdemForm(string statusAtual)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            BotaoFecharUtils.AplicarBotaoFechar(this);

            comboBoxStatus.Items.AddRange(new string[] { "A FAZER", "EM ANDAMENTO", "FINALIZADO" });
            comboBoxStatus.SelectedItem = statusAtual;
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecione um status.");
                return;
            }

            NovoStatus = comboBoxStatus.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditarStatusOrdemForm_Load(object sender, EventArgs e)
        {

        }

        // ====================== BORDA ======================
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

        // ====================== BOTÃO "X" ======================
        
        // ====================== LABEL COM BORDA ======================
        private void label1_Click(object sender, EventArgs e)
        {

        }

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
    }
}
