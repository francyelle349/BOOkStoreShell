using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class itemPedido
    {
        public int idLivro;
        public int idPedido;
        public int qtdItemPedido;

        public itemPedido(int idLivro, int qtdItemPedido)
        {
            this.idLivro = idLivro;
            this.qtdItemPedido = qtdItemPedido;
        }
    }
}
