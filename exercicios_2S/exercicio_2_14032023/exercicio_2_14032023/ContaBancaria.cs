using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2_14032023
{
    internal class ContaBancaria
    {
        public string nomeTitular;
        public int numeroConta;
        public double saldo;
        public string statusOperacao;


        public void depositar(double deposito)
        {
            this.saldo += deposito;
        }

        public void Sacar(double retirada)
        {
            if(retirada < this.saldo)
            {
                this.saldo -= retirada;
                this.statusOperacao = "true";
            }else
            {
                this.statusOperacao = "false";
            }
        }
    }
}
