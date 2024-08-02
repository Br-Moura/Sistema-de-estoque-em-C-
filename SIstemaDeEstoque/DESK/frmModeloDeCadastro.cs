using MODELO;
using DALL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DESK
{
    public partial class frmModeloDeCadastro : Form
    {
        public string operacao;

        public frmModeloDeCadastro()
        {
            InitializeComponent();
        }

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

        private void frmModeloDeCadastro_Load(object sender, EventArgs e)
        {
            this.alterabotoes(1);
        }

        public void limpatela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.alterabotoes(2);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpatela();
            this.alterabotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.CatNome = txtNome.Text;

                //obj para gravacao de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                if (this.operacao == "Inserir")
                {
                    //cadatrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetudo: Codigo " + modelo.CatID.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.CatID = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                }
                this.limpatela();
                this.alterabotoes(1);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            
        }
    }
}
