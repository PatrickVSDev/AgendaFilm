﻿namespace AgendaFilm.View.Cadastro.Cadastrar
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
            groupBox2 = new GroupBox();
            lbNomeCliente = new Label();
            label7 = new Label();
            label6 = new Label();
            btEscolherCliente = new Button();
            label2 = new Label();
            txtAno = new TextBox();
            txtPlaca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            btSalvar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            label1.Size = new Size(283, 37);
            label1.TabIndex = 2;
            label1.Text = "Cadastro de Veículos";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btEscolherCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAno);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Location = new Point(6, 60);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(696, 180);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbNomeCliente);
            groupBox2.Location = new Point(457, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(207, 36);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lbNomeCliente
            // 
            lbNomeCliente.AutoSize = true;
            lbNomeCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbNomeCliente.ForeColor = Color.Blue;
            lbNomeCliente.Location = new Point(6, 12);
            lbNomeCliente.Name = "lbNomeCliente";
            lbNomeCliente.Size = new Size(0, 19);
            lbNomeCliente.TabIndex = 0;
            lbNomeCliente.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(372, 145);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 6;
            label7.Text = "Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F);
            label6.Location = new Point(25, 145);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Cliente";
            label6.Click += label6_Click;
            // 
            // btEscolherCliente
            // 
            btEscolherCliente.BackColor = Color.Teal;
            btEscolherCliente.FlatStyle = FlatStyle.Flat;
            btEscolherCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btEscolherCliente.Location = new Point(123, 140);
            btEscolherCliente.Margin = new Padding(3, 2, 3, 2);
            btEscolherCliente.Name = "btEscolherCliente";
            btEscolherCliente.Size = new Size(208, 30);
            btEscolherCliente.TabIndex = 5;
            btEscolherCliente.Text = "Selecionar cliente";
            btEscolherCliente.UseVisualStyleBackColor = false;
            btEscolherCliente.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(25, 34);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "Placa";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(457, 90);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(110, 23);
            txtAno.TabIndex = 4;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(123, 36);
            txtPlaca.Margin = new Padding(3, 2, 3, 2);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(151, 23);
            txtPlaca.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(380, 93);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 2;
            label4.Text = "Ano";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(372, 35);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.Location = new Point(25, 93);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 0;
            label5.Text = "Modelo";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(457, 35);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(207, 23);
            txtMarca.TabIndex = 2;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(123, 90);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(223, 23);
            txtModelo.TabIndex = 3;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.CadetBlue;
            btSalvar.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btSalvar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btSalvar.Location = new Point(491, 273);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(211, 33);
            btSalvar.TabIndex = 6;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // CadastroVeiculoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 318);
            Controls.Add(btSalvar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroVeiculoPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Veiculo";
            Load += CadastroVeiculoPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMarca;
        private Label label3;
        private TextBox txtPlaca;
        private Label label2;
        private Label label4;
        private TextBox txtModelo;
        private Label label5;
        private Button btSalvar;
        private Button btEscolherCliente;
        private TextBox txtAno;
        private Label label6;
        private Label label7;
        private GroupBox groupBox2;
        private Label lbNomeCliente;
    }
}