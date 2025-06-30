using System.Drawing;
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
