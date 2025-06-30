namespace AgendaFilm.View.OrdemDeServiço
{
    partial class OrdemDeServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdemDeServico));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 673);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderColor = Color.Teal;
            button1.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(4, 98);
            button1.Name = "button1";
            button1.Size = new Size(212, 113);
            button1.TabIndex = 1;
            button1.Text = "          Criar Ordem \r\n           de Serviço";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatAppearance.BorderColor = Color.Teal;
            button2.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button2.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(5, 209);
            button2.Name = "button2";
            button2.Size = new Size(211, 113);
            button2.TabIndex = 2;
            button2.Text = "        Ordens \r\n        Serviço\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Teal;
            button6.FlatAppearance.MouseOverBackColor = Color.Teal;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(5, 3);
            button6.Name = "button6";
            button6.Size = new Size(63, 53);
            button6.TabIndex = 10;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.PowderBlue;
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.ImageLocation = "500";
            pictureBox3.Location = new Point(215, 3);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1065, 96);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // OrdemDeServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1283, 680);
            ControlBox = false;
            Controls.Add(pictureBox3);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(10, 400);
            MinimizeBox = false;
            Name = "OrdemDeServico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdemDeServiço";
            Load += OrdemDeServiço_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button6;
        private PictureBox pictureBox3;
    }
}