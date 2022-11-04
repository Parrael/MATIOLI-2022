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
            Modalidade modalidade = new Modalidade();
            modalidade.excluirModalidade();
        }
    }
}
