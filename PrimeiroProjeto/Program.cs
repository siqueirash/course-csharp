using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {
        static void Main(string[] args) {
            Produto p1= new Produto("TV", 500.00);


            p1.Nome = "TV 4K";
            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Preco);
            Console.WriteLine(p1.Quantidade);


        }





    }
}

