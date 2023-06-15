using System;
using System.Collections.Generic;
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
            string nomeCliente,
            string cpfCliente,
            string emailCliente,
            string endereco,
            string senhaCliente
            )
        {
            this.nomeCliente = nomeCliente;
            this.cpfCliente = cpfCliente;
            this.emailCliente = emailCliente;
            this.endereco = endereco;
            this.senhaCliente = senhaCliente;
        }
    }
}
