﻿namespace AgendaFilm
{
    partial class ClientePage
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
            groupBox1 = new GroupBox();
            radioTelefone = new RadioButton();
            radioId = new RadioButton();
            radioNome = new RadioButton();
            label2 = new Label();
            textBoxPesquisar = new TextBox();
            button1 = new Button();
            btInativar = new Button();
            btEditar = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            radioTodos = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioTodos);
            groupBox1.Controls.Add(radioTelefone);
            groupBox1.Controls.Add(radioId);
            groupBox1.Controls.Add(radioNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxPesquisar);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(20, 1);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(833, 69);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioTelefone
            // 
            radioTelefone.AutoSize = true;
            radioTelefone.Location = new Point(309, 13);
            radioTelefone.Margin = new Padding(2);
            radioTelefone.Name = "radioTelefone";
            radioTelefone.Size = new Size(69, 19);
            radioTelefone.TabIndex = 2;
            radioTelefone.TabStop = true;
            radioTelefone.Text = "Telefone";
            radioTelefone.UseVisualStyleBackColor = true;
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.Location = new Point(265, 13);
            radioId.Margin = new Padding(2);
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
            radioNome.Location = new Point(198, 13);
            radioNome.Margin = new Padding(2);
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
            label2.Location = new Point(7, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 2;
            label2.Text = "Defina o tipo de pesquisa:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.BackColor = SystemColors.ButtonHighlight;
            textBoxPesquisar.Location = new Point(198, 38);
            textBoxPesquisar.Margin = new Padding(2);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(623, 23);
            textBoxPesquisar.TabIndex = 1;
            textBoxPesquisar.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(5, 34);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(175, 28);
            button1.TabIndex = 0;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btInativar
            // 
            btInativar.BackColor = Color.SpringGreen;
            btInativar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btInativar.Location = new Point(10, 13);
            btInativar.Margin = new Padding(2);
            btInativar.Name = "btInativar";
            btInativar.Size = new Size(183, 45);
            btInativar.TabIndex = 2;
            btInativar.Text = "Inativar";
            btInativar.UseVisualStyleBackColor = false;
            btInativar.Click += button2_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.SpringGreen;
            btEditar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btEditar.Location = new Point(326, 13);
            btEditar.Margin = new Padding(2);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(183, 45);
            btEditar.TabIndex = 3;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button4.Location = new Point(639, 13);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(183, 45);
            button4.TabIndex = 4;
            button4.Text = "Cadastrar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 83);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(833, 398);
            dataGridView1.TabIndex = 21;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(btEditar);
            groupBox2.Controls.Add(btInativar);
            groupBox2.Location = new Point(18, 486);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(835, 69);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Location = new Point(383, 13);
            radioTodos.Margin = new Padding(3, 2, 3, 2);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(56, 19);
            radioTodos.TabIndex = 30;
            radioTodos.TabStop = true;
            radioTodos.Text = "Todos";
            radioTodos.UseVisualStyleBackColor = true;
            // 
            // ClientePage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            ClientSize = new Size(862, 562);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ClientePage";
            StartPosition = FormStartPosition.Manual;
            Text = "ClientePage";
            Load += ClientePage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBoxPesquisar;
        private Label label2;
        private RadioButton radioNome;
        private RadioButton radioId;
        private RadioButton radioTelefone;
        private Button btInativar;
        private Button btEditar;
        private Button button4;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private RadioButton radioTodos;
    }
}