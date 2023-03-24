using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilitec_Servises
{
    public partial class frmEstruturadeRepeticao : Form
    {
        public frmEstruturadeRepeticao()
        {
            InitializeComponent();
        }

        int cont, rep, valor;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtContador.Clear();
            txtRepeticoes.Clear();
            txtSoma.Clear();
            txtValor.Clear();
            lstbSomatoria.Items.Clear();
            cbbSomatoria.Items.Clear();
            cbbSomatoria.Text="";
            txtContador.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmEstruturadeRepeticao_Load(object sender, EventArgs e)
        {

        }

        double soma;

        private void btnExecultar_Click(object sender, EventArgs e)
        {if (txtContador.Text != " " && txtRepeticoes.Text != "" && txtValor.Text != "" && txtSoma.Text != "")
            {
            rep = Convert.ToInt32(txtRepeticoes.Text);
            valor = Convert.ToInt32(txtValor.Text);
            soma =Convert.ToDouble(txtSoma.Text);
            lstbSomatoria.Items.Clear();
            cbbSomatoria.Items.Clear();

                for (cont = Convert.ToInt32(txtContador.Text); cont < rep; cont++)
                {
                    lstbSomatoria.Items.Add(soma);
                    cbbSomatoria.Items.Add(soma);
                    soma = soma + valor;
                }
            }
            else
            {
                MessageBox.Show("Coloque todos os valores antes de iniciar");
            }
        }   
    }
}
