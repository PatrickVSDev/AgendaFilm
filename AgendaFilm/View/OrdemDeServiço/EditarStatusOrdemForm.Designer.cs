namespace AgendaFilm.View.OrdemDeServiço
{
    partial class EditarStatusOrdemForm
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
            comboBoxStatus = new ComboBox();
            btnConfirmar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(125, 91);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.CadetBlue;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmar.Location = new Point(125, 137);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(121, 33);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(43, 40);
            label1.Name = "label1";
            label1.Size = new Size(283, 37);
            label1.TabIndex = 2;
            label1.Text = "Defina o Status atual";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // EditarStatusOrdemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 215);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(comboBoxStatus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarStatusOrdemForm";
            Text = "Form1";
            Load += EditarStatusOrdemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxStatus;
        private Button btnConfirmar;
        private Label label1;
    }
}