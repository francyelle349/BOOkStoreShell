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
        public string cpfCliente;
        public string emailCliente;
        public string endereco;
        private string senhaCliente;

        public Cliente (
            string nomeCliente = "",
            string cpfCliente = "",
            string emailCliente = "",
            string endereco = "",
            string senhaCliente = ""
            )
        {
            this.nomeCliente = nomeCliente;
            this.cpfCliente = cpfCliente;
            this.emailCliente = emailCliente;
            this.endereco = endereco;
            this.senhaCliente = senhaCliente;
        }

        public string getSenhaCliente ()
        {
            return this.senhaCliente;
        }

        public Cliente getLoginCliente(string email, string senha)
        {
            // Inicia a string de conexão
            SqlConnection SqlCon = new SqlConnection(BD.cn);
            SqlCommand SqlCmd = new SqlCommand("SELECT email, senha FROM loginData WHERE email = @email AND senha = @senha", SqlCon);
            SqlCon.Open();
            SqlCmd.Parameters.AddWithValue("@email", email);
            SqlCmd.Parameters.AddWithValue("@senha", senha);
            Cliente cliente = new Cliente("", "", email, "", senha);
            try
            {
                using (SqlDataReader reader = SqlCmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        cliente.emailCliente = reader["email"].ToString();
                        cliente.senhaCliente = reader["senha"].ToString();
                    }
                }
            } catch (Exception)
            {
            }
            SqlCon.Close();
            // retorna cliente
            return cliente;
        }

        

        
    }
}
