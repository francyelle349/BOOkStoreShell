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
        public string nomeCliente;
        public string emailCliente;
        public string cpfCliente;
        public string telCliente;
        private string senhaCliente;

        public Cliente (
            string nomeCliente = "",
            string emailCliente = "",
            string cpfCliente = "",
            string telCliente = "",
            string senhaCliente = ""
            )
        {
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
            SqlCommand SqlCmd = new SqlCommand("SELECT emailCliente, senhaCliente FROM cliente WHERE emailCliente = @emailCliente AND senhaCliente = @senhaCliente", SqlCon);
            SqlCon.Open();
            SqlCmd.Parameters.AddWithValue("@emailCliente", emailCliente);
            SqlCmd.Parameters.AddWithValue("@senhaCliente", senhaCliente);
            Cliente cliente = new Cliente("", emailCliente, "", "", senhaCliente);
            try
            {
                using (SqlDataReader reader = SqlCmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        cliente.emailCliente = reader["emailCliente"].ToString();
                        cliente.senhaCliente = reader["senhaCliente"].ToString();
                    }
                }
            } catch (Exception)
            {
            }
            SqlCon.Close();
            // retorna cliente
            return cliente;
        }

        public Cliente getCadastrarCliente(string nomeCliente, string emailCliente, string cpfCliente, string telCliente, string senhaCliente)
        {
            // Inicia a string de conexão
            SqlConnection SqlCon = new SqlConnection(BD.cn);
            SqlCommand SqlCmd = new SqlCommand("SELECT nomeCliente, emailCliente, cpfCliente, telCliente, senhaCliente FROM cliente WHERE nomeCliente = @nomeCliente AND emailCliente = @emailCliente AND cpfCliente = @cpfCliente AND telCliente = @telCliente AND senhaCliente = @senhaCliente", SqlCon);
            SqlCon.Open();
            SqlCmd.Parameters.AddWithValue("@nomeCliente", nomeCliente);
            SqlCmd.Parameters.AddWithValue("@emailCliente", emailCliente);
            SqlCmd.Parameters.AddWithValue("@cpfCliente", cpfCliente);
            SqlCmd.Parameters.AddWithValue("@telefoneCliente", telCliente);
            SqlCmd.Parameters.AddWithValue("@senhaCliente", senhaCliente);
            Cliente cliente = new Cliente(nomeCliente, emailCliente,cpfCliente,telCliente, senhaCliente);


            return cliente;
        }
    }
}
