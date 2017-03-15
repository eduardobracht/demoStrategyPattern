using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisaoPadroes_2
{
    public class ImpostoPoliticaPorCategoria : CalculadorImposto
    {
        public readonly double TAXABASE;
        private IDictionary<int, double> taxaImpostoPorCategoria;
        public ImpostoPoliticaPorCategoria(IDictionary<int, double> tabelaTaxas, double umaTaxaBase)
        {
            taxaImpostoPorCategoria = tabelaTaxas;
            TAXABASE = umaTaxaBase;
        }
        public double CalcularImposto(Produto umProduto, Usuario umUsuario)
        {
            if(taxaImpostoPorCategoria.ContainsKey(umProduto.Categoria.Codigo))
            {
                return umProduto.Preco * taxaImpostoPorCategoria[umProduto.Categoria.Codigo];
            }
            else
            {
                return umProduto.Preco * TAXABASE;
            }
        }
    }
}
