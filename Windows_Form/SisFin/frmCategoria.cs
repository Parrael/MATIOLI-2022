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

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            txtNome.Text = "Combustível";
            txtDescricao.Text = "Gasto de combustível";
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = true;

            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnAlterar.Visible = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = true;
            btnNovo.Visible = true;

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

        private void preencheCampos()
        {
            txtNome.Text = dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescricao.Text = dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[2].Value.ToString();

            if (Convert.ToInt16(dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[3].Value.ToString()) == 1)
                rdReceita.Checked = true;
            else
                rdDespesa.Checked = true;

            if (Convert.ToInt16(dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[4].Value.ToString()) == 1)
                chkStatus.Checked = true;
            else
                chkStatus.Checked = false;
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
            grpCategoria.Enabled = true;
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = true;
            txtNome.Focus();
            dgCategoria.Enabled = false;
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
            txtNome.Enabled = false;
            txtNome.Focus();
            btnAlterar.Enabled = false; 
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            dgCategoria.Enabled = false;
            Insercao = false;
            Edicao = true;
        }

        private void salvarCadastro(object sender, EventArgs e)
        {
            if (Insercao)
            {
                var nome = txtNome.Text.Trim();
                var descr = txtDescricao.Text.Trim();
                var tipo = rdReceita.Checked ? 1 : 2;
                var status = chkStatus.Checked ? 1 : 0;
                categoria.AddToList(3, nome, descr, tipo, status);
            }

            if (Edicao)
            {
                Categoria ct = lstCategoria.Find(item => item.Nome == txtNome.Text.Trim());
                if (ct != null)
                {
                    ct.Descricao = txtDescricao.Text.Trim();
                    ct.Tipo = rdReceita.Checked ? 1 : 2;
                    ct.Status = chkStatus.Checked ? 1 : 0;
                }
            }

            carregaGridCategoria();

            MessageBox.Show("Registro gravado com sucesso!", "Aviso do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            btnNovo.Enabled = true;
            btnNovo.Focus();
            txtNome.Enabled = true;
            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            dgCategoria.Enabled = true;

            Insercao = false;
            Edicao = false;

        }

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
                btnNovo.Focus();
                dgCategoria.Enabled = true;
                Insercao = false;
                Edicao = false;
                preencheCampos();
            }
        }

        private void exclCadastro(object sender, EventArgs e)
        {

            DialogResult resp;
            resp = MessageBox.Show("Deseja excluir cadastro?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                dgCategoria.Rows.RemoveAt(dgCategoria.CurrentRow.Index);
                MessageBox.Show("Registro excluído com sucesso!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                btnNovo.Focus();
            }


        }
        private void dgCategoria_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategoria.RowCount > 0)
            {
                txtNome.Text = dgCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescricao.Text = dgCategoria.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Convert.ToInt16(dgCategoria.Rows[e.RowIndex].Cells[3].Value.ToString()) == 1)
                    rdReceita.Checked = true;
                else
                    rdDespesa.Checked = true;

                if (Convert.ToInt16(dgCategoria.Rows[e.RowIndex].Cells[4].Value.ToString()) == 1)
                    chkStatus.Checked = true;
                else
                    chkStatus.Checked = false;
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



