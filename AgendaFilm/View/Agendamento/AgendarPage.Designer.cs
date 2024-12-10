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
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            label4 = new Label();
            textBox7 = new TextBox();
            button3 = new Button();
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
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
            // textBox3
            // 
            textBox3.Location = new Point(250, 38);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 29);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(334, 38);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 29);
            textBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(10, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(646, 100);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veículo";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(250, 38);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(60, 29);
            textBox6.TabIndex = 18;
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
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ButtonHighlight;
            textBox7.Location = new Point(334, 38);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(295, 29);
            textBox7.TabIndex = 2;
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
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(button2);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(10, 237);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(646, 100);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(250, 43);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(60, 29);
            textBox4.TabIndex = 18;
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
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ButtonHighlight;
            textBox5.Location = new Point(334, 38);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(295, 29);
            textBox5.TabIndex = 2;
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
            // textBox2
            // 
            textBox2.Location = new Point(12, 458);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(646, 120);
            textBox2.TabIndex = 25;
            textBox2.TextChanged += textBox2_TextChanged;
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
            Controls.Add(textBox2);
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
        private TextBox textBox3;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private Label label4;
        private TextBox textBox7;
        private Button button3;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Label label2;
    }
}