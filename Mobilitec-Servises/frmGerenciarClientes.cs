using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Text.RegularExpressions;
// importar classe de conexao
using MySql.Data.MySqlClient;

namespace Mobilitec_Servises
{
    public partial class frmGerenciarClientes : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciarClientes()
        {
            InitializeComponent();
            desabilitar();
        }

        public frmGerenciarClientes(String nome)
        {
            InitializeComponent();
            desabilitar();

            txtNome.Text = nome;
            PesquisaPorNomeCliente(txtNome.Text);

            habilitar();

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcuir.Enabled = true;
        }

        private void frmGerenciarClientes_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        // Método para desabilitar campos

        public void desabilitar()
        {
            txtCod.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mkbCPF.Enabled = false;
            mkbTel.Enabled = false;
            cbbSexo.Enabled = false;
            txtEnd.Enabled = false;
            mkbCEP.Enabled = false;
            txtCid.Enabled = false;
            cbbEst.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcuir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
        }

        // Método para habilitar campos
        public void habilitar()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mkbCPF.Enabled = true;
            mkbTel.Enabled = true;
            cbbSexo.Enabled = true;
            txtEnd.Enabled = true;
            mkbCEP.Enabled = true;
            txtCid.Enabled = true;
            cbbEst.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;

            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal voltar = new FrmMenuPrincipal();
            voltar.Show();
            this.Hide();
        }

        public void limpar()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mkbCPF.Clear();
            mkbTel.Clear();
            cbbSexo.Text = "";
            txtEnd.Clear();
            mkbCEP.Clear();
            txtCid.Clear();
            cbbEst.Text = "";
            txtNumero.Clear();
            txtBairro.Clear();
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        // cadastrando cliente (fora do metodo mas dentro da classe)

        public void cadastrarCliente()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbClientes (nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado)values(@nome,@email,@cpf,@telefone,@sexo,@endereco,@numero,@cep,@bairro,@cidade,@estado);";

            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mkbCPF.Text;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = mkbTel.Text;
            comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = cbbSexo.Text;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEnd.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mkbCEP.Text;
            comm.Parameters.Add("@bairro",MySqlDbType.VarChar,100).Value=txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCid.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEst.Text;

            comm.Connection = Connection.obterConexao();
            int res = comm.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            Connection.fecharConexao();
 
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("")|| txtEmail.Text.Equals("") || mkbCPF.Text.Equals("   .   .   -  ")|| mkbTel.Text.Equals("(  )     -    ") || cbbSexo.Text.Equals("")|| txtEnd.Text.Equals("") ||txtNumero.Text.Equals("") || mkbCEP.Text.Equals("     -   ") ||txtBairro.Text.Equals("") ||txtCid.Text.Equals("") || cbbEst.Text.Equals("") )
            {
                MessageBox.Show("Preencha todos os dados","Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                cadastrarCliente();
                limpar();
                desabilitar();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarCliente abrir = new frmPesquisarCliente();
            abrir.ShowDialog();
            this.Hide();
        }

        // Método para alterar clientes
        public void alterarClientes(int codCli)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbClientes set nome = @nome, email=@email,cpf=@cpf,telefone=@telefone,sexo=@sexo,endereco=@endereco,numero=@numero,cep=@cep,bairro=@bairro,cidade=@cidade,estado=@estado where codCli = "+codCli+";";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mkbCPF.Text;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = mkbTel.Text;
            comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = cbbSexo.Text;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEnd.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mkbCEP.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCid.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEst.Text;

            comm.Connection = Connection.obterConexao();
            int res = comm.ExecuteNonQuery();

            MessageBox.Show("Registrado com sucesso");

            Connection.fecharConexao();
 
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarClientes(Convert.ToInt32(txtCod.Text));

            MessageBox.Show("Alterado com sucesso", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            desabilitar();
            limpar();
        }

        private void btnExcuir_Click(object sender, EventArgs e)
        {
         DialogResult resp = MessageBox.Show("Deseja Excluir", "Mensagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resp == DialogResult.Yes )
            {

                MessageBox.Show("Excuido com sucesso", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

                limpar();
                desabilitar();

            }
            else { }
        }

        public void buscaCEP (string numCEP)
        {
            WSCorreios.AtendeClienteClient ws =new WSCorreios.AtendeClienteClient();

            WSCorreios.enderecoERP endereco = ws.consultaCEP(numCEP);

            txtEnd.Text = endereco.end;
            txtCid.Text = endereco.cidade;
            txtBairro.Text = endereco.bairro;
            cbbEst.Text = endereco.uf;
        }
        private void btnCEP_Click(object sender, EventArgs e)
        {
            buscaCEP(mkbCEP.Text);
        }

        private void mkbCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mkbCEP.Text);
                txtNumero.Focus();
            }
        }

        //Pesquisa por nome

        public void PesquisaPorNomeCliente(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbClientes where nome ='"+nome+"';";
            comm.CommandType = CommandType.Text;

            comm.Connection = Connection.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCod.Text =Convert.ToString( DR.GetInt32(0));
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mkbCPF.Text = DR.GetString(3);
            mkbTel.Text = DR.GetString(4);
            cbbSexo.Text = DR.GetString(5);
            txtEnd.Text = DR.GetString(6);
            txtNumero.Text = DR.GetString(7);
            mkbCEP.Text = DR.GetString(8);
            txtBairro.Text = DR.GetString(9);
            txtCid.Text = DR.GetString(10);
            cbbEst.Text = DR.GetString(11);


        }
    }
}
