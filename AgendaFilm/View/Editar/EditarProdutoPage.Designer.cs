namespace AgendaFilm.View.Editar
{
    partial class EditarProdutoPage
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
            btSalvar = new Button();
            textGarantia = new TextBox();
            label7 = new Label();
            textMarca = new TextBox();
            label5 = new Label();
            groupBox5 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btSelecionarFornecedor = new Button();
            groupBox1 = new GroupBox();
            labelFornecedorSelecionado = new Label();
            textNome = new TextBox();
            label1 = new Label();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.CadetBlue;
            btSalvar.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btSalvar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btSalvar.Location = new Point(491, 322);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(211, 33);
            btSalvar.TabIndex = 19;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click_1;
            // 
            // textGarantia
            // 
            textGarantia.Location = new Point(163, 182);
            textGarantia.Name = "textGarantia";
            textGarantia.Size = new Size(236, 23);
            textGarantia.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F);
            label7.Location = new Point(35, 185);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 0;
            label7.Text = "Garantia";
            // 
            // textMarca
            // 
            textMarca.Location = new Point(163, 134);
            textMarca.Margin = new Padding(3, 2, 3, 2);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(236, 23);
            textMarca.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.Location = new Point(41, 133);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 2;
            label5.Text = "Marca";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(textGarantia);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(btSelecionarFornecedor);
            groupBox5.Controls.Add(groupBox1);
            groupBox5.Controls.Add(textMarca);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(textNome);
            groupBox5.Controls.Add(label5);
            groupBox5.Location = new Point(6, 60);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(696, 238);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Paint += groupBox5_Paint;
            groupBox5.Enter += groupBox5_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(392, 80);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 22;
            label2.Text = "Fornecedor :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(31, 81);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 20;
            label3.Text = "Fornecedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(42, 30);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 8;
            label4.Text = "Nome";
            // 
            // btSelecionarFornecedor
            // 
            btSelecionarFornecedor.BackColor = Color.Teal;
            btSelecionarFornecedor.FlatStyle = FlatStyle.Flat;
            btSelecionarFornecedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btSelecionarFornecedor.Location = new Point(165, 75);
            btSelecionarFornecedor.Name = "btSelecionarFornecedor";
            btSelecionarFornecedor.Size = new Size(208, 30);
            btSelecionarFornecedor.TabIndex = 21;
            btSelecionarFornecedor.Text = "Selecionar Fornecedor";
            btSelecionarFornecedor.UseVisualStyleBackColor = false;
            btSelecionarFornecedor.Click += btSelecionarFornecedor_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelFornecedorSelecionado);
            groupBox1.Location = new Point(502, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(166, 36);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
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
            // 
            // textNome
            // 
            textNome.BackColor = SystemColors.ButtonHighlight;
            textNome.Location = new Point(163, 30);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(433, 23);
            textNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(206, 37);
            label1.TabIndex = 15;
            label1.Text = "Editar Produto";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // EditarProdutoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 369);
            Controls.Add(btSalvar);
            Controls.Add(groupBox5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditarProdutoPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarProdutoPage";
            Load += EditarProdutoPage_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalvar;
        private Label label7;
        private TextBox textMarca;
        private Label label5;
        private GroupBox groupBox5;
        private Label label4;
        private TextBox textNome;
        private Label label1;
        private TextBox textGarantia;
        private Label label2;
        private Label label3;
        private Button btSelecionarFornecedor;
        private GroupBox groupBox1;
        private Label labelFornecedorSelecionado;
    }
}