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
            label5 = new Label();
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
            groupBox6 = new GroupBox();
            textTelefone = new TextBox();
            label10 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            groupBox7 = new GroupBox();
            groupBox8 = new GroupBox();
            groupBox9 = new GroupBox();
            label7 = new Label();
            groupBox10 = new GroupBox();
            label8 = new Label();
            groupBox11 = new GroupBox();
            label9 = new Label();
            groupBox12 = new GroupBox();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.SpringGreen;
            btSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btSalvar.Location = new Point(561, 361);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(211, 33);
            btSalvar.TabIndex = 24;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.Location = new Point(36, 199);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 22;
            label5.Text = "Logradouro";
            // 
            // textDocumento
            // 
            textDocumento.BackColor = SystemColors.ButtonHighlight;
            textDocumento.Location = new Point(528, 63);
            textDocumento.Margin = new Padding(3, 2, 3, 2);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(232, 23);
            textDocumento.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(372, 62);
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
            comboTipoCliente.Location = new Point(194, 63);
            comboTipoCliente.Margin = new Padding(3, 2, 3, 2);
            comboTipoCliente.Name = "comboTipoCliente";
            comboTipoCliente.Size = new Size(140, 23);
            comboTipoCliente.TabIndex = 15;
            comboTipoCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 14;
            label1.Text = "Editar Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(352, 51);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(158, 36);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Location = new Point(1, 35);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(765, 62);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(66, 27);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(10, 16);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(157, 36);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(10, 121);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(158, 36);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(48, 11);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 8;
            label4.Text = "Nome";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textNome);
            groupBox5.Location = new Point(1, 105);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(765, 62);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            // 
            // textNome
            // 
            textNome.BackColor = SystemColors.ButtonHighlight;
            textNome.Location = new Point(193, 26);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(562, 23);
            textNome.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textTelefone);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(textBox7);
            groupBox6.Controls.Add(textBox6);
            groupBox6.Controls.Add(textBox5);
            groupBox6.Controls.Add(textBox4);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(textBox3);
            groupBox6.Controls.Add(groupBox7);
            groupBox6.Controls.Add(groupBox8);
            groupBox6.Controls.Add(groupBox9);
            groupBox6.Controls.Add(groupBox10);
            groupBox6.Controls.Add(groupBox11);
            groupBox6.Controls.Add(groupBox12);
            groupBox6.Location = new Point(2, 176);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(765, 176);
            groupBox6.TabIndex = 23;
            groupBox6.TabStop = false;
            // 
            // textTelefone
            // 
            textTelefone.BackColor = SystemColors.ButtonHighlight;
            textTelefone.Location = new Point(543, 147);
            textTelefone.Margin = new Padding(3, 2, 3, 2);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(211, 23);
            textTelefone.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F);
            label10.Location = new Point(446, 146);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 26;
            label10.Text = "Telefone";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ButtonHighlight;
            textBox7.Location = new Point(192, 147);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(231, 23);
            textBox7.TabIndex = 25;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ButtonHighlight;
            textBox6.Location = new Point(518, 87);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(237, 23);
            textBox6.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ButtonHighlight;
            textBox5.Location = new Point(192, 86);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.Location = new Point(585, 23);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 23);
            textBox4.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F);
            label6.Location = new Point(524, 25);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 15;
            label6.Text = "CEP";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(193, 23);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 23);
            textBox3.TabIndex = 14;
            // 
            // groupBox7
            // 
            groupBox7.Location = new Point(9, 11);
            groupBox7.Margin = new Padding(3, 2, 3, 2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 2, 3, 2);
            groupBox7.Size = new Size(158, 36);
            groupBox7.TabIndex = 13;
            groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            groupBox8.Location = new Point(518, 11);
            groupBox8.Margin = new Padding(3, 2, 3, 2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 2, 3, 2);
            groupBox8.Size = new Size(50, 36);
            groupBox8.TabIndex = 13;
            groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(label7);
            groupBox9.Location = new Point(9, 75);
            groupBox9.Margin = new Padding(3, 2, 3, 2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 2, 3, 2);
            groupBox9.Size = new Size(158, 36);
            groupBox9.TabIndex = 18;
            groupBox9.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F);
            label7.Location = new Point(37, 10);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 17;
            label7.Text = "Número";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(label8);
            groupBox10.Location = new Point(370, 75);
            groupBox10.Margin = new Padding(3, 2, 3, 2);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(3, 2, 3, 2);
            groupBox10.Size = new Size(134, 36);
            groupBox10.TabIndex = 21;
            groupBox10.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F);
            label8.Location = new Point(7, 11);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 20;
            label8.Text = "Complemento";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(label9);
            groupBox11.Location = new Point(9, 135);
            groupBox11.Margin = new Padding(3, 2, 3, 2);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(3, 2, 3, 2);
            groupBox11.Size = new Size(157, 36);
            groupBox11.TabIndex = 24;
            groupBox11.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F);
            label9.Location = new Point(48, 10);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 23;
            label9.Text = "Bairro";
            // 
            // groupBox12
            // 
            groupBox12.Location = new Point(428, 135);
            groupBox12.Margin = new Padding(3, 2, 3, 2);
            groupBox12.Name = "groupBox12";
            groupBox12.Padding = new Padding(3, 2, 3, 2);
            groupBox12.Size = new Size(110, 36);
            groupBox12.TabIndex = 27;
            groupBox12.TabStop = false;
            // 
            // EditarClientePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 401);
            Controls.Add(btSalvar);
            Controls.Add(label5);
            Controls.Add(textDocumento);
            Controls.Add(label3);
            Controls.Add(comboTipoCliente);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Margin = new Padding(3, 2, 3, 2);
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
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalvar;
        private Label label5;
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
        private GroupBox groupBox6;
        private TextBox textTelefone;
        private Label label10;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private Label label7;
        private GroupBox groupBox10;
        private Label label8;
        private GroupBox groupBox11;
        private Label label9;
        private GroupBox groupBox12;
    }
}