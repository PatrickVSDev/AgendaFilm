namespace AgendaFilm
{
    partial class PaginaRestrita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaRestrita));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            Relatorios = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            lDataMenu = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
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
            button1.Location = new Point(501, 0);
            button1.Name = "button1";
            button1.Size = new Size(219, 219);
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
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1923, 219);
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
            button2.Location = new Point(725, 0);
            button2.Name = "button2";
            button2.Size = new Size(229, 219);
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
            Relatorios.Location = new Point(960, 0);
            Relatorios.Name = "Relatorios";
            Relatorios.Size = new Size(243, 219);
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
            button3.Location = new Point(1209, 0);
            button3.Name = "button3";
            button3.Size = new Size(232, 219);
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
            pictureBox2.Location = new Point(626, 415);
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
            lDataMenu.Location = new Point(0, 963);
            lDataMenu.Name = "lDataMenu";
            lDataMenu.Size = new Size(0, 28);
            lDataMenu.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // PaginaRestrita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(2176, 1325);
            Controls.Add(lDataMenu);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(Relatorios);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaginaRestrita";
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
    }
}