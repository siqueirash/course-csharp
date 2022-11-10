

namespace PrimeiroProjeto {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            Preco = preco;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;

                }
            }
        }


        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome + ", $ " + Preco + ", " + Quantidade;
        }
    }
}
