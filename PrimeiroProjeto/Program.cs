using System;
using System.Globalization;
using System.Collections.Generic;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Maria", "Carlos", "Bruno", "Carol"};

            Console.Write("Digite sua pesquisa: ");
            string busca = Console.ReadLine();

            List<string> list2 = list.FindAll(x => x.StartsWith(busca));
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
        }





    }
}

