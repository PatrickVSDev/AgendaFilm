
namespace AgendaFilm.View.Cadastro.Cadastrar
{
    partial class EscolherClientePage
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(875, 297);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(10, 318);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 1;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.SpringGreen;
            btConfirmar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btConfirmar.Location = new Point(721, 316);
            btConfirmar.Margin = new Padding(3, 2, 3, 2);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(164, 32);
            btConfirmar.TabIndex = 2;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // EscolherClientePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 356);
            Controls.Add(btConfirmar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EscolherClientePage";
            Text = "EscolherClientePage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button btConfirmar;
    }
}