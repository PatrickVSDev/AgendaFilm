namespace AgendaFilm.View.Agendamento
{
    partial class SelecionarClienteAgenda
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
            btConfirmar = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            label2 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.SpringGreen;
            btConfirmar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btConfirmar.Location = new Point(623, 410);
            btConfirmar.Margin = new Padding(3, 2, 3, 2);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(165, 32);
            btConfirmar.TabIndex = 5;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(12, 410);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(160, 32);
            button1.TabIndex = 4;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 79);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 314);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(12, 11);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(776, 64);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(290, 11);
            radioButton5.Margin = new Padding(3, 2, 3, 2);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(36, 19);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "ID";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
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
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(8, 9);
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
            textBox1.Size = new Size(528, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // SelecionarClienteAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 450);
            Controls.Add(groupBox2);
            Controls.Add(btConfirmar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "SelecionarClienteAgenda";
            Text = "SelecionarClienteAgenda";
            Load += SelecionarClienteAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btConfirmar;
        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label2;
        private TextBox textBox1;
        private Button button4;
    }
}