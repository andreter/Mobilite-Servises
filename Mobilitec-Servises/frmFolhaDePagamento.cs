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
    public partial class frmFolhaDePagamento : Form
    {
        public frmFolhaDePagamento()
        {
            InitializeComponent();
        }

        double Sal = 0;
        private void txtSal_TextChanged(object sender, EventArgs e)
        {

            txtSalFolha.Text = txtSal.Text;
            if (txtSalFolha.Text != "")
            {
                Sal = Convert.ToDouble(txtSalFolha.Text);
            }
            // Imposto

            if (Sal >= 1903.99 && Sal <= 2826.65)
            {
                imposto = Sal * 0.075;
            }
            else if (Sal >= 2826.66 && Sal <= 3751.05)
            {
                imposto = Sal * 0.15;
            }
            else if (Sal >= 3751.06 && Sal <= 4664.68)
            {
                imposto = Sal * 0.225;
            }
            else if (Sal > 4664.68)
            {
                imposto = Sal * 0.275;
            }
            else
            {
                imposto = 0;
            }

            txtImposto.Text = imposto.ToString();



        }
        int c = 1;
        private void ckbPlano_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSal.Text != "")
            {
                Sal = Convert.ToDouble(txtSalFolha.Text);
            }
            if (ckbPlano.Checked && c == 1)

            {
                Sal += -50;

                txtSalFolha.Text = Sal.ToString();
                c--;

            }
            else if (ckbPlano.Checked == false && c == 0)
            {

                Sal += +50;

                txtSalFolha.Text = Sal.ToString();
                c++;
            }

        }
        int cont = 0;

        private void cbbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            String club = cbbClub.Text;
            //Sal = Convert.ToDouble(txtSalFolha.Text);
            double guardaSal = 0;



            switch (club)
            {

                case "Clube A":
                    if (cont == 1) { guardaSal += +100; cont = 0; } else if (cont == 2) { guardaSal += +50; cont = 0; } else if (cont == 3) { guardaSal += +20; cont = 0; }

                    if (cont == 0)
                    {
                        guardaSal = Sal;
                        guardaSal = guardaSal - 100;
                        Sal = guardaSal;

                        txtSalFolha.Text = guardaSal.ToString();

                        cont++;

                    }
                    break;

                case "Clube B":
                    if (cont == 1) { guardaSal += +100; cont = 0; } else if (cont == 2) { guardaSal += +50; cont = 0; } else if (cont == 3) { guardaSal += +20; cont = 0; }

                    if (cont == 0)
                    {
                        guardaSal = Sal;
                        guardaSal = guardaSal - 50;
                        Sal = guardaSal;

                        txtSalFolha.Text = guardaSal.ToString();

                        cont += +2;

                    }
                    break;

                case "Clube C":
                    if (cont == 1) { guardaSal += +100; cont = 0; } else if (cont == 2) { guardaSal += +50; cont = 0; } else if (cont == 3) { guardaSal += +20; cont = 0; }

                    if (cont == 0)
                    {
                        guardaSal = Sal;
                        guardaSal = guardaSal - 20;
                        Sal = guardaSal;

                        txtSalFolha.Text = guardaSal.ToString();

                        cont += +3;

                    }
                    break;

                case "":
                        txtSalFolha.Text = guardaSal.ToString();
                    break;





            }
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtSal.Text = "";
            txtSalFolha.Text = "";
            ckbPlano.Checked = false;
            cbbClub.Text = "";
            Sal = 0;
            txtImposto.Text = "";
            txtSalFolha.Text = "";
            con = 0;
            txtSalLiq.Text = "";

        }
        double imposto;
        private void txtImposto_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int con = 0;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Calculo do liquido

            double guardaSal;

            if (txtSal.Text != "" && con == 0)
            {
                guardaSal = Sal - imposto;
                txtSalLiq.Text = guardaSal.ToString();
                //con++;
            }
            else
            {
                MessageBox.Show("Coloque o valor do salário");
            }
        }
    }
}
