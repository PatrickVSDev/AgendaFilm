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
            button2 = new Button();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            label2 = new Label();
            radioTodos = new RadioButton();
            radioId = new RadioButton();
            label1 = new Label();
            radioNome = new RadioButton();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1038, 561);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(869, 522);
            button2.Name = "button2";
            button2.Size = new Size(119, 33);
            button2.TabIndex = 3;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(948, 366);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(radioTodos);
            groupBox3.Controls.Add(radioId);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(radioNome);
            groupBox3.Location = new Point(40, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(948, 92);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Paint += groupBox3_Paint;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSeaGreen;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 9);
            label2.Name = "label2";
            label2.Size = new Size(202, 30);
            label2.TabIndex = 32;
            label2.Text = "Ordens De Serviços";
            label2.Click += label2_Click;
            label2.Paint += label2_Paint;
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.FlatAppearance.CheckedBackColor = Color.Navy;
            radioTodos.FlatAppearance.MouseDownBackColor = Color.Cyan;
            radioTodos.FlatAppearance.MouseOverBackColor = Color.Cyan;
            radioTodos.Location = new Point(373, 63);
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
            radioId.Location = new Point(262, 63);
            radioId.Margin = new Padding(2);
            radioId.Name = "radioId";
            radioId.Size = new Size(106, 19);
            radioId.TabIndex = 9;
            radioId.TabStop = true;
            radioId.Text = "Em andamento";
            radioId.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(5, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 7;
            label1.Text = "Defina o tipo de pesquisa:";
            label1.Click += label1_Click;
            // 
            // radioNome
            // 
            radioNome.AutoSize = true;
            radioNome.FlatAppearance.CheckedBackColor = Color.Navy;
            radioNome.FlatAppearance.MouseDownBackColor = Color.Cyan;
            radioNome.FlatAppearance.MouseOverBackColor = Color.Cyan;
            radioNome.ForeColor = SystemColors.ActiveCaptionText;
            radioNome.Location = new Point(195, 63);
            radioNome.Margin = new Padding(2);
            radioNome.Name = "radioNome";
            radioNome.Size = new Size(63, 19);
            radioNome.TabIndex = 8;
            radioNome.TabStop = true;
            radioNome.Text = "A Fazer";
            radioNome.UseVisualStyleBackColor = true;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private RadioButton radioNome;
        private RadioButton radioId;
        private RadioButton radioTodos;
        private GroupBox groupBox3;
        private Label label2;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
    }
}