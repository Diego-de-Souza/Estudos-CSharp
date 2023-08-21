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
            this.Nome = "";
            this.Especie = "";
            this.DataNasc = DateTime.UtcNow;
        }
        public void LimparDados()
        {

        }
        public void Alterar() { 
        
        }
        //metodo de consulta de dados do animal
        public void Consultar()
        {
            Console.WriteLine("---> Consultar dados do animal <---");

            //cria um menu para escolher qual item para fazer a consulta
            Console.WriteLine("Informe a opção para consultar dados do animal: ");
            string consultaAnimal = Console.ReadLine();

            if(consultaAnimal.ToUpper() == this.Nome.ToUpper()) {
                Console.WriteLine("Nome: ",Nome);
                Console.WriteLine("Data de Nascimento: ",DataNasc);
                Console.WriteLine($"Especie: {Especie}");
                Console.WriteLine("Raça: "+Raca);
                Console.WriteLine("Peso: ",Peso);
            }
            else
            {
                Console.WriteLine("errado");
            }
        }
    }
}
