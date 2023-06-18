using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controller
{
    public class ControllerPedidos
    {
        public static DataTable cExibir_Pedido()
        {
            return new Pedido().Exibir_Pedidos();
        }
    }
}
