using System;

namespace Biblioteca
{
    class Livro
    {
        private string titulo, autor, genero;
        private int paginas;

        public int Paginas { get => paginas; set => paginas = value; }

        public void setTitulo(string titulo){
            this.titulo = titulo;
        }
        public void setAutor(string autor){
            this.autor = autor;
        }
        public void setGenero(string genero){
            this.genero = genero;
        }
        public void setPaginas(int paginas){
            this.Paginas = paginas;
        }
        public string getTitulo(){
            return this.titulo;
        }
        public string getAutor(){
            return this.autor;
        }
        public string getGenero(){
            return this.genero;
        }
        public int getPaginas(){
            return this.paginas;
        }

        public override string ToString() => $"Titulo = {this.titulo}\nAutor = {this.autor}\nPaginas = {this.paginas}\nGênero = {this.genero}";
    }
}