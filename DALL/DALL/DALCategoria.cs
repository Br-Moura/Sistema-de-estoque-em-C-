using MODELO;
using System.Data;
using System.Data.SqlClient;


namespace DALL
{
    class DALCategoria
    {
        private DALConexao conexao;

        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into CATEGORIA (nome_CATEGORIA)" +
                              "values ('@nome') select @@IDENTITY";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            conexao.Conectar();
            modelo.CatID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update CATEGORIA set nome_CATEGORIA = @nome" +
                              "where id_CATEGORIA = @id";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@id", modelo.CatID);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Deletar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete CATEGORIA where id_CATEGORIA = @id";
            cmd.Parameters.AddWithValue("@id", modelo.CatID);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Pesquisar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from CATEGORIA where nome_CATEGORIA like '%" +
            valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCategoria CarregarModeloCategoria(int codigo)
        {
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from CATEGORIA where id_CATEGORIA = @ID";
            cmd.Parameters.AddWithValue("@ID", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CatNome = Convert.ToString(registro["nome_CATEGORIA"]);
                modelo.CatID = Convert.ToInt32(registro["id_CATEGORIA"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
