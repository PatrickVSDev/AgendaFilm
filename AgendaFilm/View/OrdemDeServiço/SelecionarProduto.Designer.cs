﻿namespace AgendaFilm.View.OrdemDeServiço
{
    partial class SelecionarProduto
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
            textBoxPesquisar = new TextBox();
            button4 = new Button();
            radioTodos = new RadioButton();
            radioId = new RadioButton();
            radioNome = new RadioButton();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btConfirmar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPesquisar);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(radioTodos);
            groupBox1.Controls.Add(radioId);
            groupBox1.Controls.Add(radioNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.BackColor = SystemColors.ButtonHighlight;
            textBoxPesquisar.Location = new Point(139, 41);
            textBoxPesquisar.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(222, 23);
            textBoxPesquisar.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.CadetBlue;
            button4.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(10, 37);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(123, 30);
            button4.TabIndex = 7;
            button4.Text = "Pesquisar";
            button4.UseVisualStyleBackColor = false;
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Location = new Point(304, 18);
            radioTodos.Margin = new Padding(3, 2, 3, 2);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(56, 19);
            radioTodos.TabIndex = 6;
            radioTodos.TabStop = true;
            radioTodos.Text = "Todos";
            radioTodos.UseVisualStyleBackColor = true;
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.Location = new Point(260, 18);
            radioId.Margin = new Padding(3, 2, 3, 2);
            radioId.Name = "radioId";
            radioId.Size = new Size(36, 19);
            radioId.TabIndex = 5;
            radioId.TabStop = true;
            radioId.Text = "ID";
            radioId.UseVisualStyleBackColor = true;
            // 
            // radioNome
            // 
            radioNome.AutoSize = true;
            radioNome.Location = new Point(198, 18);
            radioNome.Margin = new Padding(3, 2, 3, 2);
            radioNome.Name = "radioNome";
            radioNome.Size = new Size(58, 19);
            radioNome.TabIndex = 4;
            radioNome.TabStop = true;
            radioNome.Text = "Nome";
            radioNome.UseVisualStyleBackColor = true;
            radioNome.CheckedChanged += radioNome_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(6, -2);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 1;
            label1.Text = "Defina o tipo de pesquisa:";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 110);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(785, 207);
            dataGridView1.TabIndex = 33;
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.PowderBlue;
            btConfirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btConfirmar.FlatStyle = FlatStyle.Flat;
            btConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btConfirmar.Location = new Point(342, 321);
            btConfirmar.Margin = new Padding(3, 2, 3, 2);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(124, 32);
            btConfirmar.TabIndex = 35;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            // 
            // SelecionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 379);
            ControlBox = false;
            Controls.Add(btConfirmar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "SelecionarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SelecionarProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private RadioButton radioNome;
        private RadioButton radioId;
        private RadioButton radioTodos;
        private Button button4;
        private TextBox textBoxPesquisar;
        private DataGridView dataGridView1;
        private Button btConfirmar;
    }
}