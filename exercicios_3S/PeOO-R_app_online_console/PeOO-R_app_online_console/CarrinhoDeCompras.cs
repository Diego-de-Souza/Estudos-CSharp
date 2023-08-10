using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeOO_R_app_online_console
{
    class CarrinhoDeCompras
    {
        public int item1;
        public int item2;
        public int item3;
        public decimal valorItem1;
        public decimal valorItem2;
        public decimal valorItem3;
        public decimal totalCarrinho;

        public CarrinhoDeCompras(int item1, int item2, int item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public void calculoCompras(decimal valor1, decimal valor2, decimal valor3)
        {
            if(item1 != null || item2 != null || item3 != null)
            {
                this.totalCarrinho = valor1 + valor2 + valor3;
            }else if (item1 != null || item2 != null || item3 == null)
            {
                this.totalCarrinho = valor1 + valor2;
            }else if(item1 != null || item2 != null || item3 == null)
            {
                this.totalCarrinho = valor1;
            }
            this.valorItem1 = valor1;
            this.valorItem2 = valor2;
            this.valorItem3 = valor3;
        }

        public void itensDaNota(string produtonota1, string produtonota2, string produtonota3)
        {
            if (item1 != null || item2 != null || item3 != null)
            {
                Console.WriteLine($"item1: {this.valorItem1} - {produtonota1}");
                Console.WriteLine($"item2: {this.valorItem2} - {produtonota2}");
                Console.WriteLine($"item3: {this.valorItem2} - {produtonota3}");
                Console.WriteLine($"Total: {this.totalCarrinho}");
            }
            else if (item1 != null || item2 != null || item3 == null)
            {
                Console.WriteLine($"item1: {this.valorItem1} - {produtonota1}");
                Console.WriteLine($"item2: {this.valorItem2} - {produtonota2}");
                Console.WriteLine($"Total: {this.totalCarrinho}");
            }
            else if (item1 != null || item2 != null || item3 == null)
            {
                Console.WriteLine($"item1: {this.valorItem1} - {produtonota1}");
                Console.WriteLine($"Total: {this.totalCarrinho}");
            }
        }
    }
}
