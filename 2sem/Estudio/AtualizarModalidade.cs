﻿using MySql.Data.MySqlClient;
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
    public partial class frmAtualizarModalidade : Form
    {
        Modalidade modalidade = new Modalidade();
        public frmAtualizarModalidade(String opcao)
        {
            InitializeComponent();
            if (opcao == "c")
            {
                btnAtualiza.Enabled = false;
                txtPreco.Enabled = false;
                txtQtdAluno.Enabled = false;
                txtQtdAula.Enabled = false;
            }else{
                btnAtualiza.Enabled = true;
                txtPreco.Enabled = true;
                txtQtdAluno.Enabled = true;
                txtQtdAula.Enabled = true;
            }
            MySqlDataReader resultado = modalidade.consultarTodasModalidade();
            
            while (resultado.Read())
            {
                cbDescricao.Items.Add(resultado["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
            

        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(cbDescricao.Text, double.Parse(txtPreco.Text), int.Parse(txtQtdAluno.Text), int.Parse(txtQtdAula.Text));
            if (modalidade.atualizarModalidade())
                MessageBox.Show("Atualização bem sucedida!");
            else
                MessageBox.Show("Não foi possível atualizar!");
            cbDescricao.Items.Clear();
            cbDescricao.Text = "";
            txtPreco.Text = "";
            txtQtdAluno.Text = "";
            txtQtdAula.Text = "";
            MySqlDataReader resultado = modalidade.consultarTodasModalidade();
            while (resultado.Read())
            {
                cbDescricao.Items.Add(resultado["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void frmAtualizarModalidade_Load(object sender, EventArgs e)
        {

        }

        private void cbDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(cbDescricao.Text);
            MySqlDataReader resultado = modalidade.consultarModalidade();
            while (resultado.Read())
            {
                txtPreco.Text = resultado["preco"].ToString();
                txtQtdAluno.Text = resultado["qtdAlunos"].ToString();
                txtQtdAula.Text = resultado["qtdAulas"].ToString();
            }
            DAO_Conexao.con.Close();
        }
    }
}
