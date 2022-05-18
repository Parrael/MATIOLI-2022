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



            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            btnNovo.Enabled = true;
            Insercao = false;
            Edicao = false;

            carregaGridCategoria();
        }


            //if (Insercao){

            //  var nome = txtNome.Text.Trim();
            //var descr = txtDescricao.Text.Trim();
            //var tipo = txtReceita.Cheked ? 1 : 2;
            //var status = txtStatus.Cheked ? 1 : 2;
            //categoria.AddToList(3,nome,descr,tipo,status);
            //  }

            //if(Edicao){
            // Categoria ct = 1stCategoria.Find(ItemActivation => item.Nome == txtNome.Text.Trim());
            //if (ct ! = null){
            //
            //ct.Descricao = txtDescricao.Text.Trim();
            //ct.Tipo = rdReceita.Cheked ? 1 : 2;
            //ct.Status = chkStatus.Cheked ? 1 : 0;
            //}
            //


        
        private void carregaGridCategoria()
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            //dgCategoria.Rows.Clear();
            dgCategoria.DataSource = bsCategoria;
            dgCategoria.Refresh();
            txtNome.Enabled = true;
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
            Edicao = false;
            chkStatus.Checked = true;
            
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
           if (Insercao){

             var nome = txtNome.Text.Trim();
            var descr = txtDescricao.Text.Trim();
            var tipo = rdReceita.Checked ? 1 : 2;
            var status = chkStatus.Checked ? 1 : 2;
            categoria.AddTolist(3,nome,descr,tipo,status);
             }

            if(Edicao){
             Categoria ct = lstCategoria.Find(item => item.Nome == txtNome.Text.Trim());
            if (ct != null){
            
            ct.Descricao = txtDescricao.Text.Trim();
            ct.Tipo = rdReceita.Checked ? 1 : 2;
            ct.Status = chkStatus.Checked ? 1 : 0;
            }
            

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
                Insercao =true;
                Edicao = false; 
                btnNovo.Focus();
            }
        }

        private void exclCadastro(object sender, EventArgs e)
        {
            DialogResult resp;

            btnNovo.Focus();
            resp = MessageBox.Show("Deseja excluir cadastro?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                limparCampos();
            }
        }


        private void FecharForm(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Fique aqui", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
