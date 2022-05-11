using System;
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
        private Categoria categoria = new Categoria();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsCategoria;
    
        public frmCategoria()
        {
            InitializeComponent();
            lstCategoria = categoria.GeraCategorias();
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
            txtDescricao.Text = "Consumo de combustível";
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = true;

            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = true;
            Insercao = false;
            Edicao = false;

            dgCategoria.ColumnCount = 5;
            dgCategoria.AutoGenerateColumns = false;
            dgCategoria.Columns[0].Width = 50;
            dgCategoria.Columns[0].HeaderText = "ID";
            dgCategoria.Columns[0].DataPropertyName = "Id";
            dgCategoria.Columns[0].Visible = false;
            dgCategoria.Columns[1].Width = 200;
            dgCategoria.Columns[1].HeaderText = "NOME";
            dgCategoria.Columns[1].DataPropertyName = "Nome";
            dgCategoria.Columns[2].Width = 400;
            dgCategoria.Columns[2].HeaderText = "DESCRIÇÃO";
            dgCategoria.Columns[2].DataPropertyName = "Descricao";
            dgCategoria.Columns[3].Width = 50;
            dgCategoria.Columns[3].HeaderText = "TIPO";
            dgCategoria.Columns[3].DataPropertyName = "Tipo";
            dgCategoria.Columns[4].Width = 50;
            dgCategoria.Columns[4].HeaderText = "STATUS";
            dgCategoria.Columns[4].DataPropertyName = "Status";

            dgCategoria.AllowUserToAddRows = false;
            dgCategoria.AllowUserToDeleteRows = false;
            dgCategoria.MultiSelect = false;
            dgCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridCategoria();
        }

        public void carregaGridCategoria()
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            //dgCategoria.Rows.Clear()
            dgCategoria.DataSource = bsCategoria;
            dgCategoria.Refresh();
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
            limparCampos();
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = true;
            grpCategoria.Enabled = true;
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            Insercao = true;
            Edicao = false;
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
            Insercao = false;
            Edicao = true;
        }

        private void salvarCadastro(object sender, EventArgs e)
        {
            MessageBox.Show("Registro gravado com sucesso!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                grpCategoria.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Visible = false;
                btnSalvar.Visible = false;
                btnExcluir.Visible = true;
                btnNovo.Enabled = true;
                Insercao = false;
                Edicao = false;
                btnNovo.Focus();
            
        }

        //Precisa ver oq colocar nesse cancelar, pq o ideal seria ele descartar as mudanças não salvas
        private void cancCadastro(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja descartar mudanças?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
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

        private void exclCadastro(object sender, EventArgs e)
        {

            DialogResult resp;
            resp = MessageBox.Show("Deseja excluir cadastro?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                MessageBox.Show("Registro excluído com sucesso!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();

                btnNovo.Focus();
            }
        }
        private void fechaForm(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Não é possível sair sem salvar os dados!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}



