using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Controller
{
    public class ControllerLivro
    {
        //Método que será usado no View
        // o c na frente é de controller

        public static string cAdd_Livro(string nomeLivro, int genero, int estoque, float precoUnitario)
        {
            Livro Obj = new Livro();
            Obj.NomeLivro = nomeLivro;
            Obj.Genero = genero;
            Obj.Estoque = estoque;
            Obj.PrecoUnitario = precoUnitario;

            return Obj.Add_Livro(Obj);

        }

        public static string cEditar_Livro(int idLivro, string nomeLivro, int genero, int estoque, float precoUnitario)
        {
            Livro Obj = new Livro();
            Obj.IdLivro = idLivro;
            Obj.NomeLivro = nomeLivro;
            Obj.Genero = genero;
            Obj.Estoque = estoque;
            Obj.PrecoUnitario = precoUnitario;



            return Obj.Editar_Livro(Obj);

        }
        public static string cDeletar_Estoque(int idLivro)
        {
            Livro Obj = new Livro();
            Obj.IdLivro = idLivro;



            return Obj.Delete_Livro(Obj);
        }
        
        public static DataTable Exibir_Livro()
        {
            return new Livro().Exibir_Livro();
        }
        public static DataTable Pesquisar(string textobuscar)
        {
            Livro Obj = new Livro();
            Obj.NomeLivro = textobuscar;
            return Obj.Buscar_Livro(Obj);
        }
    
    }
}
