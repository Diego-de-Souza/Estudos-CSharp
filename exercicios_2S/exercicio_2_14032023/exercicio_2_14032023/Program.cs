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
            //Criando um vetor de objetos de classe
            ContaBancaria[] contaBanco = new ContaBancaria[2];
            string nome;
            int conta;
            Random rnd = new Random();


            for (int i = 0; i < contaBanco.Length; i++)
            {
                nome = "cliente"+i;
                conta = 2025125+i;
                ContaBancaria proxConta = new ContaBancaria(nome, conta);
                contaBanco[i] = proxConta;
            }
            do
            {
                for (int sac = 1; sac < 3; sac++)
                {
                    contaBanco[(sac - 1)].Sacar(rnd.Next(1, 500));
                }
            } while (contaBanco[0].saldo > contaBanco[0].Sacar || contaBanco[1].saldo > contaBanco[1].Sacar || contaBanco[2].saldo > contaBanco[1].Sacar);

            for (int resultado = 1; resultado < 3; resultado++)
            {
                Console.WriteLine($"Titular da conta: {contaBanco[(resultado - 1)].nomeTitular}");
                Console.WriteLine($"Número da Conta: {contaBanco[(resultado - 1)].numeroConta}");
                Console.WriteLine($"Saldo: {contaBanco[(resultado - 1)].saldo}");
            }


            Console.ReadKey();
        }
    }
}
