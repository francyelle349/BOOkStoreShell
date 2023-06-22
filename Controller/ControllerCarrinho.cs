using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    internal class ControllerCarrinho
    {

        //exibir seus livros
        //somar seu valor
        //realizar pedido
        public static string Add_Carrinho(string cpfCliente, int idLivro, string nomeLivro, int genero, int estoque, float precoUnitario, int qtdCompra)
        {
            Livro Obj = new Livro();
            Obj.IdLivro = idLivro();
            Obj.NomeLivro = nomeLivro;
            Obj.Genero = genero;
            Obj.Estoque = estoque;
            Obj.PrecoUnitario = precoUnitario;
            Obj.QtdCompra = qtdCompra;

            return Obj.Add_Carrinho(Obj);
            //a tabela carrinho vai ser intermediaria para pedido
            //uma "memoria cache" do estoque, ainda nao foi realizado o pedido
            //vai ser como copiar as informações da tabela estoque
            // já tem tratamento para erro caso o user coloque uma qtd de compra maior que o estoque.


        }
        public static string Deletar_Carrinho(int idLivro)
        {
            Livro Obj = new Livro();
            Obj.IdLivro = idLivro;

            return Obj.Delete_Carrinho(Obj);

            /*create proc delete_Carrinho
             * @cpfCliente = cpfCliente
             * @idLivro = idLivro
             * as
             * delete from tb_Carrinho where cpfCliente = @cpfCliente and 
             * idLivro = @idLivro
             */
        }
        public static string Somar_Carrinho(string cpfCliente)
        {
            return new Somar_Livro();

            /*create proc Soma_Carrinho
            * @cpfCliente = cpfCliente
            * @TotalCompra = TotalCompra
            * as
            * SELECT @Total = SUM(QtdCompra * ValorUnitario)
            * FROM Carrinho
            * WHERE cpfCliente = @cpfCliente;
            */

        }
        

    }
}
