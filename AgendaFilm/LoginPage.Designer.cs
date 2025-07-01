namespace AgendaFilm
{
    partial class PaginaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Usuario = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            Senha = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btAcessar = new Button();
            btCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Usuario.Location = new Point(52, 283);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(64, 19);
            Usuario.TabIndex = 1;
            Usuario.Text = "Usuário:";
            Usuario.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Cambria", 12F, FontStyle.Bold);
            txtUsuario.Location = new Point(122, 278);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(213, 26);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Cambria", 12F, FontStyle.Bold);
            txtSenha.Location = new Point(122, 312);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(213, 26);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Senha.Location = new Point(58, 317);
            Senha.Name = "Senha";
            Senha.Size = new Size(53, 19);
            Senha.TabIndex = 3;
            Senha.Text = "Senha:";
            Senha.Click += label1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btAcessar);
            groupBox1.Controls.Add(btCancelar);
            groupBox1.Controls.Add(Usuario);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(Senha);
            groupBox1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 381);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 9;
            label1.Text = "AgendaFilm";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_1_removebg_preview;
            pictureBox1.Location = new Point(0, 51);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btAcessar
            // 
            btAcessar.BackColor = SystemColors.ScrollBar;
            btAcessar.FlatAppearance.MouseDownBackColor = Color.Teal;
            btAcessar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btAcessar.FlatStyle = FlatStyle.Flat;
            btAcessar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAcessar.Location = new Point(122, 344);
            btAcessar.Name = "btAcessar";
            btAcessar.Size = new Size(101, 29);
            btAcessar.TabIndex = 3;
            btAcessar.Text = "Acessar";
            btAcessar.UseVisualStyleBackColor = false;
            btAcessar.Click += btAcessar_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = SystemColors.ScrollBar;
            btCancelar.FlatAppearance.MouseDownBackColor = Color.Teal;
            btCancelar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.Location = new Point(236, 344);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(99, 29);
            btCancelar.TabIndex = 4;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // PaginaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(469, 439);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaginaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgendaFilm";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label Usuario;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label Senha;
        private GroupBox groupBox1;
        private Button btCancelar;
        private Button btAcessar;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
