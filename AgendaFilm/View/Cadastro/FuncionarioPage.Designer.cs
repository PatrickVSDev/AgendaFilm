﻿namespace AgendaFilm
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
            label3 = new Label();
            RelatorioTextBox = new TextBox();
            radioTodos = new RadioButton();
            button2 = new Button();
            radioId = new RadioButton();
            radioNome = new RadioButton();
            label2 = new Label();
            textBoxPesquisar = new TextBox();
            btPesquisar = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btEditar = new Button();
            btInativar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1040, 419);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // radioCargo
            // 
            radioCargo.AutoSize = true;
            radioCargo.Location = new Point(374, 24);
            radioCargo.Name = "radioCargo";
            radioCargo.Size = new Size(70, 24);
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
            groupBox2.Location = new Point(23, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1040, 131);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(774, 61);
            label3.Name = "label3";
            label3.Size = new Size(221, 18);
            label3.TabIndex = 38;
            label3.Text = "Gerar Relatorio PDF Por Nome:";
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
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Location = new Point(450, 24);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(70, 24);
            radioTodos.TabIndex = 29;
            radioTodos.TabStop = true;
            radioTodos.Text = "Todos";
            radioTodos.UseVisualStyleBackColor = true;
            radioTodos.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(774, 17);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(219, 42);
            button2.TabIndex = 36;
            button2.Text = "Gerar Relatório";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.Location = new Point(324, 24);
            radioId.Name = "radioId";
            radioId.Size = new Size(45, 24);
            radioId.TabIndex = 2;
            radioId.TabStop = true;
            radioId.Text = "ID";
            radioId.UseVisualStyleBackColor = true;
            // 
            // radioNome
            // 
            radioNome.AutoSize = true;
            radioNome.Location = new Point(246, 24);
            radioNome.Name = "radioNome";
            radioNome.Size = new Size(71, 24);
            radioNome.TabIndex = 3;
            radioNome.TabStop = true;
            radioNome.Text = "Nome";
            radioNome.UseVisualStyleBackColor = true;
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
            textBoxPesquisar.BackColor = SystemColors.ButtonHighlight;
            textBoxPesquisar.Location = new Point(232, 69);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(321, 27);
            textBoxPesquisar.TabIndex = 1;
            // 
            // btPesquisar
            // 
            btPesquisar.BackColor = Color.SpringGreen;
            btPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btPesquisar.ImageAlign = ContentAlignment.TopCenter;
            btPesquisar.Location = new Point(9, 61);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Size = new Size(200, 36);
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
            groupBox1.Location = new Point(23, 561);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1048, 85);
            groupBox1.TabIndex = 30;
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
            button1.Click += button1_Click_1;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.SpringGreen;
            btEditar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btEditar.Location = new Point(408, 17);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(209, 60);
            btEditar.TabIndex = 3;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // btInativar
            // 
            btInativar.BackColor = Color.SpringGreen;
            btInativar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btInativar.Location = new Point(11, 17);
            btInativar.Name = "btInativar";
            btInativar.Size = new Size(209, 60);
            btInativar.TabIndex = 2;
            btInativar.Text = "Inativar";
            btInativar.UseVisualStyleBackColor = false;
            btInativar.Click += button2_Click;
            // 
            // FuncionarioPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1072, 651);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
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