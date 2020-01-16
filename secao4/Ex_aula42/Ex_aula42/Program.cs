using System;
using System.Globalization;

namespace Ex_aula42
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10);

            Console.WriteLine(produto.Nome);

            produto.Nome = "TV 4k";
            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);

            

            //console.writeline("entre os dados do produto:");
            //console.write("nome: ");
            //string nome = console.readline();
            //console.write("preço: ");
            //double preco = double.parse(console.readline(), cultureinfo.invariantculture);
            //console.write("quantidade no estoque: ");
            //int quantidade = int.parse(console.readline());
            //console.writeline();

            //produto produto = new produto(nome, preco, quantidade);

            //console.writeline();
            //console.writeline(produto2);

            //console.writeline();
            //console.writeline("dados do produto: " + produto);

            //console.writeline();
            //console.write("digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.parse(console.readline());
            //produto.adicionarprodutos(qte);

            //console.writeline();
            //console.writeline("dados do produto:" + produto);

            //console.writeline();
            //console.write("digite o número de produtos a ser removido do estoque: ");
            //qte = int.parse(console.readline());
            //produto.removerprodutos(qte);

            //console.writeline();
            //console.writeline("dados do produto: " + produto);
        }
    }
}
