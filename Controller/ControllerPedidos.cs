﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Controller
{

    public class ControllerPedidos
    {
        public static DataTable Exibir_Pedido()
        {
            return new Pedido().Exibir_Pedidos();
        }


      
        
        /*public static string Finalizar_Pedido(string cpfCliente, Double valorPedido, string dataPedido)
        {
            Pedido Obj = new Pedido();
            Obj.CpfCliente = cpfCliente;
            Obj.ValorPedido = valorPedido;
            Obj.DataPedido = dataPedido;


            return Obj.Finalizar_Pedido(Obj);
            //quando clicar no finalizar pedido dentro do carrinho
            // é adicionado a tabela pedido o obj pedido com as informaçoes.
            // uma vez finalizado nao volte atras 

            /*create proc Finalizar_Pedido
             * @cpfcliente = cpfcliente
             * @TotalCompra = TotalCompra
             * @DataPedido = dataPedido
             * as
             * insert into Pedido set (cpfcliente,TotalCompra,DataPedido) 
             * values (@cpfcliente,@TotalCompra,@DataPedido)
             
        }
    */
    }
}
