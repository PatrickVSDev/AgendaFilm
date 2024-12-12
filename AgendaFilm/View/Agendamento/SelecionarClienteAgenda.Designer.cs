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
            radioTodos = new RadioButton();
            radioId = new RadioButton();
            radioNome = new RadioButton();
            label2 = new Label();
            textBoxPesquisar = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.SpringGreen;
            btConfirmar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btConfirmar.Location = new Point(712, 547);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(189, 43);
            btConfirmar.TabIndex = 5;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(14, 547);
            button1.Name = "button1";
            button1.Size = new Size(183, 43);
            button1.TabIndex = 4;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(887, 419);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioTodos);
            groupBox2.Controls.Add(radioId);
            groupBox2.Controls.Add(radioNome);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxPesquisar);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(14, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(887, 85);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Location = new Point(391, 15);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(70, 24);
            radioTodos.TabIndex = 4;
            radioTodos.TabStop = true;
            radioTodos.Text = "Todos";
            radioTodos.UseVisualStyleBackColor = true;
            radioTodos.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.Location = new Point(331, 15);
            radioId.Name = "radioId";
            radioId.Size = new Size(45, 24);
            radioId.TabIndex = 2;
            radioId.TabStop = true;
            radioId.Text = "ID";
            radioId.UseVisualStyleBackColor = true;
            radioId.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioNome
            // 
            radioNome.AutoSize = true;
            radioNome.Location = new Point(247, 16);
            radioNome.Name = "radioNome";
            radioNome.Size = new Size(71, 24);
            radioNome.TabIndex = 3;
            radioNome.TabStop = true;
            radioNome.Text = "Nome";
            radioNome.UseVisualStyleBackColor = true;
            radioNome.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(9, 12);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 2;
            label2.Text = "Defina o tipo de pesquisa:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.BackColor = SystemColors.ButtonHighlight;
            textBoxPesquisar.Location = new Point(247, 47);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(603, 27);
            textBoxPesquisar.TabIndex = 1;
            textBoxPesquisar.TextChanged += textBox1_TextChanged;
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
            button4.Click += button4_Click;
            // 
            // SelecionarClienteAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 600);
            Controls.Add(groupBox2);
            Controls.Add(btConfirmar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SelecionarClienteAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Cliente";
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
        private RadioButton radioId;
        private RadioButton radioNome;
        private Label label2;
        private TextBox textBoxPesquisar;
        private Button button4;
        private RadioButton radioTodos;
    }
}