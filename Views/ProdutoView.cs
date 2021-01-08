using System;
using System.Collections.Generic;
using MVC.Models;

namespace MVC.Views
{
    public class ProdutoView
    {
        public void ListarTodos(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine($"Codigo : {item.Codigo}");
                Console.WriteLine($"Nome : {item.Nome}");
                Console.WriteLine($"Preço : R$ {item.Preco}");
                Console.WriteLine();
            }
        }
        public Produto CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Digite o codigo do Produto:");
            produto.Codigo = int.Parse( Console.ReadLine() );

            Console.WriteLine($"Digite o nome do Produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o preço do Produto:");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
        }
    }
}