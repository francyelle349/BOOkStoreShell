using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Model
{
    public class Pedido
    {
        private int idPedido;
        private string dataPedido;
        private double valorPedido;
        private string cpfCliente;

       
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string DataPedido { get => dataPedido; set => dataPedido = value; }
        public double ValorPedido { get => valorPedido; set => valorPedido = value; }
        public int idCliente { get => idCliente; set => idCliente = value; }
        
        
        
        public Pedido()
        {

        }

        public Pedido(int idCliente, int idPedido = 0, string dataPedido = "", double valorPedido = 0)
        {
            this.idPedido = idPedido;
            this.dataPedido = dataPedido;
            this.valorPedido = valorPedido;
            this.idCliente = idCliente;
        }
      

        public DataTable Exibir_Pedidos()
        {
            DataTable DtResultado = new DataTable("pedidos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = BD.cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_Vendas";
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

        public static string getTotalVendas()
        {
            string totalvendas;
            using (SqlConnection connection = new SqlConnection(BD.cn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT SUM(valorTotalPedido) FROM Pedido;", connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal total = Convert.ToDecimal(result);
                        totalvendas = total.ToString("C");
                    }
                    else
                    {
                        totalvendas = "Não há registros.";
                    }
                }
            }
            return totalvendas;
        }

        public static string efetuaPedido(List<itemPedido> items, int idCliente)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(BD.cn))
                {
                    SqlCommand sqlcmd = new SqlCommand("sp_pre_venda", connection);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.CommandText = "SELECT TOP 1 idPedido FROM pedido ORDER BY DESC";
                    sqlcmd.CommandType = CommandType.Text;
                    int idPedido = sqlcmd.ExecuteReader().GetInt32(0);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.CommandText = "spadd_item_pedido";
                    for (int i = 0; i < items.Count; i++)
                    {
                        sqlcmd.Parameters.AddWithValue("@idLivro", items[i].idLivro);
                        sqlcmd.Parameters.AddWithValue("@idPedido", idPedido);
                        sqlcmd.Parameters.AddWithValue("@idLivro", items[i].qtdItemPedido);
                    }
                    sqlcmd.ExecuteNonQuery();
                    connection.Close();
                }
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return "Pedido efetuado com sucesso";
        }


    }
}

