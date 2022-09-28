using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace work_strings
{
    class Program
    {
        static void Main(string[] args)
        {   
            //declarando a variavel string e imprimindo
            string primeiraExpressão = "     Hello World!     ";
            Console.WriteLine($"{primeiraExpressão}");
           

            //declarando e imprimindo segunda váriavel com a método "trimStart" que apaga os espaços em branco antes do conjunto de caracteres 
            string segundaExpressão = primeiraExpressão.TrimStart();
            Console.WriteLine($"{segundaExpressão}");

            //declarando a terceira variavel com o método "trimEnd" que apaga os espaços em branco após o conjunto de caracteres
            string terceiraExpressão = primeiraExpressão.TrimEnd();
            Console.WriteLine($"{terceiraExpressão}");

            //declarando e imprimindo a quarta váriavel com o método "trim" que apaga os espaços
            string quartaExpressão = primeiraExpressão.Trim();
            Console.WriteLine($"{quartaExpressão}");
            Console.WriteLine(quartaExpressão[7]);

            string quintaExpressão = Regex.Replace(primeiraExpressão, @"\s", "");
            Int16 contagem;
            
            for (contagem = 0; contagem < quintaExpressão.Length; contagem++)
            {
                Console.Write($"{quintaExpressão[contagem]} -");
            };


            Console.WriteLine($"{primeiraExpressão.Length}");
            Console.WriteLine($"{quintaExpressão.Length}");

            Console.ReadKey();
        }
    }
}
