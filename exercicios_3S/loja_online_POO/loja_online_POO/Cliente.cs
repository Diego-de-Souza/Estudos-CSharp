using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_online_POO
{
    class Cliente
    {
        //declaração das váriaveis
        public string usuarioLogin { get; set; }
        public string senhaLogin { get; set; }
        public string login;
        public string password;
        public Boolean clienteAtivo = false;
        //declaração do construtor que inicia a classe definindo os valores para login
        public Cliente()
        {
            
        }

        //criação do metodo par armazenar dados iniciais do usuario
        public void DadosUsuarios(string login, string password)
        {
            this.login = login;
            this.password = password;
            this.clienteAtivo = true;
        }
        //criação do metodo para verificação do login e senha do usuario
        public void VerificaUsuario(string login, string password)
        {
            
        }
    }
}
