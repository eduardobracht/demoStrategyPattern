using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisaoPadroes_2
{
    public class Usuario
    {
        private int identificador;
        private string nome;
        private DateTime dataNascimento;
        private int numeroDependentes;
        
        public Usuario(int umIdentificador, string umNome, DateTime umaData, int umNumero)
        {
            identificador = umIdentificador;
            nome = umNome;
            dataNascimento = umaData;
            numeroDependentes = umNumero;
        }

        public int Identificador
        {
            get { return identificador; }
        }

        public string Nome
        {
            get { return nome; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
        }

        public int NumeroDependentes
        {
            get { return numeroDependentes; }
            set { numeroDependentes = value; }
        }

        public override string ToString()
        {
            return base.ToString()+$"[identificador={Identificador}, nome={Nome}, dataNascimento={DataNascimento:dd/MM/yyyy}, numeroDependentes={NumeroDependentes}]";
        }
    }
}
