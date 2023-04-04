using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_sistema_biblioteca_20230404
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Este programa é um sistema de Biblioteca, tem como função
            /// o controle dos livros da biblioteca.
            /// </summary>

            //declara as variáveis de entrada
            string nomeLivro, autorLivro, contInsercaoLivro="S";
            Livro[] listaDeLivros = new Livro[100];


            //solicita ao usuário o nome do livro a ser procurado
            while(contInsercaoLivro == "S") { 
            Console.WriteLine("Digite o nome do livro ");
            nomeLivro = Console.ReadLine();
            Console.WriteLine("Qual o autor do livro? ");
            autorLivro = Console.ReadLine();

            //insere as informações na lista
            livrosBiblioteca.Add(new Livro(nomeLivro, autorLivro));
            
            Console.WriteLine("Deseja cadastrar outro livro? (S/N)");
            contInsercaoLivro = Console.ReadLine().ToUpper();
            }

            Console.WriteLine(livrosBiblioteca.);



            Console.ReadKey();
        }
    }
}
