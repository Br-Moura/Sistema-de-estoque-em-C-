using BLL;
using DALL;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DESK
{
    public partial class frmCadastroSubCategoria : Form
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }
        public DALConexao conexao;


        public frmCadastroSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }


        public string operacao;

        #region alterar botoes
        public void alterabotoes(int op)
        {
            //op = operacoes que serao feiras com os botoes
            //1 = preparar tela para inserir e localizar
            //2 = preparar tela para inserir/alterar um registro
            //3 = preparar tela para excluir ou alterar

            pnDados.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = false;
            btnLocalizar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
                btnCancelar.Enabled = true;
                pnDados.Enabled = false;
            }
            if (op == 2)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                pnDados.Enabled = true;
            }
            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
                pnDados.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
        #endregion alterarbotoes

        #region abrircombo
        private void AbrirComboCategoria()
        {
            string strConexao = "server=DESKTOP-MPBBNFK\\MYSQLSERVER;Database=CRUDNOVO;User Id=SUPER;Password=123456;";

            SqlConnection connection = new SqlConnection(strConexao);
            try
            {
                string Query = "SELECT * FROM CATEGORIA";
                SqlCommand cmd = new SqlCommand(Query, connection);
                connection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(ds);
                cboCodigoCategoria.DataSource = ds.Tables[0];
                cboCodigoCategoria.DisplayMember = "nome_CATEGORIA";
                cboCodigoCategoria.ValueMember = "id_CATEGORIA";
                SqlDataReader registro = cmd.ExecuteReader();
                MessageBox.Show(cboCodigoCategoria.Text);
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion abrircombo

        #region limpar tela
        public void limpatela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }
        #endregion limpar tela

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            AbrirComboCategoria();
            alterabotoes(1);
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.alterabotoes(2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        { 
            try
            {
                ModeloSubCategoria modeloSubCategoria = new ModeloSubCategoria();
                modeloSubCategoria.SUBCAT_NOME = txtNome.Text;
                modeloSubCategoria.CATSUBCAT_ID = Convert.ToInt32(cboCodigoCategoria.SelectedValue);

                DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                if (this.operacao == "Inserir")
                {
                    bll.Incluir(modeloSubCategoria);
                    MessageBox.Show("Cadastro realizado com sucesso codigo: " + modeloSubCategoria.SUBCAT_ID.ToString());
                }
                else
                {
                    bll.Alterar(modeloSubCategoria);
                    MessageBox.Show("Sub Categoria alterada com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpatela();
            alterabotoes(1);
        }
    }
}
