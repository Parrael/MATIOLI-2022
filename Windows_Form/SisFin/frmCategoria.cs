﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFin
{
    public partial class frmCategoria : Form
    {
        private bool Insercao = false;
        private bool Edicao = false;
        
        
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            txtNome.Text = "Combustível";
            txtDescricao.Text = "Comsumo de cobustível";
            rdDespesa.Checked = true;
            chkStatus.Checked = true;

        }
        public void limparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = false;
        }

        private void novoRegistro(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            limparCampos();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            Insercao = true;
            Edicao = true;
        }

        private void altCadastro(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            Insercao = true;
            Edicao = true;
        }

        private void salvarCadastro(object sender, EventArgs e)
        {
            MessageBox.Show("Registro gravado com sucesso!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                grpCategoria.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Visible = false;
                btnSalvar.Visible = false;
                btnExcluir.Visible = true;
                btnNovo.Enabled = true;
                Insercao = false;
                Edicao = false;
            }
            
        }

        private void cancCadastro(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja descartar mudanças?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {

            }
        }
    }
}
