namespace AgendaFilm.View.Editar
{
    partial class EditarClientePage
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
            textDocumento = new TextBox();
            label3 = new Label();
            comboTipoCliente = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            groupBox5 = new GroupBox();
            textTelefone = new TextBox();
            textNome = new TextBox();
            label10 = new Label();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.CadetBlue;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btSalvar.Location = new Point(491, 273);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(211, 33);
            btSalvar.TabIndex = 24;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // textDocumento
            // 
            textDocumento.BackColor = SystemColors.ButtonHighlight;
            textDocumento.Location = new Point(383, 23);
            textDocumento.Margin = new Padding(3, 2, 3, 2);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(279, 23);
            textDocumento.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(277, 22);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 16;
            label3.Text = "CPF / CNPJ ...";
            // 
            // comboTipoCliente
            // 
            comboTipoCliente.BackColor = SystemColors.ButtonHighlight;
            comboTipoCliente.FormattingEnabled = true;
            comboTipoCliente.Items.AddRange(new object[] { "Física", "Jurídica" });
            comboTipoCliente.Location = new Point(109, 23);
            comboTipoCliente.Margin = new Padding(3, 2, 3, 2);
            comboTipoCliente.Name = "comboTipoCliente";
            comboTipoCliente.Size = new Size(140, 23);
            comboTipoCliente.TabIndex = 15;
            comboTipoCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 14;
            label1.Text = "Editar Cliente";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(30, 22);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(24, 71);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 8;
            label4.Text = "Nome";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textTelefone);
            groupBox5.Controls.Add(textDocumento);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(textNome);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(comboTipoCliente);
            groupBox5.Location = new Point(6, 60);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(696, 180);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Paint += groupBox1_Paint;
            groupBox5.Enter += groupBox5_Enter;
            // 
            // textTelefone
            // 
            textTelefone.BackColor = SystemColors.ButtonHighlight;
            textTelefone.Location = new Point(109, 127);
            textTelefone.Margin = new Padding(3, 2, 3, 2);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(278, 23);
            textTelefone.TabIndex = 28;
            textTelefone.TextChanged += textTelefone_TextChanged;
            // 
            // textNome
            // 
            textNome.BackColor = SystemColors.ButtonHighlight;
            textNome.Location = new Point(109, 72);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(553, 23);
            textNome.TabIndex = 0;
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
            // 
            // EditarClientePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(707, 318);
            Controls.Add(btSalvar);
            Controls.Add(label1);
            Controls.Add(groupBox5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditarClientePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarClientePage";
            Load += EditarClientePage_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalvar;
        private TextBox textDocumento;
        private Label label3;
        private ComboBox comboTipoCliente;
        private Label label1;
        private Label label2;
        private Label label4;
        private GroupBox groupBox5;
        private TextBox textNome;
        private Label label10;
        private TextBox textTelefone;
    }
}