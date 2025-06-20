namespace AgendaFilm
{
    partial class CadastroFuncionarioPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtNivelAcesso = new TextBox();
            txtTelefone = new TextBox();
            label6 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label8 = new Label();
            txtCargo = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            txtLogin = new TextBox();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(329, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionário";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNivelAcesso);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLogin);
            groupBox1.Location = new Point(6, 60);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(696, 253);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNivelAcesso
            // 
            txtNivelAcesso.Location = new Point(477, 137);
            txtNivelAcesso.Name = "txtNivelAcesso";
            txtNivelAcesso.Size = new Size(76, 23);
            txtNivelAcesso.TabIndex = 0;
            txtNivelAcesso.TextChanged += txtNivelAcesso_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(111, 188);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(212, 23);
            txtTelefone.TabIndex = 3;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F);
            label6.Location = new Point(346, 136);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 15;
            label6.Text = "Nível de acesso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(28, 30);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 0;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(403, 27);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(268, 23);
            txtSenha.TabIndex = 4;
            txtSenha.TextChanged += textSenha_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.Location = new Point(27, 87);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 0;
            label5.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(346, 30);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F);
            label8.Location = new Point(28, 136);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 9;
            label8.Text = "Cargo";
            label8.Click += label8_Click;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(111, 137);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(139, 23);
            txtCargo.TabIndex = 5;
            txtCargo.TextChanged += textBox1_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(111, 88);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(560, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += textNome_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(23, 191);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 0;
            label4.Text = "Telefone";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(111, 31);
            txtLogin.Margin = new Padding(3, 2, 3, 2);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(212, 23);
            txtLogin.TabIndex = 3;
            txtLogin.TextChanged += textLogin_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.CadetBlue;
            btnSalvar.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSalvar.Location = new Point(491, 336);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(211, 33);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CadastroFuncionarioPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 382);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroFuncionarioPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Funcionario";
            Load += CadastroFuncionarioPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label3;
        private TextBox txtNome;
        private Label label5;
        private TextBox txtTelefone;
        private Label label4;
        private Label label6;
        private Label label8;
        private Button btnSalvar;
        private TextBox txtCargo;
        private TextBox txtNivelAcesso;
    }
}