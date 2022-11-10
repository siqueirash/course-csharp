
namespace PrimeiroProjeto
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        private string Titular { get; set; }
        public double Saldo { get; set; }

     

        public ContaBancaria(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }


        public void Saque(double quantia)
        {

        }


        public override string ToString()
        {
            return Titular + ", " + Numero + ", " + Saldo;
        }


    }
}
