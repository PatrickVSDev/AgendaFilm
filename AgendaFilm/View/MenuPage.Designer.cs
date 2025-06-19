namespace AgendaFilm
{
    partial class MenuPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            Relatorios = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbUsuarioLogado = new Label();
            lDataMenu = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            button4 = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.PowderBlue;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Teal;
            button1.FlatAppearance.MouseOverBackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(389, 5);
            button1.Name = "button1";
            button1.Size = new Size(229, 213);
            button1.TabIndex = 0;
            button1.Text = "Cadastros";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 896);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.PowderBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Teal;
            button2.FlatAppearance.MouseOverBackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(617, 5);
            button2.Name = "button2";
            button2.Size = new Size(229, 213);
            button2.TabIndex = 2;
            button2.Text = "Agendamentos";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Relatorios
            // 
            Relatorios.AutoSize = true;
            Relatorios.BackColor = Color.PowderBlue;
            Relatorios.FlatAppearance.BorderSize = 0;
            Relatorios.FlatAppearance.MouseDownBackColor = Color.Teal;
            Relatorios.FlatAppearance.MouseOverBackColor = Color.Teal;
            Relatorios.FlatStyle = FlatStyle.Flat;
            Relatorios.Font = new Font("Segoe UI Semibold", 12F);
            Relatorios.Image = (Image)resources.GetObject("Relatorios.Image");
            Relatorios.Location = new Point(846, 5);
            Relatorios.Name = "Relatorios";
            Relatorios.Size = new Size(229, 213);
            Relatorios.TabIndex = 3;
            Relatorios.Text = "Ordem de Serviço";
            Relatorios.TextAlign = ContentAlignment.BottomCenter;
            Relatorios.TextImageRelation = TextImageRelation.ImageAboveText;
            Relatorios.UseVisualStyleBackColor = false;
            Relatorios.Click += Relatorios_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.PowderBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Teal;
            button3.FlatAppearance.MouseOverBackColor = Color.Teal;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(1074, 5);
            button3.Name = "button3";
            button3.Size = new Size(229, 213);
            button3.TabIndex = 4;
            button3.Text = "Lembretes";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // lbUsuarioLogado
            // 
            lbUsuarioLogado.AutoSize = true;
            lbUsuarioLogado.BackColor = Color.WhiteSmoke;
            lbUsuarioLogado.Font = new Font("Calibri", 38F, FontStyle.Bold);
            lbUsuarioLogado.ForeColor = Color.DarkSlateGray;
            lbUsuarioLogado.Location = new Point(695, 329);
            lbUsuarioLogado.Name = "lbUsuarioLogado";
            lbUsuarioLogado.Size = new Size(195, 78);
            lbUsuarioLogado.TabIndex = 7;
            lbUsuarioLogado.Text = "label1";
            lbUsuarioLogado.Click += lbUsuarioLogado_Click;
            // 
            // lDataMenu
            // 
            lDataMenu.AutoSize = true;
            lDataMenu.BackColor = Color.WhiteSmoke;
            lDataMenu.Font = new Font("Calibri", 15F);
            lDataMenu.Location = new Point(66, 47);
            lDataMenu.Name = "lDataMenu";
            lDataMenu.Size = new Size(0, 31);
            lDataMenu.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.PowderBlue;
            pictureBox3.Location = new Point(209, 5);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1248, 213);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox4.BackColor = Color.PowderBlue;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");

            pictureBox4.Location = new Point(283, 323);

            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(345, 243);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 38F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(333, 329);
            label1.Name = "label1";
            label1.Size = new Size(480, 78);
            label1.TabIndex = 10;
            label1.Text = "Bem-vindo(a),     ";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lDataMenu);
            groupBox1.Location = new Point(230, 768);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1227, 133);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15F);
            label2.Location = new Point(963, 49);
            label2.Name = "label2";
            label2.Size = new Size(224, 31);
            label2.TabIndex = 7;
            label2.Text = "AgendaFilm ©  2025";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Teal;
            button4.FlatAppearance.MouseOverBackColor = Color.Teal;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(5, 5);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(72, 71);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;

            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(58, 619);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);

            label3.TabIndex = 13;
            label3.Text = "HOME";
            label3.Click += label3_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(283, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(857, 79);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Paint += groupBox2_Paint;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // MenuPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1461, 860);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(lbUsuarioLogado);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(button3);
            Controls.Add(Relatorios);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(groupBox1);

            Controls.Add(groupBox2);

            Name = "MenuPage";
            Text = "PaginaRestrita";
            Load += PaginaRestrita_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button Relatorios;
        private Button button3;
        private Label lDataMenu;
        private System.Windows.Forms.Timer timer1;
        private Label lbUsuarioLogado;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button button4;
        private Label label3;
        private GroupBox groupBox2;
    }
}