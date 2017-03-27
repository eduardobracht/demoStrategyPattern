using ExercicioRevisaoPadroes_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaConsole
{
    class Program1
    {
        public static void Main()
        {
            List<IProduto> kitList = new List<Produto>();
            Produto refri = new Produto(1, "Coca", 1, 5);
            Produto pipoca = new Produto(1, "Pipoca", 1, 10);
            Produto ingresso = new Produto(1, "Ingresso", 1, 25);

            kitList.Add(refri);
            kitList.Add(pipoca);
            kitList.Add(ingresso);

            KitPascoa kit = new KitPascoa(kitList);

            Console.WriteLine("Preço Refri: " + refri.Preco);
            Console.WriteLine("Preço Pipoca: " + pipoca.Preco);
            Console.WriteLine("Preço Ingresso: " + ingresso.Preco);
            Console.WriteLine("Preço Total: " + (refri.Preco + pipoca.Preco + ingresso.Preco));
            Console.WriteLine("Valor com desconto: " + kit.Preco);

        }
    }
}
