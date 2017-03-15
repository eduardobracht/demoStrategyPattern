using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisaoPadroes_2
{
    public class Venda
    {
        private class ItemVenda
        {
            public Produto Produto { get; set; }
            public int Quantidade { get; set; }
            public double CalcularTotal()
            {
                return Produto.Preco * Quantidade;
            }
        }
        private IList<ItemVenda> itens;
        private Usuario usuario;
        public Venda(Usuario umUsuario)
        {
            itens = new List<ItemVenda>();
            usuario = umUsuario;
        }
        public Usuario Usuario
        {
            get { return usuario; }
        }
        public IDictionary<Produto,int> ItensVenda
        {
            get
            {
                IDictionary<Produto, int> itensVenda = new Dictionary<Produto, int>();
                foreach(var item in itens)
                {
                    itensVenda.Add(item.Produto, item.Quantidade);
                }
                return itensVenda;
            }
        }
        public void AdicionarProduto(Produto umProduto, int umaQuantidade)
        {
            ItemVenda item = new ItemVenda();
            item.Produto = umProduto;
            item.Quantidade = umaQuantidade;
            itens.Add(item);
        }
        public double CalcularTotal(CalculadorImposto calcImp, CalculadorDesconto calcDesc)
        {
            double total = 0.0;
            foreach(var item in itens)
            {
                double subtotal = item.CalcularTotal();
                double subtotalImposto = calcImp.CalcularImposto(item.Produto, usuario);
                double subtotalDesconto = calcDesc.CalcularDesconto(item.Produto, usuario, subtotalImposto);
                double subtotalFinal = subtotal + subtotalImposto - subtotalDesconto;
                total += subtotalFinal;
            }
            return total;
        }
    }
}
