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
            dateTimePickerFiltro = new DateTimePicker();
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
            btConfirmar.Location = new Point(347, 336);
            btConfirmar.Margin = new Padding(3, 2, 3, 2);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(124, 32);
            btConfirmar.TabIndex = 2;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
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
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerFiltro);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 78);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTimePickerFiltro
            // 
            dateTimePickerFiltro.Location = new Point(6, 49);
            dateTimePickerFiltro.Name = "dateTimePickerFiltro";
            dateTimePickerFiltro.Size = new Size(244, 23);
            dateTimePickerFiltro.TabIndex = 1;
            dateTimePickerFiltro.ValueChanged += dateTimePickerFiltro_ValueChanged;
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
            label1.Click += label1_Click;
            // 
            // SelecionarAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
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
        private Label label1;
        private DateTimePicker dateTimePickerFiltro;
    }
}