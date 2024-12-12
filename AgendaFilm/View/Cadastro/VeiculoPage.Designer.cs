namespace AgendaFilm.View
{
    partial class VeiculoPage
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
            groupBox2 = new GroupBox();
            label3 = new Label();
            RelatorioTextBox = new TextBox();
            button5 = new Button();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton6 = new RadioButton();
            label2 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(RelatorioTextBox);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(22, 1);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(917, 73);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(632, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 15);
            label3.TabIndex = 38;
            label3.Text = "Gerar Relatorio PDF Por Modelo:";
            label3.Click += label3_Click;
            // 
            // RelatorioTextBox
            // 
            RelatorioTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RelatorioTextBox.Location = new Point(613, 21);
            RelatorioTextBox.Name = "RelatorioTextBox";
            RelatorioTextBox.Size = new Size(240, 20);
            RelatorioTextBox.TabIndex = 37;
            // 
            // button5
            // 
            button5.BackColor = Color.SpringGreen;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button5.Location = new Point(637, 46);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(175, 27);
            button5.TabIndex = 36;
            button5.Text = "Gerar Relatório";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(290, 12);
            radioButton5.Margin = new Padding(3, 2, 3, 2);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(36, 19);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "ID";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(336, 13);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(53, 19);
            radioButton3.TabIndex = 28;
            radioButton3.TabStop = true;
            radioButton3.Text = "Placa";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(216, 12);
            radioButton6.Margin = new Padding(3, 2, 3, 2);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(58, 19);
            radioButton6.TabIndex = 3;
            radioButton6.TabStop = true;
            radioButton6.Text = "Nome";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(8, 10);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 2;
            label2.Text = "Defina o tipo de pesquisa:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(216, 35);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(5, 32);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(192, 26);
            button4.TabIndex = 0;
            button4.Text = "Pesquisar";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 78);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(911, 373);
            dataGridView1.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(19, 455);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(914, 64);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(696, 12);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(200, 42);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button3.Location = new Point(356, 12);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(200, 42);
            button3.TabIndex = 3;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(10, 12);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(200, 42);
            button2.TabIndex = 2;
            button2.Text = "Inativar";
            button2.UseVisualStyleBackColor = false;
            // 
            // VeiculoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(943, 526);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "VeiculoPage";
            StartPosition = FormStartPosition.Manual;
            Text = "VeiculoPage";
            Load += VeiculoPage_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton3;
        private RadioButton radioButton6;
        private Label label2;
        private TextBox textBox1;
        private Button button4;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label3;
        private TextBox RelatorioTextBox;
        private Button button5;
    }
}