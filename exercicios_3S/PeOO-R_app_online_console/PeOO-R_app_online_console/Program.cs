using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeOO_R_app_online_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe cliente para receber os dados de login
            Cliente dadosClientes = new Cliente();
            //declaração da lista de produtos e seus dados
            Produtos[] listaProdutos = new Produtos[3];
            //criação dos produtos da lista manual
            string[] nomeProduto = new string[3] { "notebook", "televisão", "celular" };
            string[] marca = new string[3] { "Asus", "Samsung", "Asus" };
            string[] descricaoP = new string[3] { "intel Core, 8Gb RAM, 512Gb, preto", "QLed, Smart, preto", "Max pro M1, 8Gb RAM, 128Gb, azul" };
            decimal[] valorP = { 3200.00M, 5200.00M, 2800.20M };
            
            //inserindo os valores dentro do array de classe
            for(int d=0; d < listaProdutos.Length; d++)
            {
                Produtos descricaoProdutos = new Produtos(nomeProduto[d],descricaoP[d],marca[d],valorP[d]);

                listaProdutos[d] = descricaoProdutos;
            }

            //tela inicial do app online, com solicitação
            //do login e senha do usuário
            Console.WriteLine("========================== APP online PeOO-R ==========================\n\n");
            //solicitação do login do usuario
            Console.WriteLine("Digite o usuário: ");
            dadosClientes.nomeUsuario = Console.ReadLine();
            //solicitação da senha do usuario
            Console.WriteLine("Digite a senha: ");
            dadosClientes.senhaUsuario = Console.ReadLine();

            //limpa a tela inicial e começa a exibição da segunda tela
            Console.Clear();
            Console.WriteLine("========================== APP online PeOO-R ==========================\n");
            Console.WriteLine($"cliente: {dadosClientes.nomeUsuario}\n");
            Console.WriteLine("========================== produtos ==========================\n");
            //imprime na tela a lista de produtos
            for(int i=0; i < listaProdutos.Length; i++) {
                listaProdutos[i].imprimeLista(i);
            }

            //cria uma lista para alocar os pedidos do carrinho
            int[] numeroItem = new int[3];
            //solicita o produto que será inserido no carrinho
            Console.WriteLine("Digite o numero do item que deseja colocar no carrinho: ");
            numeroItem[0] = Convert.ToInt32(Console.ReadLine());

            //cria a quantidade maxima de itens no carrinho
            int numeroItens = 0;
            //laço de confirmação de dados para carrinho
            while (numeroItens <= 1)
            {
                //pergunta se deseja incluir um novo produto
                Console.WriteLine("Deseja incluir outro produto? (s/n)");
                string novoProd = Console.ReadLine();
                //laço condicional que vai confirmar se vai ser inserido um novo produto no carrinho
                if(novoProd == "s" || novoProd == "S")
                {
                    
                    numeroItens += 1;
                    Console.WriteLine("Digite o numero do próximo item a ser inserido no carrinho: ");
                    numeroItem[numeroItens] = Convert.ToInt32(Console.ReadLine());
                    //laço condicional que verifica se o produto jánão foi incluido no carrinho
                    if(numeroItem[numeroItens] == numeroItem[0] || numeroItem[numeroItens] == numeroItem[1] || numeroItem[numeroItens] == numeroItem[2])
                    {
                        Console.WriteLine("Este item já fio incluido no carrinho, digite outro!");
                    }
                    numeroItens -= 1;
                }else if(novoProd == "n" || novoProd == "N")
                {
                    numeroItens = 2;
                }
                else
                {
                    Console.WriteLine("resposta não confere com a solicitada, tente novamente.");
                }
            }
            CarrinhoDeCompras carrinhoC = new CarrinhoDeCompras(numeroItem[0], numeroItem[1], numeroItem[2]);
            carrinhoC.calculoCompras(listaProdutos[numeroItem[0]].valorProduto, listaProdutos[numeroItem[1]].valorProduto, listaProdutos[numeroItem[2]].valorProduto);
            
            //limpa a tela para abertura do carrinho de compras
            Console.Clear();
            Console.WriteLine("========================== APP online PeOO-R ==========================\n");
            Console.WriteLine($"cliente: {dadosClientes.nomeUsuario}\n");
            Console.WriteLine("========================== Carrinho de compras ==========================\n");

            carrinhoC.itensDaNota(listaProdutos[numeroItem[0]].nomeProduto, listaProdutos[numeroItem[1]].nomeProduto, listaProdutos[numeroItem[2]].nomeProduto);

            Console.ReadKey();
        }
    }
}
