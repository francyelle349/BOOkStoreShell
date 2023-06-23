using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        
        
        
        public Pedido()
        {

        }

        public Pedido(int idPedido, string dataPedido, double valorPedido, string cpfCliente)
        {
            this.idPedido = idPedido;
            this.dataPedido = dataPedido;
            this.valorPedido = valorPedido;
            this.cpfCliente = cpfCliente;
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


    }
}

