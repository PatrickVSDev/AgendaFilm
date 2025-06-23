namespace AgendaFilm.View.Editar
{
    partial class EditarVeiculoPage
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
            button1 = new Button();
            textAno = new TextBox();
            label4 = new Label();
            textModelo = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textPlaca = new TextBox();
            label3 = new Label();
            textMarca = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(491, 273);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(211, 33);
            button1.TabIndex = 28;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textAno
            // 
            textAno.Location = new Point(442, 96);
            textAno.Name = "textAno";
            textAno.Size = new Size(100, 23);
            textAno.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(370, 98);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 2;
            label4.Text = "Ano";
            // 
            // textModelo
            // 
            textModelo.Location = new Point(137, 95);
            textModelo.Margin = new Padding(3, 2, 3, 2);
            textModelo.Name = "textModelo";
            textModelo.Size = new Size(151, 23);
            textModelo.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.Location = new Point(37, 95);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 0;
            label5.Text = "Modelo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textAno);
            groupBox1.Controls.Add(textPlaca);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textModelo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textMarca);
            groupBox1.Location = new Point(6, 60);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(696, 180);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(44, 33);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "Placa";
            // 
            // textPlaca
            // 
            textPlaca.Location = new Point(137, 30);
            textPlaca.Margin = new Padding(3, 2, 3, 2);
            textPlaca.Name = "textPlaca";
            textPlaca.Size = new Size(151, 23);
            textPlaca.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(364, 33);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // textMarca
            // 
            textMarca.Location = new Point(442, 34);
            textMarca.Margin = new Padding(3, 2, 3, 2);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(207, 23);
            textMarca.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 24;
            label1.Text = "Editar Veículos";
            // 
            // EditarVeiculoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 318);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditarVeiculoPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarVeiculoPage";
            Load += EditarVeiculoPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private TextBox textModelo;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textMarca;
        private Label label3;
        private TextBox textPlaca;
        private Label label2;
        private Label label1;
        private TextBox textAno;
    }
}