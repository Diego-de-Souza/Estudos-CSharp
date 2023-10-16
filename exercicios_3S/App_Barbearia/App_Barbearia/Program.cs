using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Barbearia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um salão de beleza
            SalaoDeBeleza salao = new SalaoDeBeleza();

            // Adicionando barbeiros
            Barbeiro barbeiro1 = new Barbeiro ("João", "Corte de Cabelo" );
            Barbeiro barbeiro2 = new Barbeiro ("Maria", "Barba");

            salao.AdicionarBarbeiro(barbeiro1);
            salao.AdicionarBarbeiro(barbeiro2);

            // Adicionando clientes
            Cliente cliente1 = new Cliente { Nome = "Carlos", Telefone = "123456789", ServicoDesejado = "Corte de Cabelo" };
            Cliente cliente2 = new Cliente { Nome = "Ana", Telefone = "987654321", ServicoDesejado = "Barba" };

            salao.AdicionarCliente(cliente1);
            salao.AdicionarCliente(cliente2);


            // Atendendo clientes
            salao.AtenderClientes();

            Console.ReadKey();
        }
    }


}

