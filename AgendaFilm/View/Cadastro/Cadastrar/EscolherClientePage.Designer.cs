
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
            btConfirmar = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            txtPesquisaNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 123);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(785, 214);
            dataGridView1.TabIndex = 0;
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.PowderBlue;
            btConfirmar.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btConfirmar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btConfirmar.FlatStyle = FlatStyle.Flat;
            btConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btConfirmar.Location = new Point(346, 341);
            btConfirmar.Margin = new Padding(3, 2, 3, 2);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(124, 31);
            btConfirmar.TabIndex = 3;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtPesquisaNome);
            groupBox1.Location = new Point(16, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 78);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "Pesquisa: Nome";
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(10, 37);
            button1.Name = "button1";
            button1.Size = new Size(123, 30);
            button1.TabIndex = 2;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // txtPesquisaNome
            // 
            txtPesquisaNome.Location = new Point(139, 41);
            txtPesquisaNome.Name = "txtPesquisaNome";
            txtPesquisaNome.Size = new Size(222, 23);
            txtPesquisaNome.TabIndex = 1;
            // 
            // EscolherClientePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 379);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(btConfirmar);
            Controls.Add(dataGridView1);
            Location = new Point(6, 38);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EscolherClientePage";
            Load += EscolherClientePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private DataGridView dataGridView1;
        private Button btConfirmar;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private TextBox txtPesquisaNome;
    }
}