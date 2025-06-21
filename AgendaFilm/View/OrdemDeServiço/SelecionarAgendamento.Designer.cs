namespace AgendaFilm.View.OrdemDeServiço
{
    partial class SelecionarAgendamento
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
            btConfirmar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBoxPesquisar = new TextBox();
            button4 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.PowderBlue;
            btConfirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btConfirmar.FlatStyle = FlatStyle.Flat;
            btConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btConfirmar.Location = new Point(342, 321);
            btConfirmar.Margin = new Padding(3, 2, 3, 2);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(124, 32);
            btConfirmar.TabIndex = 38;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 110);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(785, 207);
            dataGridView1.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPesquisar);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 78);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.BackColor = SystemColors.ButtonHighlight;
            textBoxPesquisar.Location = new Point(139, 41);
            textBoxPesquisar.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(222, 23);
            textBoxPesquisar.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.CadetBlue;
            button4.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(10, 37);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(123, 30);
            button4.TabIndex = 7;
            button4.Text = "Pesquisar";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(6, -2);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 1;
            label1.Text = "Defina o tipo de pesquisa:";
            // 
            // SelecionarAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 379);
            ControlBox = false;
            Controls.Add(btConfirmar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "SelecionarAgendamento";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SelecionarAgendamento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btConfirmar;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBoxPesquisar;
        private Button button4;
        private Label label1;
    }
}