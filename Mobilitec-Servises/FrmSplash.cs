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
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (pgbLoading.Value < 100)
            {
                pgbLoading.Value = pgbLoading.Value + 10;
                lblPorcentagem.Text = pgbLoading.Value.ToString() + "%";
                lblLoading.Visible = false;
            }
            else
            {
                FrmLogin abrir = new FrmLogin();
                abrir.Show();
                this.Hide();
                tmrSplash.Enabled = false;

            }

        }
    }
}
