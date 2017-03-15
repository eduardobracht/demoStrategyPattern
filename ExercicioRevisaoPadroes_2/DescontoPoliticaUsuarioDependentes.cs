using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisaoPadroes_2
{
    public class DescontoPoliticaUsuarioDependentes
    {
        private IList<Categoria> categoriasSemDescontos;
        public DescontoPoliticaUsuarioDependentes(IList<Categoria> listaSemDescontos)
        {
            categoriasSemDescontos = listaSemDescontos;
        }
        public double CalcularDesconto(Produto umProduto, Usuario umUsuario, double umValor)
        {
            if (umUsuario.NumeroDependentes > 3 && !categoriasSemDescontos.Contains(umProduto.Categoria))
            {
                return umValor*0.50;
            }
            else
            {
                return 0.0;
            }
        }
    }
}
