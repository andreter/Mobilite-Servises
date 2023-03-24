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
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmSoma_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            
            int valor;
            char sexo;
            string nome;
            bool acesso;

         
            valor = 5;
            sexo = 'F';
            nome = "André";
            acesso = true;


            double num1, num2, resp;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 + num2;

            lblResposta.Text = resp.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblResposta.Text = "";
            txtNum1.Focus();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja sair?","Mensagem do sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 - num2;

            lblResposta.Text = resp.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 / num2;

            lblResposta.Text = resp.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 * num2;

            lblResposta.Text = resp.ToString();
        }
    }
}
