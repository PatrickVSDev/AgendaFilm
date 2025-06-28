namespace AgendaFilm
{
    partial class CadastroPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPage));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            Veíc = new Button();
            button3 = new Button();
            button4 = new Button();
            lbUsuarioLogado = new Label();
            button5 = new Button();
            button6 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 673);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.PowderBlue;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.ImageLocation = "500";
            pictureBox2.Location = new Point(215, 3);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1065, 96);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.Teal;
            button1.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(4, 493);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(212, 100);
            button1.TabIndex = 2;
            button1.Text = "Funcionários";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.Teal;
            button2.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button2.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(4, 98);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(212, 100);
            button2.TabIndex = 3;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Veíc
            // 
            Veíc.BackColor = Color.DarkSlateGray;
            Veíc.BackgroundImageLayout = ImageLayout.None;
            Veíc.FlatAppearance.BorderColor = Color.Teal;
            Veíc.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            Veíc.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            Veíc.FlatStyle = FlatStyle.Flat;
            Veíc.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            Veíc.Image = (Image)resources.GetObject("Veíc.Image");
            Veíc.ImageAlign = ContentAlignment.MiddleLeft;
            Veíc.Location = new Point(4, 196);
            Veíc.Margin = new Padding(3, 2, 3, 2);
            Veíc.Name = "Veíc";
            Veíc.Size = new Size(212, 100);
            Veíc.TabIndex = 4;
            Veíc.Text = " Veículos";
            Veíc.UseVisualStyleBackColor = false;
            Veíc.Click += Veíc_Click;
            // 
            // button3
            // 
            button3.Location = new Point(617, 276);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(7, 6);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.FlatAppearance.BorderColor = Color.Teal;
            button4.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button4.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(4, 295);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(212, 100);
            button4.TabIndex = 6;
            button4.Text = "Produtos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // lbUsuarioLogado
            // 
            lbUsuarioLogado.AutoSize = true;
            lbUsuarioLogado.BackColor = SystemColors.ActiveCaption;
            lbUsuarioLogado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuarioLogado.Location = new Point(0, 1);
            lbUsuarioLogado.Name = "lbUsuarioLogado";
            lbUsuarioLogado.Size = new Size(0, 21);
            lbUsuarioLogado.TabIndex = 8;
            lbUsuarioLogado.Click += lbUsuarioLogado_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateGray;
            button5.FlatAppearance.BorderColor = Color.Teal;
            button5.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button5.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(4, 394);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(212, 100);
            button5.TabIndex = 7;
            button5.Text = "     Fornecedores";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Teal;
            button6.FlatAppearance.MouseOverBackColor = Color.Teal;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(4, 3);
            button6.Name = "button6";
            button6.Size = new Size(63, 53);
            button6.TabIndex = 9;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(41, 630);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 14;
            label3.Text = "CADASTROS";
            // 
            // CadastroPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1283, 680);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(button6);
            Controls.Add(pictureBox2);
            Controls.Add(lbUsuarioLogado);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Veíc);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(10, 400);
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "CadastroPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += CadastroPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button Veíc;
        private Button button3;
        private Button button4;
        private Label lbUsuarioLogado;
        private Button button5;
        private Button button6;
        private Label label3;
    }
}