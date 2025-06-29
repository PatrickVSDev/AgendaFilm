namespace AgendaFilm.View.Cadastro.Cadastrar
{
    partial class CadastroProdutoPage
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox5 = new GroupBox();
            label2 = new Label();
            textGarantia = new TextBox();
            label4 = new Label();
            textMarca = new TextBox();
            label7 = new Label();
            label3 = new Label();
            button1 = new Button();
            label5 = new Label();
            textNome = new TextBox();
            groupBox1 = new GroupBox();
            labelFornecedorSelecionado = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Produto";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(textGarantia);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(textMarca);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(textNome);
            groupBox5.Controls.Add(groupBox1);
            groupBox5.Location = new Point(6, 60);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(696, 261);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Paint += groupBox5_Paint;
            groupBox5.Enter += groupBox5_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(403, 83);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 9;
            label2.Text = "Fornecedor :";
            // 
            // textGarantia
            // 
            textGarantia.Location = new Point(179, 205);
            textGarantia.Name = "textGarantia";
            textGarantia.Size = new Size(209, 23);
            textGarantia.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(33, 27);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 8;
            label4.Text = "Nome";
            // 
            // textMarca
            // 
            textMarca.Location = new Point(178, 142);
            textMarca.Margin = new Padding(3, 2, 3, 2);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(210, 23);
            textMarca.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F);
            label7.Location = new Point(20, 208);
            label7.Name = "label7";
            label7.Size = new Size(138, 20);
            label7.TabIndex = 0;
            label7.Text = "Garantia (em anos)";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(20, 84);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Fornecedor";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(176, 78);
            button1.Name = "button1";
            button1.Size = new Size(208, 30);
            button1.TabIndex = 2;
            button1.Text = "Selecionar Fornecedor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.Location = new Point(32, 145);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 2;
            label5.Text = "Marca";
            // 
            // textNome
            // 
            textNome.BackColor = SystemColors.ButtonHighlight;
            textNome.Location = new Point(178, 28);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(442, 23);
            textNome.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelFornecedorSelecionado);
            groupBox1.Location = new Point(513, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(166, 36);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labelFornecedorSelecionado
            // 
            labelFornecedorSelecionado.AutoSize = true;
            labelFornecedorSelecionado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelFornecedorSelecionado.ForeColor = Color.Blue;
            labelFornecedorSelecionado.Location = new Point(6, 11);
            labelFornecedorSelecionado.Name = "labelFornecedorSelecionado";
            labelFornecedorSelecionado.Size = new Size(0, 19);
            labelFornecedorSelecionado.TabIndex = 5;
            labelFornecedorSelecionado.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button2.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(491, 348);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(211, 33);
            button2.TabIndex = 5;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CadastroProdutoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 390);
            Controls.Add(button2);
            Controls.Add(groupBox5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroProdutoPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += CadastroProduto_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox5;
        private TextBox textNome;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox textMarca;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button button2;
        private TextBox textGarantia;
        private Button button1;
        private Label labelFornecedorSelecionado;
        private Label label2;
        private GroupBox groupBox1;
    }
}