namespace AgendaFilm.View.Editar
{
    partial class EditarFuncionarioPage
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
            btnSalvar = new Button();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtNivelAcesso = new TextBox();
            txtCargo = new TextBox();
            label8 = new Label();
            label6 = new Label();
            groupBox5 = new GroupBox();
            label7 = new Label();
            txtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLogin = new TextBox();
            txtNome = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            label1 = new Label();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.CadetBlue;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSalvar.Location = new Point(491, 411);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(211, 33);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(122, 138);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(212, 23);
            txtTelefone.TabIndex = 4;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(34, 141);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 0;
            label4.Text = "Telefone";
            // 
            // txtNivelAcesso
            // 
            txtNivelAcesso.Location = new Point(457, 79);
            txtNivelAcesso.Name = "txtNivelAcesso";
            txtNivelAcesso.Size = new Size(113, 23);
            txtNivelAcesso.TabIndex = 3;
            txtNivelAcesso.TextChanged += txtNivelAcesso_TextChanged;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(122, 79);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(139, 23);
            txtCargo.TabIndex = 2;
            txtCargo.TextChanged += txtCargo_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F);
            label8.Location = new Point(45, 82);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 9;
            label8.Text = "Cargo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F);
            label6.Location = new Point(337, 82);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 15;
            label6.Text = "Nível de acesso";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.WhiteSmoke;
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(txtSenha);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(txtLogin);
            groupBox5.Location = new Point(6, 270);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(696, 124);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Paint += groupBox5_Paint;
            groupBox5.Enter += groupBox5_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(153, 18);
            label7.Name = "label7";
            label7.Size = new Size(393, 32);
            label7.TabIndex = 21;
            label7.Text = "Confirme seus dados para salvar!";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(414, 81);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(212, 23);
            txtSenha.TabIndex = 6;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(45, 84);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 0;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(357, 84);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(122, 81);
            txtLogin.Margin = new Padding(3, 2, 3, 2);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(212, 23);
            txtLogin.TabIndex = 5;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(122, 30);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(212, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.Location = new Point(45, 30);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 0;
            label5.Text = "Nome";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtNivelAcesso);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(6, 60);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(696, 198);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(576, 90);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 22;
            label9.Text = "2 - FUNCIONÁRIO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(576, 75);
            label10.Name = "label10";
            label10.Size = new Size(117, 15);
            label10.TabIndex = 21;
            label10.Text = "1 - ADMINISTRADOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(251, 37);
            label1.TabIndex = 15;
            label1.Text = "Editar Funcionário";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // EditarFuncionarioPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(707, 455);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditarFuncionarioPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar FuncionarioPage";
            Load += EditarFuncionarioPage_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtNivelAcesso;
        private TextBox txtCargo;
        private Label label8;
        private Label label6;
        private GroupBox groupBox5;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtNome;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtSenha;
        private Label label3;
        private TextBox txtLogin;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label9;
        private Label label10;
    }
}