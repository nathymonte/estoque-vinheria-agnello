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
                    break;
                case "2":
                    ConsultarEstoque();
                    break;
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
        Console.WriteLine();
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Tipo: ");
        string tipo = Console.ReadLine();
        Console.WriteLine("Safra: ");
        string safra = Console.ReadLine();
        Console.WriteLine("País");
        string pais = Console.ReadLine();
        Console.WriteLine("Preço de venda: ");
        decimal precoVenda = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());
        Produto produto = new Produto(nome,tipo,safra,pais,precoVenda,quantidade);
        produtos.Add(produto);
        Console.WriteLine("Vinho cadastrado com sucesso!");
    }

    static void ConsultarEstoque()
    {
        Console.WriteLine();
        Console.WriteLine("Nome do vinho para consultar estoque: ");
        string nome = Console.ReadLine();
        bool encontrado = false;

        foreach (Produto produto in produtos)
        {
            if (produto.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Estoque de'{produto.Nome}': {produto.Quantidade} unidade");
                encontrado = true;
            }

        }
        if (!encontrado)
        {
            Console.WriteLine("Vinho não encontrado no estoque");
        }

    }

    static void RegistrarEntrada()
    {
        Console.WriteLine("Digite o nome do vinho para registrar entrada de estoque: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        foreach (Produto produto in produtos)
        {
            if (produto.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Quantidade para adicionar: ");
                int quantidade = int.Parse(Console.ReadLine());
                produto.Quantidade = produto.Quantidade + quantidade;
                Console.WriteLine($"Entrada registrada com sucesso. Novo estoque de'{produto.Nome}': {produto.Quantidade} unidade");
                encontrado = true;
            }

        }
        if (!encontrado)
        {
            Console.WriteLine("Vinho não encontrado no estoque");
        }


    }

    static void RegistrarSaida()
    {
        Console.WriteLine("Digite o nome do vinho para registrar saída de estoque: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        foreach (Produto produto in produtos)
        {
            if (produto.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Quantidade para retirar: ");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade <= produto.Quantidade) {
                    produto.Quantidade -= quantidade;
                    Console.WriteLine($"Sa ída registrada com sucesso. Novo estoque de'{produto.Nome}': {produto.Quantidade} unidade");                    
                }
                else
                {
                    Console.WriteLine($"Erro: saída maior que o estoque atual: {produto.Quantidade}");
                }
                encontrado = true;
                break;
            }

        }
        if (!encontrado)
        {
            Console.WriteLine("Vinho não encontrado no estoque");
        }
    }
}
