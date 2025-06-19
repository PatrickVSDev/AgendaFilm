namespace AgendaFilm.View.Cadastro
{
    partial class FornecedorPage
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
            button4 = new Button();
            radioTodos = new RadioButton();
            radioTelefone = new RadioButton();
            radioId = new RadioButton();
            radioNome = new RadioButton();
            label2 = new Label();
            textBoxPesquisar = new TextBox();
            btPesquisar = new Button();
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
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(RelatorioTextBox);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(radioTodos);
            groupBox2.Controls.Add(radioTelefone);
            groupBox2.Controls.Add(radioId);
            groupBox2.Controls.Add(radioNome);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxPesquisar);
            groupBox2.Controls.Add(btPesquisar);
            groupBox2.Location = new Point(-13, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1158, 117);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Paint += groupBox2_Paint;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(793, 63);
            label3.Name = "label3";
            label3.Size = new Size(180, 15);
            label3.TabIndex = 38;
            label3.Text = "Gerar Relatorio PDF Por Nome:";
            // 
            // RelatorioTextBox
            // 
            RelatorioTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RelatorioTextBox.Location = new Point(770, 81);
            RelatorioTextBox.Name = "RelatorioTextBox";
            RelatorioTextBox.Size = new Size(220, 20);
            RelatorioTextBox.TabIndex = 37;
            // 
            // button4
            // 
            button4.BackColor = Color.PowderBlue;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button4.Location = new Point(793, 28);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(175, 34);
            button4.TabIndex = 36;
            button4.Text = "Gerar Relatório";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Location = new Point(391, 43);
            radioTodos.Margin = new Padding(3, 2, 3, 2);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(57, 19);
            radioTodos.TabIndex = 35;
            radioTodos.TabStop = true;
            radioTodos.Text = "Todos";
            radioTodos.UseVisualStyleBackColor = true;
            // 
            // radioTelefone
            // 
            radioTelefone.AutoSize = true;
            radioTelefone.Location = new Point(317, 43);
            radioTelefone.Margin = new Padding(2);
            radioTelefone.Name = "radioTelefone";
            radioTelefone.Size = new Size(70, 19);
            radioTelefone.TabIndex = 34;
            radioTelefone.TabStop = true;
            radioTelefone.Text = "Telefone";
            radioTelefone.UseVisualStyleBackColor = true;
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.Location = new Point(277, 43);
            radioId.Margin = new Padding(3, 2, 3, 2);
            radioId.Name = "radioId";
            radioId.Size = new Size(36, 19);
            radioId.TabIndex = 2;
            radioId.TabStop = true;
            radioId.Text = "ID";
            radioId.UseVisualStyleBackColor = true;
            // 
            // radioNome
            // 
            radioNome.AutoSize = true;
            radioNome.Location = new Point(215, 43);
            radioNome.Margin = new Padding(3, 2, 3, 2);
            radioNome.Name = "radioNome";
            radioNome.Size = new Size(58, 19);
            radioNome.TabIndex = 3;
            radioNome.TabStop = true;
            radioNome.Text = "Nome";
            radioNome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(25, 42);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 2;
            label2.Text = "Defina o tipo de pesquisa:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.BackColor = SystemColors.ButtonHighlight;
            textBoxPesquisar.Location = new Point(189, 76);
            textBoxPesquisar.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(313, 23);
            textBoxPesquisar.TabIndex = 1;
            // 
            // btPesquisar
            // 
            btPesquisar.BackColor = Color.CadetBlue;
            btPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btPesquisar.Location = new Point(25, 72);
            btPesquisar.Margin = new Padding(3, 2, 3, 2);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Size = new Size(160, 29);
            btPesquisar.TabIndex = 0;
            btPesquisar.Text = "Pesquisar";
            btPesquisar.UseVisualStyleBackColor = false;
            btPesquisar.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 135);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1021, 310);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(18, 459);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1021, 111);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(819, 29);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(167, 48);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PowderBlue;
            button3.FlatAppearance.MouseDownBackColor = Color.Teal;
            button3.FlatAppearance.MouseOverBackColor = Color.Teal;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button3.Location = new Point(411, 29);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(167, 48);
            button3.TabIndex = 3;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PowderBlue;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(25, 29);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(167, 48);
            button2.TabIndex = 2;
            button2.Text = "Inativar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FornecedorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 581);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FornecedorPage";
            StartPosition = FormStartPosition.Manual;
            Text = "FornecedorPage";
            Load += FornecedorPage_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton radioId;
        private RadioButton radioNome;
        private Label label2;
        private TextBox textBoxPesquisar;
        private Button btPesquisar;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private RadioButton radioTelefone;
        private RadioButton radioTodos;
        private Label label3;
        private TextBox RelatorioTextBox;
        private Button button4;
    }
}