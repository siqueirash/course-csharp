using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cliente;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o títular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Entre com deposito inicial: ");
            double deposito = double.Parse(Console.ReadLine());

            cliente = new ContaBancaria(numero, titular, deposito);

            Console.WriteLine(cliente);
        }





    }
}

