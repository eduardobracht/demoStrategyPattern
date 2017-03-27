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

        public Produto(int umCodigo, string umaDescricao, int umaQuantidade, double umPreco)
        {
            codigo = umCodigo;
            descricao = umaDescricao;
            quantidade = umaQuantidade;
            preco = umPreco;
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

        Produto IProduto.Produto
        {
            get
            {
                return this;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"[codigo={Codigo}, descricao={Descricao}, quantidade={Quantidade}, preco={Preco}, categoria={Categoria}]";
        }
    }
}
