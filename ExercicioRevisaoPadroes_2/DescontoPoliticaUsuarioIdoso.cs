using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisaoPadroes_2
{
    public class DescontoPoliticaUsuarioIdoso : CalculadorDesconto
    {
        private IList<Categoria> categoriasSemDescontos;
        public DescontoPoliticaUsuarioIdoso(IList<Categoria> listaSemDescontos)
        {
            categoriasSemDescontos = listaSemDescontos;
        }

        public double CalcularDesconto(Produto umProduto, Usuario umUsuario, double umValor)
        {
            if(CalcularIdade(umUsuario.DataNascimento)>60 && !categoriasSemDescontos.Contains(umProduto.Categoria))
            {
                return umValor;
            }
            else
            {
                return 0.0;
            }
        }

        private static int CalcularIdade(DateTime dataNasc)
        {
            int anos = DateTime.Now.Year - dataNasc.Year;

            if ((dataNasc.Month > DateTime.Now.Month) || (dataNasc.Month == DateTime.Now.Month && dataNasc.Day > DateTime.Now.Day))
                anos--;

            return anos;
        }
    }
}
