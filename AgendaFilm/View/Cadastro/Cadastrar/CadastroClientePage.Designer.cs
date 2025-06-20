namespace AgendaFilm
{
    partial class CadastroClientePage
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
            textTelefone = new TextBox();
            label10 = new Label();
            label4 = new Label();
            textNome = new TextBox();
            label3 = new Label();
            textDocumento = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            comboTipoCliente = new ComboBox();
            btSalvar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(268, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Cliente";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // textTelefone
            // 
            textTelefone.BackColor = SystemColors.ButtonHighlight;
            textTelefone.Location = new Point(109, 127);
            textTelefone.Margin = new Padding(3, 2, 3, 2);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(278, 23);
            textTelefone.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F);
            label10.Location = new Point(18, 126);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 26;
            label10.Text = "Telefone";
            label10.Click += label10_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(23, 68);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 8;
            label4.Text = "Nome";
            label4.Click += label4_Click;
            // 
            // textNome
            // 
            textNome.BackColor = SystemColors.ButtonHighlight;
            textNome.Location = new Point(109, 65);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(553, 23);
            textNome.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(277, 19);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "CPF / CNPJ ...";
            // 
            // textDocumento
            // 
            textDocumento.BackColor = SystemColors.ButtonHighlight;
            textDocumento.Location = new Point(383, 16);
            textDocumento.Margin = new Padding(3, 2, 3, 2);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(279, 23);
            textDocumento.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textNome);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textTelefone);
            groupBox1.Controls.Add(textDocumento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboTipoCliente);
            groupBox1.Location = new Point(6, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(696, 180);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(26, 21);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            label2.Click += label2_Click;
            // 
            // comboTipoCliente
            // 
            comboTipoCliente.BackColor = SystemColors.ButtonHighlight;
            comboTipoCliente.FormattingEnabled = true;
            comboTipoCliente.Items.AddRange(new object[] { "Física", "Jurídica" });
            comboTipoCliente.Location = new Point(109, 19);
            comboTipoCliente.Margin = new Padding(3, 2, 3, 2);
            comboTipoCliente.Name = "comboTipoCliente";
            comboTipoCliente.Size = new Size(140, 23);
            comboTipoCliente.TabIndex = 3;
            comboTipoCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.CadetBlue;
            btSalvar.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btSalvar.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btSalvar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btSalvar.Location = new Point(491, 273);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(211, 33);
            btSalvar.TabIndex = 13;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += button1_Click;
            // 
            // CadastroClientePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(707, 318);
            Controls.Add(btSalvar);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroClientePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            Load += CadastroClientePage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textDocumento;
        private ComboBox comboTipoCliente;
        private Label label3;
        private TextBox textNome;
        private Label label4;
        private TextBox textTelefone;
        private Label label10;
        private GroupBox groupBox1;
        private Button btSalvar;
    }
}