using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace Controller
{
    public class ControllerCliente
    {
        public static bool loginCliente(string emailCliente, string senhaCliente)
        {
            Cliente resultado = new Cliente().getLoginCliente(emailCliente, senhaCliente);

            if (resultado.emailCliente == emailCliente && resultado.getSenhaCliente() == senhaCliente)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
  
        public void CadastrarCliente(string nomeCliente, string emailCliente, string cpfCliente, string telCliente, string senhaCliente)
        {
            try
            {
                new Cliente().cadastrarCliente(nomeCliente, emailCliente, cpfCliente, telCliente, senhaCliente);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void MostrarCliente(string nomeCliente, string emailCliente, string cpfCliente, string telCliente, string senhaCliente)
        {
            //jogar para os txtbox
        }
    }
}
