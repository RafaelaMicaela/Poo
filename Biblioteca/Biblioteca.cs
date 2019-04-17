using System;
using System.Collections.Generic;

namespace Biblioteca{
    class Biblioteca{
        private List<Livro> livros = new List<Livro>();

        public void Inserir(Livro livro){
            this.livros.Add(livro);
        }
        public List<Livro> Listar(){
            return this.livros;
        }
    }
}