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
        public static bool loginCliente (string emailCliente, string senhaCliente)
        {
            Cliente resultado = new Cliente().getLoginCliente(emailCliente, senhaCliente);
            if (resultado.emailCliente == emailCliente && resultado.getSenhaCliente() == senhaCliente)
                return true;
            return false;
        }

        public void CadastrarCliente(string nomeCliente, string emailCliente, string cpfCliente, string telCliente, string senhaCliente)
        {
            // Lógica para cadastrar o cliente
            Cliente cliente = new Cliente(nomeCliente, emailCliente, cpfCliente, telCliente, senhaCliente);

            /*try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Código de erro específico para violação de chave única
                {
                    MessageBox.Show("Usuário já cadastrado. Por favor, escolha um email ou CPF diferente.");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            if (senhaCliente != confirmacaoSenha)
            {
                MessageBox.Show("As senhas informadas não conferem. Por favor, verifique e tente novamente.");
                return; // Aborta o cadastro
            }

            if (string.IsNullOrWhiteSpace(nomeCliente) || string.IsNullOrWhiteSpace(emailCliente) || string.IsNullOrWhiteSpace(cpfCliente) || string.IsNullOrWhiteSpace(telCliente) || string.IsNullOrWhiteSpace(senhaCliente))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return; // Aborta o cadastro
            }*/


        }
    }
}
