using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisaoPadroes_2
{
    interface IProduto
    {
        int Codigo { get; }
        double Preco { get; set; }
    }
}
