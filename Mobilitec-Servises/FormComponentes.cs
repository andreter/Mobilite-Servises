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
    public partial class FormComponentes : Form
    {
        public FormComponentes()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            //Close();
            //this.Close();
            Application.Exit();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (rbtMasculino.Checked)
            {
                MessageBox.Show("Selecioniou masculino");
            }
            if (rbtFeminino.Checked)
            {
                MessageBox.Show("Selecioniou feminino");
            }

            if (ckbLivros.Checked)
            {
                MessageBox.Show("Selecioniou Livros");
            }

            if (ckbAcademia.Checked)
            {
                MessageBox.Show("Selecioniou Academia");
            }

            if (ckbCultura.Checked)
            {
                MessageBox.Show("Selecioniou Cultura");
            }

            if (ckbEsportes.Checked)
            {
                MessageBox.Show("Selecioniou Esportes");
            }
        }

        private void cbbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {   // Mostrando a posição
            // int valor = cbbEstados.SelectedIndex;

            String valor = cbbEstados.SelectedItem.ToString();

            MessageBox.Show("Item " + valor +" selecionado ");
        }

        private void ltbPreferencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int valor = ltbPreferencias.SelectedIndex;
            String valor = ltbPreferencias.SelectedItem.ToString();

            MessageBox.Show("Item "+valor+" Selecionado");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbbEstados.Items.Clear();
            ltbPreferencias.Items.Clear();
            cbbEstados.Text = "";

            rbtFeminino.Checked = false;
            rbtMasculino.Checked = false;

            ckbAcademia.Checked = false;
            ckbCultura.Checked = false;
            ckbEsportes.Checked = false;
            ckbLivros.Checked = false;
        }
    }
}
