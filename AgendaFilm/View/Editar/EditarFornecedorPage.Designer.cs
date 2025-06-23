namespace AgendaFilm.View.Editar
{
    partial class EditarFornecedorPage
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
            btSalvar = new Button();
            label7 = new Label();
            textEmail = new TextBox();
            textTelefone = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textDocumento = new TextBox();
            label3 = new Label();
            textNome = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.CadetBlue;
            btSalvar.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btSalvar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btSalvar.Location = new Point(491, 272);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(211, 33);
            btSalvar.TabIndex = 20;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F);
            label7.Location = new Point(33, 132);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 23;
            label7.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(117, 129);
            textEmail.Margin = new Padding(3, 2, 3, 2);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(494, 23);
            textEmail.TabIndex = 3;
            // 
            // textTelefone
            // 
            textTelefone.BackColor = SystemColors.ButtonHighlight;
            textTelefone.Location = new Point(117, 79);
            textTelefone.Margin = new Padding(3, 2, 3, 2);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(215, 23);
            textTelefone.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(26, 82);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 26;
            label4.Text = "Telefone";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textTelefone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textDocumento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textNome);
            groupBox1.Location = new Point(6, 60);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(696, 180);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(34, 28);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // textDocumento
            // 
            textDocumento.Location = new Point(420, 25);
            textDocumento.Margin = new Padding(3, 2, 3, 2);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(191, 23);
            textDocumento.TabIndex = 4;
            textDocumento.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(351, 28);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "CNPJ";
            // 
            // textNome
            // 
            textNome.Location = new Point(117, 25);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(215, 23);
            textNome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(246, 37);
            label1.TabIndex = 16;
            label1.Text = "Editar Fornecedor";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // EditarFornecedorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 318);
            Controls.Add(btSalvar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(556, 295);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditarFornecedorPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarFornecedorPage";
            Load += EditarFornecedorPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalvar;
        private Label label7;
        private TextBox textEmail;
        private TextBox textTelefone;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textDocumento;
        private Label label3;
        private TextBox textNome;
        private Label label2;
        private Label label1;
    }
}