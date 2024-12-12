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
            radioModelo = new RadioButton();
            radioTodos = new RadioButton();
            label3 = new Label();
            RelatorioTextBox = new TextBox();
            button5 = new Button();
            radioId = new RadioButton();
            radioPlaca = new RadioButton();
            label2 = new Label();
            textBoxPesquisar = new TextBox();
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
            groupBox2.Controls.Add(radioModelo);
            groupBox2.Controls.Add(radioTodos);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(RelatorioTextBox);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(radioId);
            groupBox2.Controls.Add(radioPlaca);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxPesquisar);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(23, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1040, 131);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // radioModelo
            // 
            radioModelo.Location = new Point(246, 21);
            radioModelo.Margin = new Padding(3, 4, 3, 4);
            radioModelo.Name = "radioModelo";
            radioModelo.Size = new Size(82, 32);
            radioModelo.TabIndex = 42;
            radioModelo.Text = "Modelo";
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Location = new Point(466, 25);
            radioTodos.Margin = new Padding(3, 4, 3, 4);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(70, 24);
            radioTodos.TabIndex = 39;
            radioTodos.Text = "Todos";
            radioTodos.UseVisualStyleBackColor = true;
            radioTodos.CheckedChanged += radioTodos_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(774, 61);
            label3.Name = "label3";
            label3.Size = new Size(230, 18);
            label3.TabIndex = 38;
            label3.Text = "Gerar Relatorio PDF Por Modelo:";
            label3.Click += label3_Click;
            // 
            // RelatorioTextBox
            // 
            RelatorioTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RelatorioTextBox.Location = new Point(742, 89);
            RelatorioTextBox.Margin = new Padding(3, 4, 3, 4);
            RelatorioTextBox.Name = "RelatorioTextBox";
            RelatorioTextBox.Size = new Size(274, 23);
            RelatorioTextBox.TabIndex = 37;
            // 
            // button5
            // 
            button5.BackColor = Color.SpringGreen;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button5.Location = new Point(774, 17);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(219, 42);
            button5.TabIndex = 36;
            button5.Text = "Gerar Relatório";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // radioId
            // 
            radioId.Location = new Point(334, 21);
            radioId.Margin = new Padding(3, 4, 3, 4);
            radioId.Name = "radioId";
            radioId.Size = new Size(54, 32);
            radioId.TabIndex = 40;
            radioId.Text = "ID";
            radioId.CheckedChanged += radioId_CheckedChanged;
            // 
            // radioPlaca
            // 
            radioPlaca.Location = new Point(394, 21);
            radioPlaca.Margin = new Padding(3, 4, 3, 4);
            radioPlaca.Name = "radioPlaca";
            radioPlaca.Size = new Size(96, 32);
            radioPlaca.TabIndex = 41;
            radioPlaca.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(8, 21);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 2;
            label2.Text = "Defina o tipo de pesquisa:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(230, 69);
            textBoxPesquisar.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(350, 27);
            textBoxPesquisar.TabIndex = 43;
            textBoxPesquisar.TextChanged += textBoxPesquisar_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(9, 61);
            button4.Name = "button4";
            button4.Size = new Size(200, 36);
            button4.TabIndex = 0;
            button4.Text = "Pesquisar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1040, 419);
            dataGridView1.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(23, 561);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1048, 85);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(835, 21);
            button1.Name = "button1";
            button1.Size = new Size(209, 60);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button3.Location = new Point(408, 17);
            button3.Name = "button3";
            button3.Size = new Size(209, 60);
            button3.TabIndex = 3;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(11, 17);
            button2.Name = "button2";
            button2.Size = new Size(209, 60);
            button2.TabIndex = 2;
            button2.Text = "Inativar";
            button2.UseVisualStyleBackColor = false;
            // 
            // VeiculoPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1072, 651);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
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
        private RadioButton radioId;
        private RadioButton radioPlaca;
        private RadioButton radioModelo;
        private Label label2;
        private TextBox textBoxPesquisar;
        private Button button4;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label3;
        private TextBox RelatorioTextBox;
        private Button button5;
        private RadioButton radioTodos;
    }
}