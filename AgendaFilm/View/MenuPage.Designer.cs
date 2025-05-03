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
            pictureBox2 = new PictureBox();
            lDataMenu = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lbUsuarioLogado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(393, 0);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(274, 274);
            button1.TabIndex = 0;
            button1.Text = "Cadastros";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2404, 274);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(673, 0);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(286, 274);
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
            Relatorios.BackColor = SystemColors.ActiveCaption;
            Relatorios.FlatAppearance.BorderSize = 0;
            Relatorios.FlatStyle = FlatStyle.Flat;
            Relatorios.Font = new Font("Segoe UI Semibold", 12F);
            Relatorios.Image = (Image)resources.GetObject("Relatorios.Image");
            Relatorios.Location = new Point(967, 0);
            Relatorios.Margin = new Padding(4);
            Relatorios.Name = "Relatorios";
            Relatorios.Size = new Size(304, 274);
            Relatorios.TabIndex = 3;
            Relatorios.Text = "Relatórios";
            Relatorios.TextAlign = ContentAlignment.BottomCenter;
            Relatorios.TextImageRelation = TextImageRelation.ImageAboveText;
            Relatorios.UseVisualStyleBackColor = false;
            Relatorios.Click += Relatorios_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = SystemColors.ActiveCaption;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(1278, 0);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(290, 274);
            button3.TabIndex = 4;
            button3.Text = "Lembretes";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_1_removebg_preview;
            pictureBox2.Location = new Point(603, 519);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(668, 352);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // lDataMenu
            // 
            lDataMenu.AutoSize = true;
            lDataMenu.BackColor = SystemColors.ActiveCaption;
            lDataMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDataMenu.Location = new Point(0, 1204);
            lDataMenu.Margin = new Padding(4, 0, 4, 0);
            lDataMenu.Name = "lDataMenu";
            lDataMenu.Size = new Size(0, 32);
            lDataMenu.TabIndex = 6;
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
            lbUsuarioLogado.BackColor = SystemColors.ActiveCaption;
            lbUsuarioLogado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuarioLogado.Location = new Point(0, 274);
            lbUsuarioLogado.Margin = new Padding(4, 0, 4, 0);
            lbUsuarioLogado.Name = "lbUsuarioLogado";
            lbUsuarioLogado.Size = new Size(83, 32);
            lbUsuarioLogado.TabIndex = 7;
            lbUsuarioLogado.Text = "label1";
            lbUsuarioLogado.Click += lbUsuarioLogado_Click;
            // 
            // MenuPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1924, 1050);
            Controls.Add(lbUsuarioLogado);
            Controls.Add(lDataMenu);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(Relatorios);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuPage";
            Text = "PaginaRestrita";
            WindowState = FormWindowState.Maximized;
            Load += PaginaRestrita_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button Relatorios;
        private Button button3;
        private PictureBox pictureBox2;
        private Label lDataMenu;
        private System.Windows.Forms.Timer timer1;
        private Label lbUsuarioLogado;
    }
}