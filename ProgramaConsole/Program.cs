using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioRevisaoPadroes_2;

namespace ProgramaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u1 = new Usuario(1, "John Doe", new DateTime(1980, 1, 10), 2);
            Console.WriteLine(u1);
        }
    }
}
