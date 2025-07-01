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
            radioTodos = new RadioButton();
            radioId = new RadioButton();
            radioModelo = new RadioButton();
            label2 = new Label();
            textBoxPesquisar = new TextBox();
            button4 = new Button();
            btConfirmar = new Button();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioTodos);
            groupBox2.Controls.Add(radioId);
            groupBox2.Controls.Add(radioModelo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxPesquisar);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(12, 51);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(776, 81);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Paint += groupBox2_Paint;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Location = new Point(324, 11);
            radioTodos.Margin = new Padding(3, 2, 3, 2);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(57, 19);
            radioTodos.TabIndex = 36;
            radioTodos.TabStop = true;
            radioTodos.Text = "Todos";
            radioTodos.UseVisualStyleBackColor = true;
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.Location = new Point(282, 11);
            radioId.Margin = new Padding(3, 2, 3, 2);
            radioId.Name = "radioId";
            radioId.Size = new Size(36, 19);
            radioId.TabIndex = 2;
            radioId.TabStop = true;
            radioId.Text = "ID";
            radioId.UseVisualStyleBackColor = true;
            // 
            // radioModelo
            // 
            radioModelo.AutoSize = true;
            radioModelo.Location = new Point(216, 11);
            radioModelo.Margin = new Padding(3, 2, 3, 2);
            radioModelo.Name = "radioModelo";
            radioModelo.Size = new Size(66, 19);
            radioModelo.TabIndex = 1;
            radioModelo.TabStop = true;
            radioModelo.Text = "Modelo";
            radioModelo.UseVisualStyleBackColor = true;
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
            // textBoxPesquisar
            // 
            textBoxPesquisar.BackColor = SystemColors.ButtonHighlight;
            textBoxPesquisar.Location = new Point(216, 43);
            textBoxPesquisar.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(528, 23);
            textBoxPesquisar.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.CadetBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(8, 35);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(192, 31);
            button4.TabIndex = 4;
            button4.Text = "Pesquisar";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.PowderBlue;
            btConfirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btConfirmar.FlatStyle = FlatStyle.Flat;
            btConfirmar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btConfirmar.Location = new Point(623, 437);
            btConfirmar.Margin = new Padding(3, 2, 3, 2);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(165, 32);
            btConfirmar.TabIndex = 5;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 136);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 285);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SelecionarVeiculoAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(groupBox2);
            Controls.Add(btConfirmar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
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
        private RadioButton radioId;
        private RadioButton radioModelo;
        private Label label2;
        private TextBox textBoxPesquisar;
        private Button button4;
        private Button btConfirmar;
        private DataGridView dataGridView1;
        private RadioButton radioTodos;
    }
}