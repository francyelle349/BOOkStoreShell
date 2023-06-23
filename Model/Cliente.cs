using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        public static int idCliente = 0;
        public string nomeCliente;
        public string emailCliente;
        public string cpfCliente;
        public string telCliente;
        private string senhaCliente;

        public Cliente (
            int idCliente = 0,
            string nomeCliente = "",
            string emailCliente = "",
            string cpfCliente = "",
            string telCliente = "",
            string senhaCliente = ""
            )
        {
            Cliente.idCliente = idCliente;
            this.nomeCliente = nomeCliente;
            this.emailCliente = emailCliente;
            this.cpfCliente = cpfCliente;
            this.telCliente = telCliente;
            this.senhaCliente = senhaCliente;
        }

        public string getSenhaCliente ()
        {
            return this.senhaCliente;
        }

        public Cliente getLoginCliente(string emailCliente, string senhaCliente)
        {
            // Inicia a string de conexão
            SqlConnection SqlCon = new SqlConnection(BD.cn);
            SqlCommand SqlCmd = new SqlCommand("SELECT idCliente, emailCliente, senhaCliente FROM cliente WHERE emailCliente = @emailCliente AND senhaCliente = @senhaCliente", SqlCon);
            SqlCon.Open();
            SqlCmd.Parameters.AddWithValue("@emailCliente", emailCliente);
            SqlCmd.Parameters.AddWithValue("@senhaCliente", senhaCliente);
            Cliente cliente = new Cliente();
            try
            {
                using (SqlDataReader reader = SqlCmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        cliente.emailCliente = reader["emailCliente"].ToString();
                        cliente.senhaCliente = reader["senhaCliente"].ToString();
                        idCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    }
                }
            } catch (Exception)
            {
            }
            SqlCon.Close();
            // retorna cliente
            return cliente;
        }

        public void cadastrarCliente(string nomeCliente, string emailCliente, string cpfCliente, string telCliente, string senhaCliente)
        {
            // Inicia a string de conexão
            SqlConnection SqlCon = new SqlConnection(BD.cn);
            SqlCommand SqlCmd = new SqlCommand("INSERT INTO cliente (nomeCliente, emailCliente, cpfCliente, telCliente, senhaCliente) VALUES( @nomeCliente, @emailCliente, @cpfCliente, @telCliente, @senhaCliente)", SqlCon);
            SqlCmd.Parameters.AddWithValue("@nomeCliente", nomeCliente);
            SqlCmd.Parameters.AddWithValue("@emailCliente", emailCliente);
            SqlCmd.Parameters.AddWithValue("@cpfCliente", cpfCliente);
            SqlCmd.Parameters.AddWithValue("@telCliente", telCliente);
            SqlCmd.Parameters.AddWithValue("@senhaCliente", senhaCliente);

            try
            {
                SqlCon.Open();
                SqlCmd.ExecuteNonQuery();
                SqlCon.Close();
            }
            catch (SqlException ex)
            {
                SqlCon.Close();
                throw ex;
            }
        }
    }
}
