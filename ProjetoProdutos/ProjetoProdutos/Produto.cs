using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProdutos
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RetirarProdutos(int retirar)
        {
            Quantidade -= retirar;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}"
                + $", {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
