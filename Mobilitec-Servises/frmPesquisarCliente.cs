using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// importar classe de conexao
using MySql.Data.MySqlClient;

namespace Mobilitec_Servises
{
    public partial class frmPesquisarCliente : Form
    {
        public frmPesquisarCliente()
        {
            InitializeComponent();
            txtDesc.Focus();


        }

        //pesquisa por codigo
        public void pesquisarPorCodigo(int codigoCliente)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbClientes where codCli =" + codigoCliente + ";";
            comm.CommandType = CommandType.Text;

            //comm.Parameters.Clear();
            //comm.Parameters.Add("@codCli",MySqlDbType.Int32,11).Value = codigoCliente ;

            comm.Connection = Connection.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbResul.Items.Add(DR.GetString(1));

            Connection.fecharConexao();

        }

        //pesquisa por nome

        public void pesquisarPorNome(String nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbClientes where nome like '%" + nome + "%'";
            comm.CommandType = CommandType.Text;

            comm.Connection = Connection.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                ltbResul.Items.Add(DR.GetString(1));
            }

        }



        public void limpar()
        {
            
            rbtCod.Checked = false;
            rbtNome.Checked = false;
            txtDesc.Clear();
            txtDesc.Enabled = false;
            ltbResul.Items.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
            txtDesc.Focus();
        }

        public void Checagem()
        {
            if (rbtCod.Checked == true || rbtNome.Checked == true)
            {
                txtDesc.Enabled = true;
                txtDesc.Focus();
            }
        }

        private void rbtCod_CheckedChanged(object sender, EventArgs e)
        {
            Checagem();
        }

        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            Checagem();
        }

        public void pesquisar()
        {
            if (rbtCod.Checked == false && rbtNome.Checked == false)
            {
                MessageBox.Show("Digite o tipo de valor a ser pesquisado", "Mensagem do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDesc.Text.Equals(""))
            {
                MessageBox.Show("Digite o valor a ser pesquisado", "Mensagem do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbtCod.Checked == true)
                {
                    ltbResul.Items.Clear();
                    pesquisarPorCodigo(Convert.ToInt32(txtDesc.Text));
                }
                else if (rbtNome.Checked == true)
                {
                    ltbResul.Items.Clear();
                    pesquisarPorNome(txtDesc.Text);
                }
            }

            txtDesc.Focus();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void ltbResul_SelectedIndexChanged(object sender, EventArgs e)
        {

            string resp = ltbResul.SelectedItem.ToString();

            frmGerenciarClientes nome = new frmGerenciarClientes(resp);
            nome.Show();
            this.Hide();

        }

        private void txtDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisar();
            }
        }
    }
}
