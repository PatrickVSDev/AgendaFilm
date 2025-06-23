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
            button2 = new Button();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            groupBox5 = new GroupBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button2.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(491, 322);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(211, 33);
            button2.TabIndex = 19;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 23);
            textBox3.TabIndex = 16;
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
            // textBox5
            // 
            textBox5.Location = new Point(163, 134);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(236, 23);
            textBox5.TabIndex = 3;
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
            // textBox1
            // 
            textBox1.Location = new Point(163, 77);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(26, 80);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Fornecedor";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(textBox5);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(textBox1);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(textBox2);
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
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(163, 30);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(433, 23);
            textBox2.TabIndex = 0;
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
            Controls.Add(button2);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label7;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox1;
        private Label label3;
        private GroupBox groupBox5;
        private Label label4;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
    }
}