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
            label3 = new Label();
            groupBox4 = new GroupBox();
            lbIdCliente = new Label();
            groupBox5 = new GroupBox();
            lbNomeCliente = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            groupBox6 = new GroupBox();
            lbIdVeiculo = new Label();
            groupBox7 = new GroupBox();
            lbPlacaVeiculo = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtObservacoes = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(361, 50);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.Teal;
            button1.FlatAppearance.MouseOverBackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(132, 44);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(189, 30);
            button1.TabIndex = 1;
            button1.Text = "Selecionar Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PowderBlue;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(429, 511);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(239, 35);
            button4.TabIndex = 5;
            button4.Text = "Concluir Agendamento";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(48, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(955, 100);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSeaGreen;
            label3.Location = new Point(1, 1);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 23;
            label3.Text = "Cliente";
            label3.Click += label3_Click;
            label3.Paint += label5_Paint;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbIdCliente);
            groupBox4.ImeMode = ImeMode.Off;
            groupBox4.Location = new Point(395, 28);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(87, 53);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.BackColor = SystemColors.ButtonHighlight;
            lbIdCliente.BorderStyle = BorderStyle.FixedSingle;
            lbIdCliente.ForeColor = SystemColors.ActiveCaptionText;
            lbIdCliente.Location = new Point(14, 20);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(52, 23);
            lbIdCliente.TabIndex = 19;
            lbIdCliente.Text = "          \r\n";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lbNomeCliente);
            groupBox5.ImeMode = ImeMode.Off;
            groupBox5.Location = new Point(497, 28);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(223, 53);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            // 
            // lbNomeCliente
            // 
            lbNomeCliente.AutoSize = true;
            lbNomeCliente.BackColor = SystemColors.ButtonHighlight;
            lbNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            lbNomeCliente.ForeColor = SystemColors.ActiveCaptionText;
            lbNomeCliente.Location = new Point(16, 21);
            lbNomeCliente.Name = "lbNomeCliente";
            lbNomeCliente.Size = new Size(56, 23);
            lbNomeCliente.TabIndex = 20;
            lbNomeCliente.Text = "           ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(48, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(955, 100);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Paint += groupBox2_Paint;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSeaGreen;
            label5.Location = new Point(1, 1);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 24;
            label5.Text = "Veículo";
            label5.Click += label5_Click;
            label5.Paint += label3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(361, 51);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 1;
            label4.Text = "ID:";
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.FlatAppearance.MouseDownBackColor = Color.Teal;
            button3.FlatAppearance.MouseOverBackColor = Color.Teal;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(132, 44);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(189, 30);
            button3.TabIndex = 2;
            button3.Text = "Selecionar Veículo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbIdVeiculo);
            groupBox6.ImeMode = ImeMode.Off;
            groupBox6.Location = new Point(395, 28);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(87, 53);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            // 
            // lbIdVeiculo
            // 
            lbIdVeiculo.AutoSize = true;
            lbIdVeiculo.BackColor = SystemColors.ButtonHighlight;
            lbIdVeiculo.BorderStyle = BorderStyle.FixedSingle;
            lbIdVeiculo.ForeColor = SystemColors.ActiveCaptionText;
            lbIdVeiculo.Location = new Point(18, 20);
            lbIdVeiculo.Name = "lbIdVeiculo";
            lbIdVeiculo.Size = new Size(52, 23);
            lbIdVeiculo.TabIndex = 21;
            lbIdVeiculo.Text = "          ";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lbPlacaVeiculo);
            groupBox7.ImeMode = ImeMode.Off;
            groupBox7.Location = new Point(497, 28);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(223, 53);
            groupBox7.TabIndex = 23;
            groupBox7.TabStop = false;
            // 
            // lbPlacaVeiculo
            // 
            lbPlacaVeiculo.AutoSize = true;
            lbPlacaVeiculo.BackColor = SystemColors.ButtonHighlight;
            lbPlacaVeiculo.BorderStyle = BorderStyle.FixedSingle;
            lbPlacaVeiculo.ForeColor = SystemColors.ActiveCaptionText;
            lbPlacaVeiculo.Location = new Point(16, 20);
            lbPlacaVeiculo.Name = "lbPlacaVeiculo";
            lbPlacaVeiculo.Size = new Size(56, 23);
            lbPlacaVeiculo.TabIndex = 22;
            lbPlacaVeiculo.Text = "           ";
            lbPlacaVeiculo.Click += lbPlacaVeiculo_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            dateTimePicker1.Location = new Point(48, 295);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(315, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Value = new DateTime(2024, 12, 14, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(50, 358);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(955, 120);
            txtObservacoes.TabIndex = 4;
            txtObservacoes.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(50, 334);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 26;
            label2.Text = "Observações";
            // 
            // AgendarPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 581);
            Controls.Add(label2);
            Controls.Add(txtObservacoes);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgendarPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página Agenda";
            Load += AgendarPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
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
        private DateTimePicker dateTimePicker1;
        private TextBox txtObservacoes;
        private Label label2;
        public Label lbIdCliente;
        public Label lbNomeCliente;
        public Label lbPlacaVeiculo;
        public Label lbIdVeiculo;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Label label3;
        private Label label5;
    }
}