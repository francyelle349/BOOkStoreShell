using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerCliente
    {
        public static bool loginCliente (string email, string senha)
        {
            Cliente resultado = new Cliente().getLoginCliente(email, senha);
            if (resultado.emailCliente == email && resultado.getSenhaCliente() == senha)
                return true;
            return false;
        }
    }
}
