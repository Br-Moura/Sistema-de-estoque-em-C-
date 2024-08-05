using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLSubCategoria
    {
        private DALConexao conexao;
        public BLLSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        #region Incluir
        public void Incluir(ModeloSubCategoria modelo)
        {
            if(modelo.SUBCAT_NOME.Trim().Length == 0)
            {
                throw new Exception("O nome da SUB Categoria é obrigatorio");
            }
            if(modelo.CATSUBCAT_ID <= 0)
            {
                throw new Exception("O codigo da Categoria é obrigatorio");
            }
           if (!int.TryParse(modelo.CATSUBCAT_ID, out int result))
            {
                throw new Exception("Insira um ID numérico");
            }

            DALSubcategoria DALobj = new DALSubcategoria(conexao);
            DALobj.Incluir(modelo);
        }
        #endregion Incluir

        #region Alterar
        public void Alterar(ModeloSubCategoria modelo)
        {
            if(modelo.SUBCAT_ID <= 0)
            {
                throw new Exception("O codigo da Categoria é obrigatorio");
            }
            if(modelo.SUBCAT_NOME.Trim().Length == 0)
            {
                throw new Exception("O nome da SUB Categoria é obrigatorio");
            }
            if(modelo.CATSUBCAT_ID <= 0)
            {
                throw new Exception("O codigo da Categoria é obrigatorio");
            }
           if (!int.TryParse(modelo.CATSUBCAT_ID, out int result))
            {
                throw new Exception("Insira um ID numérico");
            }
        }
        #endregion Alterar

        #region Deletar
        public void Deletar(ModeloSubCategoria modelo)
        {
            DALSubcategoria DALobj = new DALSubcategoria();
            DALobj.Deletar(modelo);
        }
        #endregion Deletar

        #region Pesquisar
        public DataTable Pesquisar(String Valor)
        {
            DALSubcategoria DALobj = new DALSubcategoria();
            return DALobj.Pesquisar(valor);
        }
        #endregion Pesquisar

        #region Carregar modelo SubCategoria
        public ModeloSubCategoria CarregarModeloSubCategoria(int codigo)
        {
            DALSubcategoria DALobj = new DALSubcategoria();
            return DALobj.CarregarModeloSubCategoria(codigo);
        }
        #endregion Carregar modelo SubCategoria
    }
}