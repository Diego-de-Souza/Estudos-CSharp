using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_sistema_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Este é um sistema de biblioteca desenvolvido como atividade
            ///da materia de algoritmo
            /// </summary>

            //declaração de variaveis iniciais
            string usuarioLogin, senhaLogin;
            bool controle = true;
            //declaração do array de login
            string[] listaLogin = new string[3];
            listaLogin[0] = "admin";
            listaLogin[1] = "user";
            listaLogin[2] = "agent";
            //declaração do array de senha
            string[] listaSenha = new string[3];
            listaSenha[0] = "admin123";
            listaSenha[1] = "user123";
            listaSenha[2] = "agent123";
            //declaração do array de livro para serrem cadastrados
            //inicialmente vamos usar o array com 100 posições, mais para frente 
            //podemos implementar outra forma.
            Livro[] livros = new Livro[100];
            string nomeLivro, nomeAutor, nomeEditora, volumeLivro;
            int id;
            Int32 numQuantCadastro = 1;
        //

        //laço de repetição para login, caso a senha esteje errada
        //continua voltando a solicitação de login e senha
        labelMenuPrincipal:
            while (controle == true)
            {

                Console.WriteLine("Digite seu usuario: ");
                usuarioLogin = Console.ReadLine().ToLower();
                Console.WriteLine("Digite sua senha: ");
                senhaLogin = Console.ReadLine().ToLower();

                //laço condicional que identifica o login e senha 
                //identifica qual usuario está logado
                if (usuarioLogin == listaLogin[0] && senhaLogin == listaSenha[0])
                {
                    goto labelAdmin;
                    controle = false;
                }
                else if (usuarioLogin == listaLogin[1] && senhaLogin == listaSenha[1])
                {
                    goto labelUser;
                    controle = false;
                }
                else if (usuarioLogin == listaLogin[2] && senhaLogin == listaSenha[2])
                {
                    controle = false;
                }
                else
                {
                    controle = true;
                    Console.Clear();
                    Console.WriteLine("Login ou senha incorreta!");

                }
            }



        labelAdmin:
            Console.Clear();
            string quantCadastro = "n";
            

            for (int cadastro = 0; cadastro < numQuantCadastro; cadastro++)
            {
                Console.WriteLine("Digite o nome do Livro: ");
                nomeLivro = Console.ReadLine();
                Console.WriteLine("Digite o nome do Autor: ");
                nomeAutor = Console.ReadLine();
                Console.WriteLine("Digite o volume: ");
                volumeLivro = Console.ReadLine();
                Console.WriteLine("Digite o nome da Editora: ");
                nomeEditora = Console.ReadLine();

                id = 0000 + cadastro;

                Livro livroCadastro = new Livro(id, nomeLivro, nomeAutor, nomeEditora, volumeLivro);
                livros[cadastro] = livroCadastro;

                Console.WriteLine("Deseja cadastrar outro livro? (S/N)");
                quantCadastro = Console.ReadLine();
                if (quantCadastro == "s")
                {
                    numQuantCadastro++;
                }
                Console.Clear();


            }

            goto labelMenuPrincipal;

        labelUser:
            //comando limpa a tela para uma nova amostragem
            Console.Clear();
            //Solicita ao usuário que escolçha uma opção entre
            //esmprestimo, devolução e ver situação lilvro
            Console.WriteLine("Digite o número da opção abaixo que deseja Efetuar" +
                "\n1 - Pegar livro emprestado" +
                "\n2 - Devolver Livro" +
                "\n3 - Ver situação do Livro");
            Int16 escolhaOperacao = Convert.ToInt16(Console.ReadLine());
            Int32 testeVariavel = numQuantCadastro;
            Int16 idLivroEscolhido;
            string confirmaEmprestimo;
            //em função da esolha da operação o usuário agora escolhe como quer proceder
            if (escolhaOperacao == 1)
            {
                //Solicita ao usuário para escolha a forma com a qual ele
                //ele quer usar para fazer a busca do livro
                Console.WriteLine("digite o número da opção de como desejar procurar seu livro:" +
                    "\n1 - Pelo nome do livro" +
                    "\n2 - Pelo nome do autor" +
                    "\n3 - Pelo nome da editora");
                Int16 escolhaOperacaoEmprestimo = Convert.ToInt16(Console.ReadLine());
                

                if (escolhaOperacaoEmprestimo == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o nome do Livro: ");
                    string nomeDoLivroEmprestimo = Console.ReadLine();

                    Console.WriteLine("Lista de livros com o nome especificado: ");
                    //Laço de repetição que percorre a quantidade de livros cadastrados no armazenamento
                    for (int procurarTitulo = 0; procurarTitulo < numQuantCadastro; procurarTitulo++)
                    {

                        if ((livros[procurarTitulo].titulo).Contains(nomeDoLivroEmprestimo))
                        {
                            Console.WriteLine(livros[procurarTitulo].MostrarInformacoes());
                        }else
                        {
                            Console.WriteLine("Não foi encontrado nenhum resultado!.");
                        }
                    }
                    
                    Console.WriteLine("\nDigite o Id o livro que deseja pegar emprestado: ");
                    idLivroEscolhido = Convert.ToInt16(Console.ReadLine() );
                    Console.WriteLine("Confirma o emprestimo? (s/n)");
                    confirmaEmprestimo = Console.ReadLine().ToLower() ;
                    livros[idLivroEscolhido].Emprestar(confirmaEmprestimo);
                    Console.WriteLine("\nVocê acaba de confirmar o emprestimo do livro com dados abaixo: \n{0}", livros[idLivroEscolhido].MostrarInformacoes());

                }
                else if (escolhaOperacaoEmprestimo == 2)
                {
                    Console.WriteLine("Digite o nome do autor do Livro: ");
                    string nomeDoAutorEmprestimoAutor = Console.ReadLine();

                    Console.WriteLine("Lista de livros com o nome do Autor especificado: ");
                    //Laço de repetição que percorre a quantidade de livros cadastrados no armazenamento
                    for (int procurarAutor = 0; procurarAutor < numQuantCadastro; procurarAutor++)
                    {

                        if ((livros[procurarAutor].autor).Contains(nomeDoAutorEmprestimoAutor))
                        {
                            Console.WriteLine(livros[procurarAutor].MostrarInformacoes());
                        }else
                        {
                            Console.WriteLine("Não foi encontrado nenhum resultado!.");
                        }
                    }

                    Console.WriteLine("\nDigite o Id o livro que deseja pegar emprestado: ");
                    idLivroEscolhido = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Confirma o emprestimo? (s/n)");
                    confirmaEmprestimo = Console.ReadLine().ToLower();
                    livros[idLivroEscolhido].Emprestar(confirmaEmprestimo);
                    Console.WriteLine("\nVocê acaba de confirmar o emprestimo do livro com dados abaixo: \n{0}", livros[idLivroEscolhido].MostrarInformacoes());

                }
                else if (escolhaOperacaoEmprestimo == 3)
                {
                    Console.WriteLine("Digite o nome da editora,: ");
                    string nomeEditoraEmprestimo = Console.ReadLine();

                    Console.WriteLine("Lista de livros com o nome da Editora especificada: ");
                    //Laço de repetição que percorre a quantidade de livros cadastrados no armazenamento
                    for (int procurarEditor = 0; procurarEditor < numQuantCadastro; procurarEditor++)
                    {

                        if ((livros[procurarEditor].autor).Contains(nomeEditoraEmprestimo))
                        {
                            Console.WriteLine(livros[procurarEditor].MostrarInformacoes());
                        }
                        else
                        {
                            Console.WriteLine("Não foi encontrado nenhum resultado!.");
                        }
                    }

                    Console.WriteLine("\nDigite o Id o livro que deseja pegar emprestado: ");
                    idLivroEscolhido = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Confirma o emprestimo? (s/n)");
                    confirmaEmprestimo = Console.ReadLine().ToLower();
                    livros[idLivroEscolhido].Emprestar(confirmaEmprestimo);
                    Console.WriteLine("\nVocê acaba de confirmar o emprestimo do livro com dados abaixo: \n{0}", livros[idLivroEscolhido].MostrarInformacoes());

                }
                else{
                    Console.WriteLine("Opção não é válida, tente novamente");
                }
            }
            else if (escolhaOperacao == 2)
            {
                Console.WriteLine("Deseja escolher por qual opção abaixo para devolução? " +
                    "\n1 - Nome do livro" +
                    "\n2 - Nome do Autor do livro" +
                    "\n3 - Nome da Editora"+
                    "Digite o número do indice: ");
                Int16 escolhaLivroDevolucao = Convert.ToInt16(Console.ReadLine());

                if(escolhaLivroDevolucao == 1)
                {
                    Console.Clear();

                }else if(escolhaLivroDevolucao == 2)
                {
                    Console.Clear();

                }
                else if(escolhaLivroDevolucao == 3)
                {
                    Console.Clear();

                }
            }
            else if (escolhaOperacao == 3)
            {

            }
            else
            {
                Console.WriteLine("Opção não é válida, tente novamente!");
            }

            goto labelMenuPrincipal;

            Console.WriteLine("Sua escolha foi " + escolhaOperacao);

        fimPrograma:
            Console.WriteLine("Obrigado e até a próxima!!!");

            Console.ReadKey();

        }


    }
}
