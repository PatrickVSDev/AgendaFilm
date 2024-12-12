namespace AgendaFilm.View.Agendamento
{
    partial class SelecionarVeiculoAgenda
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
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            label2 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            btConfirmar = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(14, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(887, 85);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(331, 13);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(45, 24);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "ID";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(247, 13);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(71, 24);
            radioButton6.TabIndex = 3;
            radioButton6.TabStop = true;
            radioButton6.Text = "Nome";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(9, 11);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 2;
            label2.Text = "Defina o tipo de pesquisa:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(247, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(603, 27);
            textBox1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(6, 43);
            button4.Name = "button4";
            button4.Size = new Size(219, 35);
            button4.TabIndex = 0;
            button4.Text = "Pesquisar";
            button4.UseVisualStyleBackColor = false;
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.SpringGreen;
            btConfirmar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btConfirmar.Location = new Point(712, 545);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(189, 43);
            btConfirmar.TabIndex = 34;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(14, 545);
            button1.Name = "button1";
            button1.Size = new Size(183, 43);
            button1.TabIndex = 33;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(887, 419);
            dataGridView1.TabIndex = 32;
            // 
            // SelecionarVeiculoAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox2);
            Controls.Add(btConfirmar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SelecionarVeiculoAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Veiculo";
            Load += SelecionarVeiculoAgenda_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label2;
        private TextBox textBox1;
        private Button button4;
        private Button btConfirmar;
        private Button button1;
        private DataGridView dataGridView1;
    }
}