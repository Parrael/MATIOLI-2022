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

    public partial class FrmConta : Form {

        private Conta conta = new Conta();
        private List<Conta> lstConta = new List<Conta>();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsConta;
        private BindingSource bsCategoria;
   
        public FrmConta()
        {
            InitializeComponent();
            lstConta = conta.GeraConta();
            lstCategoria = (new Categoria()).GeraCategorias();
        }

        private void FrmConta_Load(object sender, EventArgs e)
        {
            dgConta.ColumnCount = 4;
            dgConta.AutoGenerateColumns = false;
            dgConta.AllowUserToAddRows = false;
            dgConta.AllowUserToDeleteRows = false;
            dgConta.MultiSelect = false;
            dgConta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
            dgConta.Columns[0].Width = 50;
            dgConta.Columns[0].HeaderText = "ID";
            dgConta.Columns[0].DataPropertyName = "Id";
           // dgConta.Columns[0].Visible = false;
            dgConta.Columns[1].Width = 250;
            dgConta.Columns[1].HeaderText = "NOME";
            dgConta.Columns[1].DataPropertyName = "Nome";
            dgConta.Columns[2].Width = 400;
            dgConta.Columns[2].HeaderText = "DESCRIÇÃO";
            dgConta.Columns[2].DataPropertyName = "Descricao";
            dgConta.Columns[3].Width = 50;
            dgConta.Columns[3].Visible = false;
 
            dgConta.Columns[3].HeaderText = "STATUS";
            dgConta.Columns[3].DataPropertyName = "Status";

            carregaGridConta();
        }
        public void carregaGridConta()
        {
            bsConta = new BindingSource();
            bsConta.DataSource = lstConta;
            //dgConta.Rows.Clear()
            dgConta.DataSource = bsConta;
            dgConta.Refresh();
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void carregaComboCategoria(int id = 0)
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            cboCategoria.DataSource = bsCategoria;
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.SelectedItem = "id";
            if (id > 0)
            {
                foreach(var c in lstCategoria)
                {
                    if (c.Id == id)
                    {
                        int index = cboCategoria.FindString(c.Nome);
                        cboCategoria.SelectedIndex = id;
                    }
                }
            }
        }

    }

}
