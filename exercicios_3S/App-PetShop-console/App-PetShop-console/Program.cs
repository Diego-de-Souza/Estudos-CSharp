using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PetShop_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando objeto
            Animais animais = new Animais();
            bool continuar = true;

            while (continuar)
            {
                //Tela principal
                Console.WriteLine("---> Bem vindos ao PetShop da Villa <---");
                Console.WriteLine("Escolha a opção desejada: ");
                Console.WriteLine(
                    "1 - Cadastrar animal\n"+
                    "2 - Consultar animal\n"+
                    "3 - Alterar animal\n" +
                    "4 - Excluir animal\n"+
                    "5 - Sair do programa");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        animais.Cadastrar();
                        break;
                    case 2:
                        animais.Consultar();
                        break;
                    case 3:
                        animais.Alterar();
                        break;
                    case 4:
                        animais.Excluir();
                        break;
                    case 5:
                        Console.WriteLine("Obrigado por utilizar. Até logo!");
                        continuar=false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
