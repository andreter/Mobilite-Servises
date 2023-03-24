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
    public partial class frmCalculadoraSimples : Form
    {
        public frmCalculadoraSimples()
        {
            InitializeComponent();
        }

        private void frmCalculadoraSimples_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (txtBox1.Text == "" || txtBox2.Text == "")
            {
                MessageBox.Show("Insira os dois valores necessario", "mensagem do Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);

            }
            else
            {
                num1 = Convert.ToDouble(txtBox1.Text);
                num2 = Convert.ToDouble(txtBox2.Text);

                if (rbtAdic.Checked == false && rbtMult.Checked == false && rbtDiv.Checked == false && rbtSub.Checked == false)
                {
                    MessageBox.Show("Escolha um operador", "mensagem do Sistema",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                }

                if (rbtAdic.Checked)
                {
                    Double res = num1 + num2;

                    lblResposta.Text = res.ToString();
                }

                if (rbtSub.Checked)
                {
                    Double res = num1 - num2;

                    lblResposta.Text = res.ToString();
                }

                if (rbtMult.Checked)
                {
                    Double res = num1 * num2;

                    lblResposta.Text = res.ToString();
                }

                if (rbtDiv.Checked)
                {
                    Double res = num1 / num2;

                    lblResposta.Text = res.ToString();
                }
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
            txtBox2.Text = "";

            rbtAdic.Checked = false;
            rbtSub.Checked = false;
            rbtMult.Checked = false;
            rbtDiv.Checked = false;

            lblResposta.Text = "";

            txtBox1.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
