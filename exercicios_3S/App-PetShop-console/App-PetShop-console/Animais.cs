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
        public void Excluir()
        {
            this.Nome = "";
            this.Especie = "";
            this.DataNasc = DateTime.UtcNow(0000, 0, 0, 0, 0, 0);
        }
        public void LimparDados()
        {

        }
        public void Alterar() { 
        
        }
    }
}
