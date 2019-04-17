using System;
using System.Collections.Generic;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            int opcao;
            do{
                Console.WriteLine("1 - Inserir\n2 - Listar\n0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch(opcao){
                    case 1:
                        Livro livro = new Livro();
                        Console.WriteLine("Digite o título do livro");
                        livro.setTitulo(Console.ReadLine());
                        Console.WriteLine("Digite o nome do autor");
                        livro.setAutor(Console.ReadLine());
                        Console.WriteLine("Digite o gênero do livro");
                        livro.setGenero(Console.ReadLine());
                        Console.WriteLine("Digite o número de páginas");
                        livro.setPaginas(int.Parse(Console.ReadLine()));
                        biblioteca.Inserir(livro);
                    break;
                    case 2:
                        List<Livro> livros = biblioteca.Listar();
                        foreach (Livro item in livros)
                        {
                            Console.WriteLine(item.ToString());
                            Console.WriteLine("------------------------------");
                        }
                    break;
                    case 0: 
                        Console.WriteLine("ByeBye");
                    break;
                }
            }while(opcao!=0);
        }
    }
}
