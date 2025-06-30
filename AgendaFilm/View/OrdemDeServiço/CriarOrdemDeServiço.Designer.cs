namespace AgendaFilm.View.OrdemDeServiço
{
    partial class CriarOrdemDeServiço
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
            dgvAgendamento = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtValor = new TextBox();
            dgvProdutos = new DataGridView();
            button3 = new Button();
            btnImprimir = new Button();
            label1 = new Label();
            label3 = new Label();
            txtObservacoes = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamento).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvAgendamento
            // 
            dgvAgendamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgendamento.Location = new Point(232, 38);
            dgvAgendamento.Name = "dgvAgendamento";
            dgvAgendamento.Size = new Size(756, 86);
            dgvAgendamento.TabIndex = 0;
            dgvAgendamento.CellContentClick += dgvAgendamento_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(dgvProdutos);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnImprimir);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtObservacoes);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dgvAgendamento);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1038, 561);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(232, 127);
            label4.Name = "label4";
            label4.Size = new Size(186, 21);
            label4.TabIndex = 11;
            label4.Text = "Produtos selecionados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(232, 14);
            label2.Name = "label2";
            label2.Size = new Size(219, 21);
            label2.TabIndex = 10;
            label2.Text = "Agendamento selecionado:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtValor);
            groupBox2.Location = new Point(77, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(129, 43);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Paint += groupBox2_Paint1;
            groupBox2.Enter += groupBox2_Enter_1;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(13, 14);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 12;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(232, 151);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(756, 171);
            dgvProdutos.TabIndex = 8;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.PowderBlue;
            button3.FlatAppearance.MouseDownBackColor = Color.Teal;
            button3.FlatAppearance.MouseOverBackColor = Color.Teal;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(18, 38);
            button3.Name = "button3";
            button3.Size = new Size(188, 46);
            button3.TabIndex = 1;
            button3.Text = "Selecionar Agendamento";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.CadetBlue;
            btnImprimir.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnImprimir.Location = new Point(869, 522);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(119, 33);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(8, 295);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 5;
            label1.Text = "Valor :";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSeaGreen;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(232, 365);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 1;
            label3.Text = "Observações";
            label3.Click += label3_Click;
            label3.Paint += label3_Paint;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(232, 389);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(756, 122);
            txtObservacoes.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.Teal;
            button1.FlatAppearance.MouseOverBackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(18, 151);
            button1.Name = "button1";
            button1.Size = new Size(188, 46);
            button1.TabIndex = 2;
            button1.Text = "Selecionar Produto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CriarOrdemDeServiço
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1062, 577);
            ControlBox = false;
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(218, 150);
            Name = "CriarOrdemDeServiço";
            StartPosition = FormStartPosition.Manual;
            Text = "i";
            Load += CriarOrdemDeServiço_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAgendamento).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAgendamento;
        private GroupBox groupBox1;
        private TextBox txtObservacoes;
        private Button button1;
        private Button btnImprimir;
        private Label label1;
        private Label label3;
        private Button button3;
        private GroupBox groupBox2;
        private DataGridView dgvProdutos;
        private Label label4;
        private Label label2;
        private TextBox txtValor;
    }
}