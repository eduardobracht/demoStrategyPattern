using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisaoPadroes_2
{
    abstract class KitPromocao : IProduto
    {
        public abstract Produto Produto { get; }
        public abstract double Preco { get; }
        List<IProduto> produtos { get; }
    }
}
