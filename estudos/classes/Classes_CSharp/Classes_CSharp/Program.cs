using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Cadastro cadastro = new Cadastro();

            Calculadora calc = new Calculadora();
            calc.inserirDados();
            calc.somar();
            calc.mostraResultado();

            Console.ReadKey();
        }
    }
}
