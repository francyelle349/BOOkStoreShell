using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Carrinho
    {
        string cpfCliente;
        int idLivro;
        string nomeLivro;
        int genero;
        int estoque;
        double precoUnitario;
        int qtdCompra;


        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public int IdLivro { get => idLivro; set => idLivro = value; }
        public string NomeLivro { get => nomeLivro; set => nomeLivro = value; }
        public int Genero { get => genero; set => genero = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }
        public int QtdCompra { get => qtdCompra; set => qtdCompra = value; }

        public Carrinho()
        {
        }

        public Carrinho(string cpfCliente, int idLivro, string nomeLivro, int genero, int estoque, double precoUnitario, int qtdCompra)
        {
            this.cpfCliente = cpfCliente;
            this.idLivro = idLivro;
            this.nomeLivro = nomeLivro;
            this.genero = genero;
            this.estoque = estoque;
            this.precoUnitario = precoUnitario;
            this.qtdCompra = qtdCompra;
        }


        public string InserirCarrinho(Carrinho carrinho)
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
                SqlCmd.CommandText = "InserirCarrinho";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCpfCliente = new SqlParameter();
                ParCpfCliente.ParameterName = "@cpfCliente";
                ParCpfCliente.SqlDbType = SqlDbType.VarChar;
                ParCpfCliente.Size = 100;
                ParCpfCliente.Value = cpfCliente;
                SqlCmd.Parameters.Add(ParCpfCliente);

                SqlParameter ParIdLivro = new SqlParameter();
                ParIdLivro.ParameterName = "@idLivro";
                ParIdLivro.SqlDbType = SqlDbType.Int;
                ParIdLivro.Value = idLivro;
                SqlCmd.Parameters.Add(ParIdLivro);


                SqlParameter ParNomeLivro = new SqlParameter();
                ParNomeLivro.ParameterName = "@nomeLivro";
                ParNomeLivro.SqlDbType = SqlDbType.VarChar;
                ParNomeLivro.Size = 100;
                ParNomeLivro.Value = nomeLivro;
                SqlCmd.Parameters.Add(ParNomeLivro);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@genero";
                ParGenero.SqlDbType = SqlDbType.Int;
                ParGenero.Value = genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParEstoque = new SqlParameter();
                ParEstoque.ParameterName = "@estoque";
                ParEstoque.SqlDbType = SqlDbType.Int;
                ParEstoque.Value = estoque;
                SqlCmd.Parameters.Add(ParEstoque);

                SqlParameter ParPrecoLivro = new SqlParameter();
                ParPrecoLivro.ParameterName = "@precoUnitario";
                ParPrecoLivro.SqlDbType = SqlDbType.Decimal;
                ParPrecoLivro.Value = precoUnitario;
                SqlCmd.Parameters.Add(ParPrecoLivro);

                SqlParameter ParQtdCompra = new SqlParameter();
                ParQtdCompra.ParameterName = "@qtdCompra";
                ParQtdCompra.SqlDbType = SqlDbType.Int;
                ParQtdCompra.Value = qtdCompra;
                SqlCmd.Parameters.Add(ParQtdCompra);



                //executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro nao foi adicionado";

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
        public DataTable ExibirCarrinho()
        {
            DataTable DtResultado = new DataTable("Carrinho");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = BD.cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ExibirCarrinho";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);

                sqlDat.Fill(DtResultado);


            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;


        }

    }

}

