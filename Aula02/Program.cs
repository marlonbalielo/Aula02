using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            Console.WriteLine("Codigo: "+ produto1.codigo);
            Console.WriteLine("Nome: " + produto1.nome);
            Console.WriteLine("Quantidade: " + produto1.quantidade);
            Console.WriteLine("Preco: " + produto1.preco);

            Produto produto2 = new Produto(545,"Alessandro",30,45.46,DateTime.Now);

            Console.WriteLine("\nCodigo: " + produto2.codigo);
            Console.WriteLine("Nome: " + produto2.nome);
            Console.WriteLine("Quantidade: " + produto2.quantidade);
            Console.WriteLine("Preco: " + produto2.preco);
            Console.WriteLine("Validade: "+ produto2.validade);

            Produto produto3 = new Produto("Romeu",12,13.24);

            Console.WriteLine("\nCodigo: " + produto3.codigo);
            Console.WriteLine("Nome: " + produto3.nome);
            Console.WriteLine("Quantidade: " + produto3.quantidade);
            Console.WriteLine("Preco: " + produto3.preco);

            Produto produto4 = new Produto(4533, "Marlon", 34, 53.23,DateTime.Now);
           
            Console.WriteLine("\nCodigo: " + produto4.codigo);
            Console.WriteLine("Nome: " + produto4.nome);
            Console.WriteLine("Quantidade: " + produto4.quantidade);
            Console.WriteLine("Preco: " + produto4.preco);
            Console.WriteLine("Validade: " + produto4.validade);


        }
    }
}
