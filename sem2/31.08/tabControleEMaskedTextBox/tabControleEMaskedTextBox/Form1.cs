using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabControleEMaskedTextBox
{
    public partial class Exemplo1 : Form
    {
        public Exemplo1()
        {
            InitializeComponent();
        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e) //Quando a pessoar der "Enter", ele desce para o campo de baixo (MTT PIKA)
        {
            if(e.KeyChar == 13)
            {
                if (txtEvento.Text != string.Empty)
                    mskData.Focus();
            }

        }

        private void mskData_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                try
                {
                    DateTime data = Convert.ToDateTime(mskData.Text);
                    listBox1.Items.Add(txtEvento.Text);
                    listBox2.Items.Add(mskData.Text);
                    txtEvento.Clear();
                    mskData.Clear();
                    txtEvento.Focus();
                }catch(Exception ex)
                {
                    MessageBox.Show("Data Inválida!");
                    mskData.Focus();
                }
            }
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
            {
                txtResult1.Text = (int.Parse(txtResult1.Text) + 1).ToString();
            } else if(listBox3.SelectedIndex == 1)
            {
                txtResult2.Text = (int.Parse(txtResult2.Text) + 1).ToString();
            } else if (listBox3.SelectedIndex == 2)
            {
                txtResult3.Text = (int.Parse(txtResult3.Text) + 1).ToString();
            } else
            {
                MessageBox.Show("Selecione um candidato");
            }
            listBox3.ClearSelected();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResult1.Text = "0";
            txtResult2.Text = "0";
            txtResult3.Text = "0";
        }

        private void Exemplo1_Load(object sender, EventArgs e)
        {
            txtEvento.Focus();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Selecione um evento!");
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Selecione um evento!");
            }
        }
    }
}
