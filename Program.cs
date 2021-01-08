using System;
using MVC.Controllers;
using MVC.Models;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtoController = new ProdutoController();
            
            produtoController.Cadastrar();

            produtoController.MostrarProdutos();
            
        }
    }
}
