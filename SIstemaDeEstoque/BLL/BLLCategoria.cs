using DALL;
using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace BLL
{
     class BLLCategoria
    {
        private DALConexao conexao;
        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCategoria modelo)
        {
            if(modelo.CatID <= 0)
            {
                throw new Exception("O codigo da categoria é obrigatorio");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatorio");
            }

            //modelo.CatNome = modelo.CatNome.ToUpper();
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Incluir(modelo);

        }
        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CatID <= 0)
            {
                throw new Exception("O codigo da categoria é obrigatorio");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatorio");
            }

            //modelo.CatNome = modelo.CatNome.ToUpper();
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Alterar(modelo);
        }

        public void Deletar(ModeloCategoria modelo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Deletar(modelo);
        }
        public DataTable Pesquisar(String valor)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Pesquisar(valor);
        }
        public ModeloCategoria CarregarModeloCategoria(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.CarregarModeloCategoria(codigo);
        }
    }
}
