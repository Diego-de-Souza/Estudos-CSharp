using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Barbearia
{
    class Barbeiro
    {
        private string nome { get; set; }
        private string especialidade { get; set; }
        
        //construtor
        public Barbeiro(string nome, string especialidade)
        {
            this.nome = nome;
            this.especialidade = especialidade;
        }
        
        // Método getter para obter o valor do atributo privado
        public string GetNome()
        {
            return nome;
        }
        // Método setter para definir o valor do atributo privado
        public void SetNome(string novoNome)
        {
            nome = novoNome;
        }
        // Método getter para obter o valor do atributo privado
        public string GetEspecialidade()
        {
            return especialidade;
        }
        // Método setter para definir o valor do atributo privado
        public void SetEspecialidade(string novaEspecialidade)
        {
            especialidade = novaEspecialidade;
        }

        public void RealizarServico(Cliente cliente)
        {
            Console.WriteLine($"{Nome} está realizando o serviço de {cliente.ServicoDesejado} para o cliente {cliente.Nome}.");
        }
    }
}
