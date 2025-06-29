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
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            groupBox3 = new GroupBox();
            btnBuscar = new Button();
            label3 = new Label();
            dtInicio = new DateTimePicker();
            label2 = new Label();
            rbFinalizado = new RadioButton();
            rbEmAndamento = new RadioButton();
            label1 = new Label();
            rbAFazer = new RadioButton();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dtInicio);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(rbFinalizado);
            groupBox3.Controls.Add(rbEmAndamento);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(rbAFazer);
            groupBox3.Location = new Point(40, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(948, 92);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Paint += groupBox3_Paint;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.CadetBlue;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.Location = new Point(652, 56);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 33);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "Pesquisar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(472, 61);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 36;
            label3.Text = "Data:";
            label3.Click += label3_Click;
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(522, 61);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(114, 23);
            dtInicio.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSeaGreen;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 2);
            label2.Name = "label2";
            label2.Size = new Size(202, 30);
            label2.TabIndex = 32;
            label2.Text = "Ordens De Serviços";
            label2.Click += label2_Click;
            label2.Paint += label2_Paint;
            // 
            // rbFinalizado
            // 
            rbFinalizado.AutoSize = true;
            rbFinalizado.FlatAppearance.CheckedBackColor = Color.Navy;
            rbFinalizado.FlatAppearance.MouseDownBackColor = Color.Cyan;
            rbFinalizado.FlatAppearance.MouseOverBackColor = Color.Cyan;
            rbFinalizado.Location = new Point(386, 62);
            rbFinalizado.Margin = new Padding(3, 2, 3, 2);
            rbFinalizado.Name = "rbFinalizado";
            rbFinalizado.Size = new Size(78, 19);
            rbFinalizado.TabIndex = 31;
            rbFinalizado.TabStop = true;
            rbFinalizado.Text = "Finalizado";
            rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // rbEmAndamento
            // 
            rbEmAndamento.AutoSize = true;
            rbEmAndamento.FlatAppearance.BorderColor = Color.Black;
            rbEmAndamento.FlatAppearance.CheckedBackColor = Color.Navy;
            rbEmAndamento.FlatAppearance.MouseDownBackColor = Color.Cyan;
            rbEmAndamento.FlatAppearance.MouseOverBackColor = Color.Cyan;
            rbEmAndamento.Location = new Point(275, 62);
            rbEmAndamento.Margin = new Padding(2);
            rbEmAndamento.Name = "rbEmAndamento";
            rbEmAndamento.Size = new Size(106, 19);
            rbEmAndamento.TabIndex = 9;
            rbEmAndamento.TabStop = true;
            rbEmAndamento.Text = "Em andamento";
            rbEmAndamento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(18, 61);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 7;
            label1.Text = "Defina o tipo de pesquisa:";
            label1.Click += label1_Click;
            // 
            // rbAFazer
            // 
            rbAFazer.AutoSize = true;
            rbAFazer.FlatAppearance.CheckedBackColor = Color.Navy;
            rbAFazer.FlatAppearance.MouseDownBackColor = Color.Cyan;
            rbAFazer.FlatAppearance.MouseOverBackColor = Color.Cyan;
            rbAFazer.ForeColor = SystemColors.ActiveCaptionText;
            rbAFazer.Location = new Point(208, 62);
            rbAFazer.Margin = new Padding(2);
            rbAFazer.Name = "rbAFazer";
            rbAFazer.Size = new Size(63, 19);
            rbAFazer.TabIndex = 8;
            rbAFazer.TabStop = true;
            rbAFazer.Text = "A Fazer";
            rbAFazer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(948, 366);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(853, 522);
            button2.Name = "button2";
            button2.Size = new Size(119, 33);
            button2.TabIndex = 3;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            Load += FinalizarOrdemDeServiço_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private GroupBox groupBox3;
        private Button btnBuscar;
        private Label label3;
        private DateTimePicker dtInicio;
        private Label label2;
        private RadioButton rbFinalizado;
        private RadioButton rbEmAndamento;
        private Label label1;
        private RadioButton rbAFazer;
        private DataGridView dataGridView1;
        private Button button2;
        private GroupBox groupBox1;
    }
}