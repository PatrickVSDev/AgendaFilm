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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label4 = new Label();
            groupBox5 = new GroupBox();
            textNome = new TextBox();
            groupBox12 = new GroupBox();
            label10 = new Label();
            textTelefone = new TextBox();
            groupBox6 = new GroupBox();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.SpringGreen;
            btSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btSalvar.Location = new Point(634, 407);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(241, 44);
            btSalvar.TabIndex = 24;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // textDocumento
            // 
            textDocumento.BackColor = SystemColors.ButtonHighlight;
            textDocumento.Location = new Point(603, 84);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(265, 27);
            textDocumento.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(425, 83);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 16;
            label3.Text = "CPF / CNPJ ...";
            // 
            // comboTipoCliente
            // 
            comboTipoCliente.BackColor = SystemColors.ButtonHighlight;
            comboTipoCliente.FormattingEnabled = true;
            comboTipoCliente.Items.AddRange(new object[] { "Física", "Jurídica" });
            comboTipoCliente.Location = new Point(222, 84);
            comboTipoCliente.Name = "comboTipoCliente";
            comboTipoCliente.Size = new Size(159, 28);
            comboTipoCliente.TabIndex = 15;
            comboTipoCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 46);
            label1.TabIndex = 14;
            label1.Text = "Editar Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(402, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(181, 48);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Location = new Point(1, 47);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(874, 83);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(75, 36);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(11, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(179, 48);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(11, 161);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(181, 48);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(55, 15);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 8;
            label4.Text = "Nome";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textNome);
            groupBox5.Location = new Point(1, 140);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(874, 83);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            // 
            // textNome
            // 
            textNome.BackColor = SystemColors.ButtonHighlight;
            textNome.Location = new Point(221, 35);
            textNome.Name = "textNome";
            textNome.Size = new Size(642, 27);
            textNome.TabIndex = 0;
            // 
            // groupBox12
            // 
            groupBox12.Location = new Point(29, 26);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(160, 56);
            groupBox12.TabIndex = 27;
            groupBox12.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F);
            label10.Location = new Point(50, 41);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 26;
            label10.Text = "Telefone";
            // 
            // textTelefone
            // 
            textTelefone.BackColor = SystemColors.ButtonHighlight;
            textTelefone.Location = new Point(220, 39);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(317, 27);
            textTelefone.TabIndex = 28;
            textTelefone.TextChanged += textTelefone_TextChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textTelefone);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(groupBox12);
            groupBox6.Location = new Point(2, 235);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(874, 96);
            groupBox6.TabIndex = 23;
            groupBox6.TabStop = false;
            // 
            // EditarClientePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 463);
            Controls.Add(btSalvar);
            Controls.Add(textDocumento);
            Controls.Add(label3);
            Controls.Add(comboTipoCliente);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Name = "EditarClientePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarClientePage";
            Load += EditarClientePage_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalvar;
        private TextBox textDocumento;
        private Label label3;
        private ComboBox comboTipoCliente;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Label label4;
        private GroupBox groupBox5;
        private TextBox textNome;
        private GroupBox groupBox12;
        private Label label10;
        private TextBox textTelefone;
        private GroupBox groupBox6;
    }
}