using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AgendaFilm.Utils // <- esse namespace TEM que bater com o using da tela
{
    public static class EstiloDataGridView
    {
        public static void AplicarEstiloPadrao(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.DarkSlateGray;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.RowTemplate.Height = 45;
            dgv.ColumnHeadersHeight = 45;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static void AplicarBordaArredondada(TextBox textBox, int radius = 15)
        {
            Rectangle bounds = new Rectangle(0, 0, textBox.Width, textBox.Height);
            using (GraphicsPath path = new GraphicsPath())
            {
                float r = radius * 2f;
                path.AddArc(bounds.X, bounds.Y, r, r, 180, 90);
                path.AddArc(bounds.Right - r, bounds.Y, r, r, 270, 90);
                path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                textBox.Region = new Region(path);
            }

            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
            textBox.Font = new Font("Segoe UI", 11);
        }

        public static void AplicarTextBoxArredondadoComBorda(TextBox textBox, Form parentForm, int radius = 15)
        {
            Rectangle bounds = new Rectangle(0, 0, textBox.Width, textBox.Height);

            using (GraphicsPath path = new GraphicsPath())
            {
                float r = radius * 2f;
                path.AddArc(bounds.X, bounds.Y, r, r, 180, 90);
                path.AddArc(bounds.Right - r, bounds.Y, r, r, 270, 90);
                path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                textBox.Region = new Region(path);
            }

            textBox.BorderStyle = BorderStyle.None;
            textBox.Multiline = true; // obrigatório para Region funcionar corretamente
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
            textBox.Font = new Font("Segoe UI", 11);

            // Redesenhar a borda no evento Paint do formulário
            parentForm.Paint += (s, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    Rectangle bounds = textBox.Bounds;
                    float r = radius * 2f;

                    path.AddArc(bounds.X, bounds.Y, r, r, 180, 90);
                    path.AddArc(bounds.Right - r, bounds.Y, r, r, 270, 90);
                    path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
                    path.AddArc(bounds.X, bounds.Bottom - r, r, r, 90, 90);
                    path.CloseFigure();

                    using (Pen pen = new Pen(Color.Gray, 1.5f))
                    {
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
        }

        public static class BotaoFecharUtils
        {
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();

            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

            public static void AplicarBotaoFechar(Form form)
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.StartPosition = FormStartPosition.CenterScreen;

                Button botaoFechar = new Button();
                botaoFechar.Text = "✕"; // Ícone melhorado
                botaoFechar.ForeColor = Color.White;
                botaoFechar.BackColor = Color.FromArgb(220, 53, 69); // Vermelho elegante
                botaoFechar.FlatStyle = FlatStyle.Flat;
                botaoFechar.FlatAppearance.BorderSize = 0;
                botaoFechar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                botaoFechar.Size = new Size(35, 35);
                botaoFechar.Location = new Point(form.Width - 45, 5);
                botaoFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                botaoFechar.Click += (s, e) => form.Close();
                botaoFechar.MouseEnter += (s, e) =>
                    botaoFechar.BackColor = Color.FromArgb(255, 99, 117);
                botaoFechar.MouseLeave += (s, e) =>
                    botaoFechar.BackColor = Color.FromArgb(220, 53, 69);

                // Arrastar formulário ao clicar com o mouse
                form.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        ReleaseCapture();
                        SendMessage(form.Handle, 0x112, 0xf012, 0);
                    }
                };

                form.Controls.Add(botaoFechar);
                botaoFechar.BringToFront();
            }
           
        }
    }
}
