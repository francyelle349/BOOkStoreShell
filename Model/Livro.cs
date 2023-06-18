using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class Livro
    {
        private int idLivro;
        private string nomeLivro;
        private int genero;
        private int estoque;
        private float precoUnitario;
        

        public int IdLivro { get => idLivro; set => idLivro = value; }
        public string NomeLivro { get => nomeLivro; set => nomeLivro = value; }
        public int Genero { get => genero; set => genero = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public float PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }

        //construtor vazio não exclua
        public Livro() { 
        }

        //contrutor com Parametros
        public Livro(int idLivro, string nomeLivro, int genero, int estoque,float precoUnitario )
        {
            this.IdLivro = idLivro;
            this.nomeLivro = nomeLivro;
            this.genero = genero;
            this.estoque = estoque;
            this.precoUnitario = precoUnitario;
        }

        //metodo inserir livro
        public string Add_Livro(Livro livro) 
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = BD.cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();   
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spadd_livro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdLivro = new SqlParameter();
                ParIdLivro.ParameterName = "@idLivro";
                ParIdLivro.SqlDbType = SqlDbType.Int;
                ParIdLivro.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdLivro);


                SqlParameter ParNomeLivro = new SqlParameter();
                ParNomeLivro.ParameterName = "@titulo";
                ParNomeLivro.SqlDbType = SqlDbType.VarChar;
                ParNomeLivro.Size = 100;
                ParNomeLivro.Value = nomeLivro;
                SqlCmd.Parameters.Add(ParNomeLivro);


                SqlParameter ParPrecoLivro = new SqlParameter();
                ParPrecoLivro.ParameterName = "@precoLivro";
                ParPrecoLivro.SqlDbType = SqlDbType.Float;
                ParPrecoLivro.Value = precoUnitario;
                SqlCmd.Parameters.Add(ParPrecoLivro);

                SqlParameter ParEstoque = new SqlParameter();
                ParEstoque.ParameterName = "@estoqueLivro";
                ParEstoque.SqlDbType = SqlDbType.Int;
                ParEstoque.Value = estoque;
                SqlCmd.Parameters.Add(ParEstoque);

                SqlParameter ParGenero= new SqlParameter();
                ParGenero.ParameterName = "@idGenero";
                ParGenero.SqlDbType = SqlDbType.Int;
                ParGenero.Value = genero;
                SqlCmd.Parameters.Add(ParGenero);

                //executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro nao foi adicionado";

            }
            catch(Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                // verifica se caso a conexao estiver aberta, da o close.
                if(SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }
        //metodo editar livro
        public string Editar_Livro(Livro livro)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = BD.cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_livro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdLivro = new SqlParameter();
                ParIdLivro.ParameterName = "@idLivro";
                ParIdLivro.SqlDbType = SqlDbType.Int;
                ParIdLivro.Value = idLivro;
                SqlCmd.Parameters.Add(ParIdLivro);


                SqlParameter ParNomeLivro = new SqlParameter();
                ParNomeLivro.ParameterName = "@titulo";
                ParNomeLivro.SqlDbType = SqlDbType.VarChar;
                ParNomeLivro.Size = 100;
                ParNomeLivro.Value = nomeLivro;
                SqlCmd.Parameters.Add(ParNomeLivro);


                SqlParameter ParPrecoLivro = new SqlParameter();
                ParPrecoLivro.ParameterName = "@precoLivro";
                ParPrecoLivro.SqlDbType = SqlDbType.Decimal;
                ParPrecoLivro.Value = precoUnitario;
                SqlCmd.Parameters.Add(ParPrecoLivro);

                SqlParameter ParEstoque = new SqlParameter();
                ParEstoque.ParameterName = "@estoqueLivro";
                ParEstoque.SqlDbType = SqlDbType.Int;
                ParEstoque.Value = estoque;
                SqlCmd.Parameters.Add(ParEstoque);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@idGenero";
                ParGenero.SqlDbType = SqlDbType.Int;
                ParGenero.Value = genero;
                SqlCmd.Parameters.Add(ParGenero);

                //executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro nao foi editado";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                // verifica se caso a conexao estiver aberta, da o close.
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;

        }
        //metodo excluir livro
        public string Delete_Livro(Livro livro)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = BD.cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spexcluir_livro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdLivro = new SqlParameter();
                ParIdLivro.ParameterName = "@idLivro";
                ParIdLivro.SqlDbType = SqlDbType.Int;
                ParIdLivro.Value = idLivro;
                SqlCmd.Parameters.Add(ParIdLivro);

                //executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Livro deletado" : "Registro nao foi deletado";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                // verifica se caso a conexao estiver aberta, da o close.
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }
        //metodo exibir livro
        public DataTable Exibir_Livro()
        {
            DataTable DtResultado = new DataTable("livro");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = BD.cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_Livro";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);

                sqlDat.Fill(DtResultado);


            }catch(Exception )
            {
                DtResultado = null;
            }
            return DtResultado;


        }
        //metodo Buscar livro
        public DataTable Buscar_Livro(Livro livro)
        {
            DataTable DtResultado = new DataTable("livro");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = BD.cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_livro";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);

                SqlParameter ParBuscarTitulo = new SqlParameter();
                ParBuscarTitulo.ParameterName = "@textobuscar";
                ParBuscarTitulo.SqlDbType = SqlDbType.VarChar;
                ParBuscarTitulo.Size = 100;
                ParBuscarTitulo.Value = nomeLivro;
                SqlCmd.Parameters.Add(ParBuscarTitulo);

                sqlDat.Fill(DtResultado);


            }
            catch (Exception )
            {
                DtResultado = null;
            }
            return DtResultado;

        }



    }
}
