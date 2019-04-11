using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{

    class Candidato : IComparable
    {
        private string nome;
        private DateTime nascimento;
        private int pontos;

        public int CompareTo(object obj)
        {
            Candidato X = obj as Candidato;
            if (this.pontos > X.pontos) return -1;
            if (this.pontos < X.pontos) return 1;
            return nascimento.CompareTo(X.nascimento);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
