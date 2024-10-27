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
            Usuario.Location = new Point(66, 249);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(50, 15);
            Usuario.TabIndex = 1;
            Usuario.Text = "Usuário:";
            Usuario.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(122, 246);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(213, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(122, 275);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(213, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(74, 278);
            Senha.Name = "Senha";
            Senha.Size = new Size(42, 15);
            Senha.TabIndex = 3;
            Senha.Text = "Senha:";
            Senha.Click += label1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btAcessar);
            groupBox1.Controls.Add(btCancelar);
            groupBox1.Controls.Add(Usuario);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(Senha);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 365);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulário de Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_1_removebg_preview;
            pictureBox1.Location = new Point(0, 21);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btAcessar
            // 
            btAcessar.Location = new Point(122, 308);
            btAcessar.Name = "btAcessar";
            btAcessar.Size = new Size(108, 23);
            btAcessar.TabIndex = 7;
            btAcessar.Text = "Acessar";
            btAcessar.UseVisualStyleBackColor = true;
            btAcessar.Click += btAcessar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(228, 308);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(107, 23);
            btCancelar.TabIndex = 6;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // PaginaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 384);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
    }
}
