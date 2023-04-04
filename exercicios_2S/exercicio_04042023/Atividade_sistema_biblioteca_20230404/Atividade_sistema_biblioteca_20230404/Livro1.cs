using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_sistema_biblioteca_20230404
{
    internal class Livro
    {
        /// <summary>
        /// Classe livro criada para atividade de desenvolvimento de biblioteca
        /// </summary>
        
        //declaração de atributos
        public string titulo;
        public string autor;
        public bool disponibilidade;

        public Livro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        //metodo que identifica se o livro está ou não emprestado
        public void Emprestar(string emprestimo)
        {
            if(emprestimo == "esprestado")
            {
                this.disponibilidade = true;
            }else
            {
                this.disponibilidade = false;
            }
        }

        //metodo que identifica de o livro está ou não devolvido
        public void Devolver(string devolucao)
        {
            if(devolucao == "devolvido")
            {
                this.disponibilidade = true;
            } else
            {
                this.disponibilidade= false;
            }
        }

        //metodo que chama as informações de mostra para o usuário
        public void MostrarInformacoes(string informacoes)
        {

        }

    }
}
