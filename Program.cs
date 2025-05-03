// See https://aka.ms/new-console-template for more information

using System.Globalization;
using EstoqueVinheriaAgnello;
internal class Program
{
    static List<Produto> produtos = new List<Produto>();

    static void Main(string[] args)
    {
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n **** BEM VINDO AO SISTEMA DE ESTOQUE DA VINHERIA AGNELLO ****");
            Console.WriteLine("1. Cadastrar novo produto");
            Console.WriteLine("2. Consultar estoque");
            Console.WriteLine("3. Registrar entrada de estoque");
            Console.WriteLine("4. Registrar saída de estoque");
            Console.WriteLine("0. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarProduto();
                    break
                case "2":
                    ConsultarEstoque();
                    break
                case "3":
                    RegistrarEntrada();
                    break;
                case "4":
                    RegistrarSaida();
                    break;
                case "0":
                    executando = false;
                    Console.WriteLine("Finalizando...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente:");
                    break;

            }





        }

    }


    static void CadastrarProduto()
    {

    }

    static void ConsultarEstoque()
    {

    }

    static void RegistrarEntrada()
    {

    }

    static void RegistrarSaida()
    {

    }
}
