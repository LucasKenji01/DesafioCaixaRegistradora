using System;
using System.Globalization;

namespace CaixaRegistradora
{
    internal class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {

        }

        public override string ToString()
        {
            return $"{Quantidade}x ----- {Nome} ----- {(Preco * Quantidade).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
