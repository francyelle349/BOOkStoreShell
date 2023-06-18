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
        private float valorPedido;
        private int idCliente;

        public Pedido()
        {

        }
        public Pedido(int idPedido, string dataPedido, float valorPedido, int idCliente)
        {
            IdPedido = idPedido;
            DataPedido = dataPedido;
            ValorPedido = valorPedido;
            IdCliente = idCliente;

        }

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string DataPedido { get => dataPedido; set => dataPedido = value; }
        public float ValorPedido { get => valorPedido; set => valorPedido = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }


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


    }
}

