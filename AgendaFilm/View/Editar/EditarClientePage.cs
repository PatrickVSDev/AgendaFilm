﻿using AgendaFilm.Controller;
using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AgendaFilm.Controller.Actions;
using static AgendaFilm.Utils.EstiloDataGridView;


namespace AgendaFilm.View.Editar
{
    public partial class EditarClientePage : Form
    {
        ClienteRepositorio repository = new ClienteRepositorio();
        public Cliente cliente { get; set; }
        Actions actions = new Actions();
        BindingList<Cliente> buscaClientes = new BindingList<Cliente>();
        BindingList<Cliente> clientes;
        private Button btnFechar;

        public event Action RefreshGrid;

        public EditarClientePage(Cliente cliente)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            BotaoFecharUtils.AplicarBotaoFechar(this);

            this.cliente = cliente;

            comboTipoCliente.Items.Clear();
            comboTipoCliente.Items.Add("FÍSICA");
            comboTipoCliente.Items.Add("JURÍDICA");

            string tipoFormatado = cliente.tipo_cliente?.Trim().ToUpper();
            comboTipoCliente.SelectedItem = comboTipoCliente.Items.Contains(tipoFormatado) ? tipoFormatado : null;

            textDocumento.Text = cliente.documento?.Trim();
            textNome.Text = cliente.nome?.Trim();
            textTelefone.Text = cliente.telefone?.Trim();
        }

        private void EditarClientePage_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string tipo = DocumentoUtils.RemoverAcentos(comboTipoCliente.Text.Trim().ToUpper());

            string documento = textDocumento.Text.Trim();
            documento = new string(documento.Where(char.IsDigit).ToArray());

            clientes = new BindingList<Cliente>(repository.GetAll());

            foreach (var c in clientes)
            {
                if (c.documento == documento && c.id != cliente.id)
                {
                    MessageBox.Show("Este CPF ou CNPJ já está cadastrado no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            bool documentoAlterado = documento != cliente.documento;
            bool documentoValido = true;

            if (documentoAlterado)
            {
                documentoValido = tipo == "FISICA"
                    ? DocumentoUtils.ValidarCPF(documento)
                    : DocumentoUtils.ValidarCNPJ(documento);

                if (!documentoValido)
                {
                    MessageBox.Show("Documento inválido. Verifique o CPF ou CNPJ informado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            this.cliente.tipo_cliente = tipo;
            this.cliente.documento = documento;
            this.cliente.nome = textNome.Text.Trim();
            this.cliente.telefone = textTelefone.Text.Trim();
            this.cliente.dataAlteracao = DateTime.Today;
            this.cliente.funcionario_fk = Global.funcionarioLogado;

            repository.UpdateCliente(cliente);

            RefreshGrid?.Invoke();
            this.Close();
        }


        private void textTelefone_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Color corBorda = Color.Black;
            int espessuraBorda = 3;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Size textSize = TextRenderer.MeasureText(box.Text, box.Font);
            Rectangle rect = new Rectangle(0, textSize.Height / 2, box.Width - 1, box.Height - textSize.Height / 2 - 1);

            e.Graphics.Clear(box.BackColor);

            using (Pen pen = new Pen(corBorda, espessuraBorda))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddRectangle(rect);
                e.Graphics.DrawPath(pen, path);
            }

            using (SolidBrush brush = new SolidBrush(box.ForeColor))
            {
                e.Graphics.DrawString(box.Text, box.Font, brush, 10, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Label label = sender as Label;

            Color corBorda = Color.Black;
            int espessuraBorda = 2;
            int raio = 8;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, label.Width - 1, label.Height - 1);

            using (Pen pen = new Pen(corBorda, espessuraBorda))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.Left, rect.Top, raio, raio, 180, 90);
                path.AddArc(rect.Right - raio, rect.Top, raio, raio, 270, 90);
                path.AddArc(rect.Right - raio, rect.Bottom - raio, raio, raio, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - raio, raio, raio, 90, 90);
                path.CloseFigure();

                e.Graphics.DrawPath(pen, path);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 4;
            Color borderColor = Color.Black;

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        private void textDocumento_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
