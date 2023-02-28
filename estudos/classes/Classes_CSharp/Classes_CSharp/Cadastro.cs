using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Cadastro
    {
        public Int32 cod;
        public string nome;
        public string sobreNome;
        public string eMail;

        public void nomeCompleto(){
           string nomeFUll = this.nome + ' ' + this.sobreNome;
        }
    }
}
