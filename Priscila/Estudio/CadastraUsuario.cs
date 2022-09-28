using System;
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
    public partial class frmCadastraUsuario : Form
    {
        public frmCadastraUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if (cbTipo.SelectedIndex == 0)
                tipo = 1; //adm
            else if (cbTipo.SelectedIndex == 1)
                tipo = 2; //Restrito
            if (DAO_Conexao.cadUsuario(txtUsuario.Text, txtSenha.Text, tipo))
                MessageBox.Show("Cadastro realizado com sucesso");
            else
                MessageBox.Show("Erro de cadastro");
        }
    }
}
