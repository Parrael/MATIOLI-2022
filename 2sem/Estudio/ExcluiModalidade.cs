using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class frmExcluiModalidade : Form
    {
        public frmExcluiModalidade()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Fazer oq estiver selecionado no ComboBox ser excluido, mandando para modalidade.excluirModalidade
            Modalidade modalidade = new Modalidade(cbDescricao.Text);
            if (modalidade.excluirModalidade())
                MessageBox.Show("Deu certo fi");
            else
                MessageBox.Show("Deu errado fi");

            cbDescricao.Items.Clear();
            cbDescricao.Text = "";
            MySqlDataReader resultado = modalidade.consultarTodasModalidade();
            while (resultado.Read())
            {
                cbDescricao.Items.Add(resultado["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void frmExcluiModalidade_Load(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade();
            MySqlDataReader resultado = modalidade.consultarTodasModalidade();

            while (resultado.Read())
            {
                cbDescricao.Items.Add(resultado["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        }
    }
}
