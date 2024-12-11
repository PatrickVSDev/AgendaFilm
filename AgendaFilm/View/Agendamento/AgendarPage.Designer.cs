namespace AgendaFilm.View.Agendamento
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
            lbIdCliente = new Label();
            groupBox2 = new GroupBox();
            lbPlacaVeiculo = new Label();
            lbIdVeiculo = new Label();
            label4 = new Label();
            button3 = new Button();
            groupBox3 = new GroupBox();
            lbNomeProduto = new Label();
            lbIdProduto = new Label();
            label3 = new Label();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtObservacoes = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(216, 43);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(6, 38);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(189, 30);
            button1.TabIndex = 3;
            button1.Text = "Selecionar Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(212, 602);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(239, 35);
            button4.TabIndex = 12;
            button4.Text = "Concluir Agendamento";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbNomeCliente);
            groupBox1.Controls.Add(lbIdCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 100);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lbNomeCliente
            // 
            lbNomeCliente.AutoSize = true;
            lbNomeCliente.BackColor = SystemColors.ButtonHighlight;
            lbNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            lbNomeCliente.ForeColor = SystemColors.ActiveCaptionText;
            lbNomeCliente.Location = new Point(334, 41);
            lbNomeCliente.Name = "lbNomeCliente";
            lbNomeCliente.Size = new Size(59, 23);
            lbNomeCliente.TabIndex = 20;
            lbNomeCliente.Text = "label5";
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.BackColor = SystemColors.ButtonHighlight;
            lbIdCliente.BorderStyle = BorderStyle.FixedSingle;
            lbIdCliente.ForeColor = SystemColors.ActiveCaptionText;
            lbIdCliente.Location = new Point(251, 40);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(59, 23);
            lbIdCliente.TabIndex = 19;
            lbIdCliente.Text = "label5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbPlacaVeiculo);
            groupBox2.Controls.Add(lbIdVeiculo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(10, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(646, 100);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veículo";
            // 
            // lbPlacaVeiculo
            // 
            lbPlacaVeiculo.AutoSize = true;
            lbPlacaVeiculo.BackColor = SystemColors.ButtonHighlight;
            lbPlacaVeiculo.BorderStyle = BorderStyle.FixedSingle;
            lbPlacaVeiculo.ForeColor = SystemColors.ActiveCaptionText;
            lbPlacaVeiculo.Location = new Point(334, 42);
            lbPlacaVeiculo.Name = "lbPlacaVeiculo";
            lbPlacaVeiculo.Size = new Size(59, 23);
            lbPlacaVeiculo.TabIndex = 22;
            lbPlacaVeiculo.Text = "label5";
            // 
            // lbIdVeiculo
            // 
            lbIdVeiculo.AutoSize = true;
            lbIdVeiculo.BackColor = SystemColors.ButtonHighlight;
            lbIdVeiculo.BorderStyle = BorderStyle.FixedSingle;
            lbIdVeiculo.ForeColor = SystemColors.ActiveCaptionText;
            lbIdVeiculo.Location = new Point(251, 41);
            lbIdVeiculo.Name = "lbIdVeiculo";
            lbIdVeiculo.Size = new Size(59, 23);
            lbIdVeiculo.TabIndex = 21;
            lbIdVeiculo.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(216, 43);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 1;
            label4.Text = "ID:";
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(6, 43);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(189, 30);
            button3.TabIndex = 3;
            button3.Text = "Selecionar Veículo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbNomeProduto);
            groupBox3.Controls.Add(lbIdProduto);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(button2);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(10, 237);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(646, 100);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produto";
            // 
            // lbNomeProduto
            // 
            lbNomeProduto.AutoSize = true;
            lbNomeProduto.BackColor = SystemColors.ButtonHighlight;
            lbNomeProduto.BorderStyle = BorderStyle.FixedSingle;
            lbNomeProduto.ForeColor = SystemColors.ActiveCaptionText;
            lbNomeProduto.Location = new Point(334, 47);
            lbNomeProduto.Name = "lbNomeProduto";
            lbNomeProduto.Size = new Size(59, 23);
            lbNomeProduto.TabIndex = 24;
            lbNomeProduto.Text = "label5";
            // 
            // lbIdProduto
            // 
            lbIdProduto.AutoSize = true;
            lbIdProduto.BackColor = SystemColors.ButtonHighlight;
            lbIdProduto.BorderStyle = BorderStyle.FixedSingle;
            lbIdProduto.ForeColor = SystemColors.ActiveCaptionText;
            lbIdProduto.Location = new Point(251, 46);
            lbIdProduto.Name = "lbIdProduto";
            lbIdProduto.Size = new Size(59, 23);
            lbIdProduto.TabIndex = 23;
            lbIdProduto.Text = "label5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(216, 47);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(6, 42);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(189, 30);
            button2.TabIndex = 3;
            button2.Text = "Selecionar Produto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            dateTimePicker1.Location = new Point(177, 382);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(315, 23);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.Value = new DateTime(2024, 12, 14, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(12, 458);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(646, 120);
            txtObservacoes.TabIndex = 25;
            txtObservacoes.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(10, 434);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 26;
            label2.Text = "Observações";
            // 
            // AgendarPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 648);
            Controls.Add(label2);
            Controls.Add(txtObservacoes);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Name = "AgendarPage";
            Text = "AgendarPage";
            Load += AgendarPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
    }
}