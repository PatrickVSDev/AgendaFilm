namespace AgendaFilm.View.Cadastro.Cadastrar
{
    partial class CadastroFornecedorPage
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
            textDocumento = new TextBox();
            label3 = new Label();
            textNome = new TextBox();
            label2 = new Label();
            textTelefone = new TextBox();
            label4 = new Label();
            label7 = new Label();
            textEmail = new TextBox();
            button1 = new Button();
            groupBox8 = new GroupBox();
            groupBox8.SuspendLayout();
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
            label1.Size = new Size(324, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Fornecedor";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // textDocumento
            // 
            textDocumento.Location = new Point(480, 20);
            textDocumento.Margin = new Padding(3, 2, 3, 2);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(204, 23);
            textDocumento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(407, 23);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "CNPJ";
            label3.Click += label3_Click;
            // 
            // textNome
            // 
            textNome.Location = new Point(107, 20);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(265, 23);
            textNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(20, 23);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // textTelefone
            // 
            textTelefone.BackColor = SystemColors.ButtonHighlight;
            textTelefone.Location = new Point(107, 84);
            textTelefone.Margin = new Padding(3, 2, 3, 2);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(265, 23);
            textTelefone.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(16, 83);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 26;
            label4.Text = "Telefone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F);
            label7.Location = new Point(23, 133);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 23;
            label7.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(107, 134);
            textEmail.Margin = new Padding(3, 2, 3, 2);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(577, 23);
            textEmail.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(491, 273);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(211, 33);
            button1.TabIndex = 15;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textDocumento);
            groupBox8.Controls.Add(label3);
            groupBox8.Controls.Add(label2);
            groupBox8.Controls.Add(label7);
            groupBox8.Controls.Add(textTelefone);
            groupBox8.Controls.Add(textNome);
            groupBox8.Controls.Add(textEmail);
            groupBox8.Controls.Add(label4);
            groupBox8.Location = new Point(6, 60);
            groupBox8.Margin = new Padding(3, 2, 3, 2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 2, 3, 2);
            groupBox8.Size = new Size(696, 180);
            groupBox8.TabIndex = 25;
            groupBox8.TabStop = false;
            groupBox8.Paint += groupBox8_Paint;
            groupBox8.Enter += groupBox8_Enter;
            // 
            // CadastroFornecedorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(707, 318);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox8);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroFornecedorPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Fornecedor ";
            Load += CadastroFornecedorPage_Load;
            Paint += label1_Paint;
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textDocumento;
        private Label label3;
        private TextBox textNome;
        private Label label2;
        private TextBox textTelefone;
        private Label label4;
        private TextBox textEmail;
        private Label label7;
        private Button button1;
        private GroupBox groupBox8;
    }
}