namespace AgendaFilm.View.Cadastro.Cadastrar
{
    partial class CadastroVeiculoPage
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
            txtMarca = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            txtPlaca = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            txtAno = new TextBox();
            groupBox5 = new GroupBox();
            label4 = new Label();
            txtModelo = new TextBox();
            groupBox6 = new GroupBox();
            label5 = new Label();
            groupBox7 = new GroupBox();
            groupBox9 = new GroupBox();
            btEscolherCliente = new Button();
            btSalvar = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(283, 37);
            label1.TabIndex = 2;
            label1.Text = "Cadastro de Veículos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(2, 35);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(765, 62);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(534, 25);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(207, 23);
            txtMarca.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(358, 13);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(157, 36);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(52, 12);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(189, 25);
            txtPlaca.Margin = new Padding(3, 2, 3, 2);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(151, 23);
            txtPlaca.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(9, 13);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(157, 36);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(52, 12);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "Placa";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtAno);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(txtModelo);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Location = new Point(2, 98);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(765, 62);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(578, 22);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 3;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new Point(434, 13);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(127, 36);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(44, 11);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 2;
            label4.Text = "Ano";
            label4.Click += label4_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(189, 25);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(223, 23);
            txtModelo.TabIndex = 3;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label5);
            groupBox6.Location = new Point(9, 13);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(157, 36);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.Location = new Point(52, 12);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 0;
            label5.Text = "Modelo";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(groupBox9);
            groupBox7.Location = new Point(2, 160);
            groupBox7.Margin = new Padding(3, 2, 3, 2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 2, 3, 2);
            groupBox7.Size = new Size(765, 55);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(btEscolherCliente);
            groupBox9.Location = new Point(271, 5);
            groupBox9.Margin = new Padding(3, 2, 3, 2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 2, 3, 2);
            groupBox9.Size = new Size(255, 45);
            groupBox9.TabIndex = 2;
            groupBox9.TabStop = false;
            // 
            // btEscolherCliente
            // 
            btEscolherCliente.BackColor = SystemColors.ActiveBorder;
            btEscolherCliente.Font = new Font("Segoe UI Semibold", 11F);
            btEscolherCliente.Location = new Point(63, 13);
            btEscolherCliente.Margin = new Padding(3, 2, 3, 2);
            btEscolherCliente.Name = "btEscolherCliente";
            btEscolherCliente.Size = new Size(135, 26);
            btEscolherCliente.TabIndex = 0;
            btEscolherCliente.Text = "Escolher cliente";
            btEscolherCliente.UseVisualStyleBackColor = false;
            btEscolherCliente.Click += button2_Click;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.SpringGreen;
            btSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btSalvar.Location = new Point(556, 361);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(211, 33);
            btSalvar.TabIndex = 23;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // CadastroVeiculoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 401);
            Controls.Add(btSalvar);
            Controls.Add(groupBox7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroVeiculoPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroVeiculoPage";
            Load += CadastroVeiculoPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMarca;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox txtPlaca;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label4;
        private TextBox txtModelo;
        private GroupBox groupBox6;
        private Label label5;
        private GroupBox groupBox7;
        private GroupBox groupBox9;
        private Button btSalvar;
        private Button btEscolherCliente;
        private TextBox txtAno;
    }
}