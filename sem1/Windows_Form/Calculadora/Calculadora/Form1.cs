using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        private double n1;
        private double n2;
        private string operacao;
        private double result;
        private Boolean pressionouIgual;

            //METODOS
        private void LimparCampos()
        {
            n1 = 0;
            n2 = 0;
            operacao = String.Empty;
            result = 0;
            pressionouIgual = false;
            txtDisplay.Clear();
        }

        private void adicionarOperacao(string caractere)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                n1 = Convert.ToDouble(txtDisplay.Text.Trim());
                txtDisplay.Clear();
                operacao = caractere;
            }
        }

        private void Calcular()
        {
            switch(operacao)
            {
                case "/":
                    if (n1 == 0)
                    {
                        MessageBox.Show("Impossível divisão por zero!","Aviso de sistema",MessageBoxButtons.OK);
                        break;
                    }
                    result = n1 / n2;
                    break;

                case "+":
                    result = n1 + n2;
                    break;

                case "-":
                    result = n1 - n2;
                    break;

                case "*":
                    result = n1 * n2;
                    break;

                case "x^y":

                    result = Math.Pow(n1, n2);
                    break;
                    
            }
            txtDisplay.Text = result.ToString();
        }

            //CONSTRUTORES
        public frmCalculadora()
        {
            InitializeComponent();
        }



        void adicionarDigito(string digito)
        {
            if (txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = digito;
            } else
            {
                txtDisplay.Text += digito;
            }
        }

        //AÇÕES BOTÕES
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            adicionarDigito ("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            adicionarDigito("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            adicionarDigito("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            adicionarDigito("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            adicionarDigito("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            adicionarDigito("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            adicionarDigito("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            adicionarDigito("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            adicionarDigito("9");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            adicionarOperacao("/");
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            adicionarOperacao("*");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            adicionarOperacao("-");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            adicionarOperacao("+");
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                n2 = Convert.ToDouble(txtDisplay.Text.Trim());
                Calcular();
                pressionouIgual = true;
            }

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (pressionouIgual)
            {
                LimparCampos();
            }
            if (txtDisplay.Text.Trim().Equals(String.Empty))
            {
                txtDisplay.Text += "0,";
            }
            if (txtDisplay.Text.Trim().Contains(",")) return;
            txtDisplay.Text += ",";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEleva_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                n1 = Convert.ToDouble(txtDisplay.Text.Trim());
                result = n1 * n1;
                txtDisplay.Text = result.ToString();
                pressionouIgual = true;
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            adicionarOperacao("x^y");
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                n1 = Convert.ToDouble(txtDisplay.Text.Trim());
                result = Math.Sqrt(n1);
                txtDisplay.Text = result.ToString();
                pressionouIgual = true;
            }
        }

        private void btnFracao_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                n1 = Convert.ToDouble(txtDisplay.Text.Trim());
                result = 1 / n1;
                txtDisplay.Text = result.ToString();
                pressionouIgual = true;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (pressionouIgual)
            LimparCampos();
            else
            txtDisplay.Clear();
        }

        private void btnInversao_Click(object sender, EventArgs e)
        {                   
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                txtDisplay.Text = Convert.ToString(-1 * Convert.ToDouble(txtDisplay.Text));
                /*
                double var; 
                var = Convert.ToDouble(txtDisplay.Text.Trim());
                result = -1*var;
                txtDisplay.Text = Convert.ToString(result);
                pressionouIgual = true;
                */
                
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.TextLength > 0)
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
