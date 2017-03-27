using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisaoPadroes_2
{
    public class Produto : IProduto
    {
        private int codigo;
        private string descricao;
        private int quantidade;
        private double preco;
        private Categoria categoria;

        public Produto(int umCodigo, string umaDescricao, int umaQuantidade, double umPreco, Categoria umaCategoria)
        {
            codigo = umCodigo;
            descricao = umaDescricao;
            quantidade = umaQuantidade;
            preco = umPreco;
            categoria = umaCategoria;
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public Categoria Categoria
        {
            get { return categoria; }
        }

        public override string ToString()
        {
            return base.ToString() + $"[codigo={Codigo}, descricao={Descricao}, quantidade={Quantidade}, preco={Preco}, categoria={Categoria}]";
        }
    }
}
