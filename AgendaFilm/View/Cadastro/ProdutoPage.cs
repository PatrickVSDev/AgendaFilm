﻿using AgendaFilm.View.Cadastro.Cadastrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaFilm.View
{
    public partial class ProdutoPage : Form
    {
        public ProdutoPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CadastroProdutoPage novoFormulario = new CadastroProdutoPage(); ;
            novoFormulario.ShowDialog();
        }
    }
}
