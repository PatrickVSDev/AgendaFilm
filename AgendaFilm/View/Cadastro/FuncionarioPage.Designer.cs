namespace AgendaFilm
{
    partial class FuncionarioPage
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
            dataGridView1 = new DataGridView();
            radioCargo = new RadioButton();
            groupBox2 = new GroupBox();
            radioTodos = new RadioButton();
            radioId = new RadioButton();
            radioNome = new RadioButton();
            label2 = new Label();
            textBoxPesquisar = new TextBox();
            btPesquisar = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btEditar = new Button();
            btInativar = new Button();
            label3 = new Label();
            RelatorioTextBox = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 78);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(911, 373);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // radioCargo
            // 
            radioCargo.AutoSize = true;
            radioCargo.Location = new Point(336, 12);
            radioCargo.Margin = new Padding(3, 2, 3, 2);
            radioCargo.Name = "radioCargo";
            radioCargo.Size = new Size(57, 19);
            radioCargo.TabIndex = 28;
            radioCargo.TabStop = true;
            radioCargo.Text = "Cargo";
            radioCargo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(RelatorioTextBox);
            groupBox2.Controls.Add(radioTodos);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(radioId);
            groupBox2.Controls.Add(radioCargo);
            groupBox2.Controls.Add(radioNome);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxPesquisar);
            groupBox2.Controls.Add(btPesquisar);
            groupBox2.Location = new Point(22, 1);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(917, 73);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Location = new Point(402, 13);
            radioTodos.Margin = new Padding(3, 2, 3, 2);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(56, 19);
            radioTodos.TabIndex = 29;
            radioTodos.TabStop = true;
            radioTodos.Text = "Todos";
            radioTodos.UseVisualStyleBackColor = true;
            radioTodos.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.Location = new Point(287, 12);
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
            radioNome.Location = new Point(216, 12);
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
            label2.Location = new Point(8, 10);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 2;
            label2.Text = "Defina o tipo de pesquisa:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.BackColor = SystemColors.ButtonHighlight;
            textBoxPesquisar.Location = new Point(216, 35);
            textBoxPesquisar.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(242, 23);
            textBoxPesquisar.TabIndex = 1;
            // 
            // btPesquisar
            // 
            btPesquisar.BackColor = Color.SpringGreen;
            btPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btPesquisar.Location = new Point(5, 32);
            btPesquisar.Margin = new Padding(3, 2, 3, 2);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Size = new Size(192, 26);
            btPesquisar.TabIndex = 0;
            btPesquisar.Text = "Pesquisar";
            btPesquisar.UseVisualStyleBackColor = false;
            btPesquisar.Click += button4_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btEditar);
            groupBox1.Controls.Add(btInativar);
            groupBox1.Location = new Point(19, 455);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(914, 64);
            groupBox1.TabIndex = 30;
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
            button1.Click += button1_Click_1;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.SpringGreen;
            btEditar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btEditar.Location = new Point(356, 12);
            btEditar.Margin = new Padding(3, 2, 3, 2);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(200, 42);
            btEditar.TabIndex = 3;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // btInativar
            // 
            btInativar.BackColor = Color.SpringGreen;
            btInativar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btInativar.Location = new Point(10, 12);
            btInativar.Margin = new Padding(3, 2, 3, 2);
            btInativar.Name = "btInativar";
            btInativar.Size = new Size(200, 42);
            btInativar.TabIndex = 2;
            btInativar.Text = "Inativar";
            btInativar.UseVisualStyleBackColor = false;
            btInativar.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(635, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 15);
            label3.TabIndex = 38;
            label3.Text = "Gerar Relatorio PDF Por Nome:";
            // 
            // RelatorioTextBox
            // 
            RelatorioTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RelatorioTextBox.Location = new Point(616, 21);
            RelatorioTextBox.Name = "RelatorioTextBox";
            RelatorioTextBox.Size = new Size(240, 20);
            RelatorioTextBox.TabIndex = 37;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(640, 46);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(175, 27);
            button2.TabIndex = 36;
            button2.Text = "Gerar Relatório";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // FuncionarioPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(943, 526);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FuncionarioPage";
            StartPosition = FormStartPosition.Manual;
            Text = "Gerente";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private RadioButton radioCargo;
        private GroupBox groupBox2;
        private RadioButton radioId;
        private RadioButton radioNome;
        private Label label2;
        private TextBox textBoxPesquisar;
        private Button btPesquisar;
        private GroupBox groupBox1;
        private Button button1;
        private Button btEditar;
        private Button btInativar;
        private RadioButton radioTodos;
        private Label label3;
        private TextBox RelatorioTextBox;
        private Button button2;
    }
}