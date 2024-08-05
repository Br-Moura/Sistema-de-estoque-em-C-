using System;
using MODELO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALL
{
    public class DALSubcategoria
    {
        public DALConexao conexao;

        public DALSubcategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        #region Incluir
        public void Incluir(ModeloSubCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into SUBCATEGORIA (nome_SUBCATEGORIA, id_categoria_SUBCATEGORIA)" +
                              " values (@nome, @idcategoria) select @@IDENTITY";
            cmd.Parameters.AddWithValue("@nome", modelo.SUBCAT_NOME);
            cmd.Parameters.AddWithValue("@idcategoria" modelo.CATSUBCAT_ID);
            conexao.Conectar();
            modelo.SUBCAT_ID = convert.ToInt32(cmd.ExecuteScalar(cmd.ExecuteScalar()));
            conexao.Desconectar();
        }
        #endregion Incluir

        #region Alterar
        public void Alterar(ModeloSubCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update SUBCATEGORIA set nome_SUBCATEGORIA = @nome, id_categoria_SUBCATEGORIA = @idcategoria " +
                              "where id_SUBCATEGORIA = @id";
            cmd.Parameters.AddWithValue("@id", modelo.id_SUBCATEGORIA);
            cmd.Parameters.AddWithValue("@nome", modelo.SUBCAT_NOME);
            cmd.Parameters.AddWithValue("@idcategoria" modelo.CATSUBCAT_ID);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        #endregion alterar

        #region Deletar
        public void Deletar(ModeloSubCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText= "delete SUBCATEGORIA where id_SUBCATEGORIA = @id"
            cmd.Parameters.AddWithValue("@id", modelo.SUBCAT_ID)
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        #endregion Deletar

        #region Pesquisar
        public DataTable Pesquisar(Strinf valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da  new SqlDataAdapter("select * from SUBCATEGORIA where nome_SUBCATEGORIA like '%" +
            valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        #endregion Pesquisar

        #region CarregarModeloSubCategoria
        public ModeloSubCategoria CarregarModeloSubCategoria(int codigo)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd cmd.CommandText= "selec * from SUBCATEGORIA where id_SUBCATEGORIA = @id";
            cmd.Parameters.AddWithValue("@id",modelo.SUBCAT_ID);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.SUBCAT_ID = convert.ToInt32(registro["id_SUBCATEGORIA"]);
                modelo.SUBCAT_NOME = convert.ToString(registro["nome_SUBCATEGORIA"]);
                modelo.CATSUBCAT_ID = convert.ToInt32(registro["id_categoria_SUBCATEGORIA"]);
            }
            conexao.Desconectar();
            return modelo;
        }
        #endregion CarregarModeloSubCategoria
    }
}