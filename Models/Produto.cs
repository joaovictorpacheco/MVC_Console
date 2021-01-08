using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv";
        public Produto()
        {
            string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);

            }
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            //Pegas as informações do csv
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
            //Separar atributos pelo;
            string[] atributos = item.Split(";");
            //Criamos um produto vazio para poder colocar uma lista final de produtos
            Produto prod = new Produto();
            prod.Codigo  = int.Parse(atributos[0]);
            prod.Nome    = atributos[1];   
            prod.Preco   = float.Parse(atributos[2]);

            produtos.Add(prod);

            }

            return produtos;

        }
        public void Inserir(Produto p)
        {
            //Preparamos um array do string para o método AppendAllLines
            string[] linhas = { PrepararLinhaCSV(p) };

            // INserimos o array de linhas do arquivo CSV 
            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhaCSV(Produto prod)
        {
            // Preparamos a linha para o formato do CSV
            return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
        }
    }
}