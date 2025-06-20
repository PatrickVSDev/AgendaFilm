namespace AgendaFilm.View.Cadastro.Cadastrar
{
    partial class CadastroVeiculoPage
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btEscolherCliente = new Button();
            label2 = new Label();
            txtAno = new TextBox();
            txtPlaca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            btSalvar = new Button();
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
            label1.Size = new Size(283, 37);
            label1.TabIndex = 2;
            label1.Text = "Cadastro de Veículos";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btEscolherCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAno);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Location = new Point(6, 60);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(696, 180);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btEscolherCliente
            // 
            btEscolherCliente.BackColor = Color.Teal;
            btEscolherCliente.FlatStyle = FlatStyle.Flat;
            btEscolherCliente.Font = new Font("Segoe UI Semibold", 11F);
            btEscolherCliente.Location = new Point(289, 139);
            btEscolherCliente.Margin = new Padding(3, 2, 3, 2);
            btEscolherCliente.Name = "btEscolherCliente";
            btEscolherCliente.Size = new Size(135, 26);
            btEscolherCliente.TabIndex = 0;
            btEscolherCliente.Text = "Escolher cliente";
            btEscolherCliente.UseVisualStyleBackColor = false;
            btEscolherCliente.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(30, 35);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "Placa";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(457, 90);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 3;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(123, 36);
            txtPlaca.Margin = new Padding(3, 2, 3, 2);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(151, 23);
            txtPlaca.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(380, 93);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 2;
            label4.Text = "Ano";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(372, 35);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.Location = new Point(25, 93);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 0;
            label5.Text = "Modelo";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(457, 35);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(207, 23);
            txtMarca.TabIndex = 4;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(123, 90);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(223, 23);
            txtModelo.TabIndex = 3;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.CadetBlue;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btSalvar.Location = new Point(491, 273);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(211, 33);
            btSalvar.TabIndex = 23;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // CadastroVeiculoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 318);
            Controls.Add(btSalvar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroVeiculoPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Veiculo";
            Load += CadastroVeiculoPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMarca;
        private Label label3;
        private TextBox txtPlaca;
        private Label label2;
        private Label label4;
        private TextBox txtModelo;
        private Label label5;
        private Button btSalvar;
        private Button btEscolherCliente;
        private TextBox txtAno;
    }
}