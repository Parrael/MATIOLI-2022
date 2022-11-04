﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class frmCadastraModalidade : Form
    {
        public frmCadastraModalidade()
        {
            InitializeComponent();
        }

        private void frmCadastraModalidade_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(txtDescricao.Text, double.Parse(txtPreco.Text), int.Parse(txtQtdAluno.Text), int.Parse(txtQtdAula.Text));
            if (modalidade.cadastrarModalidade())
                MessageBox.Show("Cadastro realizado com sucesso!");
            else
                MessageBox.Show("Falha ao cadastrar modalidade!");

        }
    }
}
