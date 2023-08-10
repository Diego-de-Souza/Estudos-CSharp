using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeOO_R_app_online_console
{
    class Produtos
    {
        public string nomeProduto { get; set; }
        public decimal valorProduto { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }

        public Produtos(string nomeProduto,  string descricao, string marca, decimal valorProduto)
        {
            this.nomeProduto = nomeProduto;
            this.valorProduto = valorProduto;
            this.descricao = descricao;
            this.marca = marca;
        }

        public void imprimeLista(int numeroitem)
        {
            Console.WriteLine($"Item:{numeroitem} - Produto: " + this.nomeProduto
                                  + "/ Descrição: " + this.descricao
                                  + "/ Marca: " + this.marca
                                  + "/ valor: " + this.valorProduto + "\n");
        }
    }
}
