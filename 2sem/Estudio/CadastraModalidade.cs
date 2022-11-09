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
    public partial class frmCadastraModalidade : Form
    {
        public frmCadastraModalidade()
        {
            InitializeComponent();
        }


        private void btnCadastra_Click(object sender, EventArgs e)
        {
            /*String descricao = txtDescricao.Text;
            double preco = Convert.ToDouble(txtPreco.Text);
            int qtdAluno = Convert.ToInt32(txtQtdAluno.Text);
            int qtdAula = Convert.ToInt32(txtQtdAula.Text); 
            Modalidade modalidade = new Modalidade(descricao, preco, qtdAluno, qtdAula);*/
            Modalidade modalidade = new Modalidade(txtDescricao.Text, double.Parse(txtPreco.Text), int.Parse(txtQtdAluno.Text), int.Parse(txtQtdAula.Text));
            if (modalidade.cadastrarModalidade())
                MessageBox.Show("Cadastro realizado com sucesso!");
            else
                MessageBox.Show("Falha no cadastro!");
           // DAO_Conexao.con.Close();
        }
    }
}
