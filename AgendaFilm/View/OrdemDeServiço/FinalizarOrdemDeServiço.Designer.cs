namespace AgendaFilm.View.OrdemDeServiço
{
    partial class FinalizarOrdemDeServiço
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
            groupBox1 = new GroupBox();
            radioTodos = new RadioButton();
            radioId = new RadioButton();
            radioNome = new RadioButton();
            label1 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioTodos);
            groupBox1.Controls.Add(radioId);
            groupBox1.Controls.Add(radioNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1038, 561);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.FlatAppearance.CheckedBackColor = Color.Navy;
            radioTodos.FlatAppearance.MouseDownBackColor = Color.Cyan;
            radioTodos.FlatAppearance.MouseOverBackColor = Color.Cyan;
            radioTodos.Location = new Point(402, 71);
            radioTodos.Margin = new Padding(3, 2, 3, 2);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(77, 19);
            radioTodos.TabIndex = 31;
            radioTodos.TabStop = true;
            radioTodos.Text = "Finalizada";
            radioTodos.UseVisualStyleBackColor = true;
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.FlatAppearance.BorderColor = Color.Black;
            radioId.FlatAppearance.CheckedBackColor = Color.Navy;
            radioId.FlatAppearance.MouseDownBackColor = Color.Cyan;
            radioId.FlatAppearance.MouseOverBackColor = Color.Cyan;
            radioId.Location = new Point(291, 71);
            radioId.Margin = new Padding(2);
            radioId.Name = "radioId";
            radioId.Size = new Size(106, 19);
            radioId.TabIndex = 9;
            radioId.TabStop = true;
            radioId.Text = "Em andamento";
            radioId.UseVisualStyleBackColor = true;
            // 
            // radioNome
            // 
            radioNome.AutoSize = true;
            radioNome.FlatAppearance.CheckedBackColor = Color.Navy;
            radioNome.FlatAppearance.MouseDownBackColor = Color.Cyan;
            radioNome.FlatAppearance.MouseOverBackColor = Color.Cyan;
            radioNome.ForeColor = SystemColors.ActiveCaptionText;
            radioNome.Location = new Point(224, 71);
            radioNome.Margin = new Padding(2);
            radioNome.Name = "radioNome";
            radioNome.Size = new Size(63, 19);
            radioNome.TabIndex = 8;
            radioNome.TabStop = true;
            radioNome.Text = "A Fazer";
            radioNome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(34, 70);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 7;
            label1.Text = "Defina o tipo de pesquisa:";
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(743, 502);
            button2.Name = "button2";
            button2.Size = new Size(254, 42);
            button2.TabIndex = 3;
            button2.Text = "Finalizar Ordem de Serviço";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(963, 366);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(34, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(225, 36);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Paint += groupBox2_Paint;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 5);
            label2.Name = "label2";
            label2.Size = new Size(217, 29);
            label2.TabIndex = 6;
            label2.Text = "Ordem de serviços";
            label2.Click += label2_Click;
            // 
            // FinalizarOrdemDeServiço
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1062, 577);
            ControlBox = false;
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(218, 200);
            Name = "FinalizarOrdemDeServiço";
            StartPosition = FormStartPosition.Manual;
            Text = "FinalizarOrdemDeServiço";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private RadioButton radioNome;
        private RadioButton radioId;
        private RadioButton radioTodos;
        private GroupBox groupBox2;
    }
}