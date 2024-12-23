﻿namespace AgendaFilm.View.Agendamento
{
    partial class AgendarPage
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
            button1 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            lbNomeCliente = new Label();
            groupBox4 = new GroupBox();
            lbIdCliente = new Label();
            groupBox5 = new GroupBox();
            groupBox2 = new GroupBox();
            lbIdVeiculo = new Label();
            label4 = new Label();
            button3 = new Button();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            lbPlacaVeiculo = new Label();
            groupBox3 = new GroupBox();
            label3 = new Label();
            button2 = new Button();
            groupBox8 = new GroupBox();
            lbIdProduto = new Label();
            groupBox9 = new GroupBox();
            lbNomeProduto = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtObservacoes = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(247, 57);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(7, 51);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(216, 40);
            button1.TabIndex = 3;
            button1.Text = "Selecionar Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(242, 803);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(273, 47);
            button4.TabIndex = 12;
            button4.Text = "Concluir Agendamento";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbNomeCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(11, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(738, 133);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // lbNomeCliente
            // 
            lbNomeCliente.AutoSize = true;
            lbNomeCliente.BackColor = SystemColors.ButtonHighlight;
            lbNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            lbNomeCliente.ForeColor = SystemColors.ActiveCaptionText;
            lbNomeCliente.Location = new Point(402, 52);
            lbNomeCliente.Name = "lbNomeCliente";
            lbNomeCliente.Size = new Size(80, 30);
            lbNomeCliente.TabIndex = 20;
            lbNomeCliente.Text = "           ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbIdCliente);
            groupBox4.ImeMode = ImeMode.Off;
            groupBox4.Location = new Point(280, 25);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(99, 71);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.BackColor = SystemColors.ButtonHighlight;
            lbIdCliente.BorderStyle = BorderStyle.FixedSingle;
            lbIdCliente.ForeColor = SystemColors.ActiveCaptionText;
            lbIdCliente.Location = new Point(16, 27);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(74, 30);
            lbIdCliente.TabIndex = 19;
            lbIdCliente.Text = "          \r\n";
            // 
            // groupBox5
            // 
            groupBox5.ImeMode = ImeMode.Off;
            groupBox5.Location = new Point(386, 25);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(255, 71);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbIdVeiculo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(11, 157);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(738, 133);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veículo";
            // 
            // lbIdVeiculo
            // 
            lbIdVeiculo.AutoSize = true;
            lbIdVeiculo.BackColor = SystemColors.ButtonHighlight;
            lbIdVeiculo.BorderStyle = BorderStyle.FixedSingle;
            lbIdVeiculo.ForeColor = SystemColors.ActiveCaptionText;
            lbIdVeiculo.Location = new Point(296, 53);
            lbIdVeiculo.Name = "lbIdVeiculo";
            lbIdVeiculo.Size = new Size(74, 30);
            lbIdVeiculo.TabIndex = 21;
            lbIdVeiculo.Text = "          ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(247, 57);
            label4.Name = "label4";
            label4.Size = new Size(34, 25);
            label4.TabIndex = 1;
            label4.Text = "ID:";
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(7, 57);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(216, 40);
            button3.TabIndex = 3;
            button3.Text = "Selecionar Veículo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox6
            // 
            groupBox6.ImeMode = ImeMode.Off;
            groupBox6.Location = new Point(280, 27);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(99, 71);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lbPlacaVeiculo);
            groupBox7.ImeMode = ImeMode.Off;
            groupBox7.Location = new Point(386, 27);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(255, 71);
            groupBox7.TabIndex = 23;
            groupBox7.TabStop = false;
            // 
            // lbPlacaVeiculo
            // 
            lbPlacaVeiculo.AutoSize = true;
            lbPlacaVeiculo.BackColor = SystemColors.ButtonHighlight;
            lbPlacaVeiculo.BorderStyle = BorderStyle.FixedSingle;
            lbPlacaVeiculo.ForeColor = SystemColors.ActiveCaptionText;
            lbPlacaVeiculo.Location = new Point(18, 27);
            lbPlacaVeiculo.Name = "lbPlacaVeiculo";
            lbPlacaVeiculo.Size = new Size(80, 30);
            lbPlacaVeiculo.TabIndex = 22;
            lbPlacaVeiculo.Text = "           ";
            lbPlacaVeiculo.Click += lbPlacaVeiculo_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(groupBox8);
            groupBox3.Controls.Add(groupBox9);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(11, 316);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(738, 133);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(247, 63);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(7, 56);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(216, 40);
            button2.TabIndex = 3;
            button2.Text = "Selecionar Produto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lbIdProduto);
            groupBox8.ImeMode = ImeMode.Off;
            groupBox8.Location = new Point(280, 37);
            groupBox8.Margin = new Padding(3, 4, 3, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 4, 3, 4);
            groupBox8.Size = new Size(99, 71);
            groupBox8.TabIndex = 23;
            groupBox8.TabStop = false;
            // 
            // lbIdProduto
            // 
            lbIdProduto.AutoSize = true;
            lbIdProduto.BackColor = SystemColors.ButtonHighlight;
            lbIdProduto.BorderStyle = BorderStyle.FixedSingle;
            lbIdProduto.ForeColor = SystemColors.ActiveCaptionText;
            lbIdProduto.Location = new Point(16, 28);
            lbIdProduto.Name = "lbIdProduto";
            lbIdProduto.Size = new Size(74, 30);
            lbIdProduto.TabIndex = 23;
            lbIdProduto.Text = "          ";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(lbNomeProduto);
            groupBox9.ImeMode = ImeMode.Off;
            groupBox9.Location = new Point(386, 37);
            groupBox9.Margin = new Padding(3, 4, 3, 4);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 4, 3, 4);
            groupBox9.Size = new Size(255, 71);
            groupBox9.TabIndex = 25;
            groupBox9.TabStop = false;
            // 
            // lbNomeProduto
            // 
            lbNomeProduto.AutoSize = true;
            lbNomeProduto.BackColor = SystemColors.ButtonHighlight;
            lbNomeProduto.BorderStyle = BorderStyle.FixedSingle;
            lbNomeProduto.ForeColor = SystemColors.ActiveCaptionText;
            lbNomeProduto.Location = new Point(17, 28);
            lbNomeProduto.Name = "lbNomeProduto";
            lbNomeProduto.Size = new Size(80, 30);
            lbNomeProduto.TabIndex = 24;
            lbNomeProduto.Text = "           ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            dateTimePicker1.Location = new Point(202, 509);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(359, 27);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.Value = new DateTime(2024, 12, 14, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(14, 611);
            txtObservacoes.Margin = new Padding(3, 4, 3, 4);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(738, 159);
            txtObservacoes.TabIndex = 25;
            txtObservacoes.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(11, 579);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 26;
            label2.Text = "Observações";
            // 
            // AgendarPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 864);
            Controls.Add(label2);
            Controls.Add(txtObservacoes);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgendarPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página Agenda";
            Load += AgendarPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Button button3;
        private GroupBox groupBox3;
        private Label label3;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtObservacoes;
        private Label label2;
        public Label lbIdCliente;
        public Label lbNomeCliente;
        public Label lbPlacaVeiculo;
        public Label lbIdVeiculo;
        public Label lbNomeProduto;
        public Label lbIdProduto;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
    }
}