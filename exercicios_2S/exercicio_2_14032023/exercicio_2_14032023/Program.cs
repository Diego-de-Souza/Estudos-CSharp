using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2_14032023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicia um objeto vetor para guardar sa informações do aluno
            ContaBancaria[] contaBanco = new ContaBancaria[3];
            //gerando um objeto de numero randomico
            Random rnd = new Random();

            for (int dep = 0; dep <= 2; dep++)
            {
                contaBanco[dep].depositar(rnd.Next(1, 1000));
                contaBanco[dep].nomeTitular = "Cliente " + dep;
                contaBanco[dep].numeroConta = 000020320 + dep;
            }

            do
            {
                
            } while (contaBanco[0].saldo > 0 || contaBanco[1].saldo > 0 || contaBanco[2].saldo > 0);
        }
    }
}
