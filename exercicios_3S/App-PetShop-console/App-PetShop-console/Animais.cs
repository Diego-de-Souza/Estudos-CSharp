using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PetShop_console
{
    class Animais
    {
        //declaração dos atributos
        private string Nome;
        private string Especie;
        private DateTime DataNasc;
        private string Raca;
        private float Peso;


        //criação dos métodos
        //metodo de cadastro dos animais
        public void Cadastrar()
        {
            Console.WriteLine("Inserir nome do animal: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Inserir a especie do animal: ");
            this.Especie = Console.ReadLine();
            Console.WriteLine("Inserir a data de nascimento do animal: ");
            this.DataNasc = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Inserir a raça do animal: ");
            this.Raca = Console.ReadLine();
            Console.WriteLine("Inserir o peso do animal: ");
            this.Peso = float.Parse(Console.ReadLine());
        }
        //metodo que exclui os dados dos animais
        public void Excluir()
        {
            this.Nome = null;
            this.Especie = null;
            this.DataNasc = DateTime.MinValue;
            this.Raca = null;
            this.Peso = 0;
            //Método para excluir os dados do animal
        }
        
        public void Alterar() { 
            //Método para alterar dados no animal
            Console.WriteLine("---> Alteração de Cadastro do Animal <---");
            Console.Write("Nome: ");
            this.Nome = Console.ReadLine();

            Console.Write("Digite a espécie: ");
            this.Especie = Console.ReadLine();

            Console.Write("Digite a raça: ");
            this.Raca = Console.ReadLine();

            Console.Write("Digite a data de nascimento. \n Formato: dd/mm/aaaa");
            this.DataNasc = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite o peso: ");
            this.Peso = float.Parse(Console.ReadLine());
        }
        //metodo de consulta de dados do animal
        public void Consultar()
        {
            //método para consulta os dados
            Console.WriteLine("---> Consultar dados do animal <---");

            do
            {
                Console.WriteLine("Informe o nome do animal para consultar dados: ");
                string consultaAnimal = Console.ReadLine().ToUpper();

                if (consultaAnimal == Nome.ToUpper())
                {
                    Console.WriteLine("Dados encontrados:");
                    Console.WriteLine("Nome: " + this.Nome);
                    Console.WriteLine("Data de Nascimento: " + this.DataNasc);
                    Console.WriteLine($"Espécie: {this.Especie}");
                    Console.WriteLine("Raça: " + this.Raca);
                    Console.WriteLine("Peso: " + this.Peso);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Nenhum animal cadastrado.");
                }
            }while(true);
        }
    }
}
