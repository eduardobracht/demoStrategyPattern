using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisaoPadroes_2
{
    public class KitPascoa : KitPromocao
    {
        List<IProduto> Produtos;
        double total;

        public KitPascoa(List<IProduto> produtos)
        {
            this.Produtos = new List<IProduto>(produtos);
        }

        public override double Preco
        {
            get
            {
                total = 0;
                foreach (IProduto produto in this.Produtos) {
                    total += produto.Preco;
                }
                total = total - (total * 0.10);
                return total;
            }
        }

        public override Produto Produto
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            String lista = null;
            foreach (Produto produto in Produtos)
            {
                lista += $"\n[codigo={produto.Codigo}, descricao={produto.Descricao}, quantidade={produto.Quantidade}, preco={produto.Preco}]";
            }
            return base.ToString() + lista;
        }
    }
}