using System;
using GerenciamentoBiblioteca;

class Program
{
    // Inicializa a biblioteca
    static Biblioteca biblioteca = new Biblioteca();

    static void Main()
    {
        // Menu do sistema de Gerenciamento de Biblioteca
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Adicionar Revista");
            Console.WriteLine("3. Listar Itens");
            Console.WriteLine("4. Buscar por Título");
            Console.WriteLine("5. Buscar por Autor");
            Console.WriteLine("6. Emprestar Livro");
            Console.WriteLine("7. Devolver Livro");
            Console.WriteLine("8. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarLivro();
                    break;
                case "2":
                    AdicionarRevista();
                    break;
                case "3":
                    biblioteca.ListarItens();
                    break;
                case "4":
                    BuscarPorTitulo();
                    break;
                case "5":
                    BuscarPorAutor();
                    break;
                case "6":
                    EmprestarLivro();
                    break;
                case "7":
                    DevolverLivro();
                    break;
                case "8":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void AdicionarLivro()
    {
        // Adicionar um livro
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        Console.Write("Autor: ");
        string autor = Console.ReadLine();
        Console.Write("Ano de Publicação: ");
        int ano = int.Parse(Console.ReadLine());
        biblioteca.AdicionarItem(new Livro(biblioteca.Count + 1, titulo, autor, ano));
    }

    static void AdicionarRevista()
    {
        // Adicionar uma revista
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        Console.Write("Autor: ");
        string autor = Console.ReadLine();
        Console.Write("Ano de Publicação: ");
        int ano = int.Parse(Console.ReadLine());
        Console.Write("Edição: ");
        int edicao = int.Parse(Console.ReadLine());
        biblioteca.AdicionarItem(new Revista(biblioteca.Count + 1, titulo, autor, ano, edicao));
    }

    static void BuscarPorTitulo()
    {
        // Buscar por título
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        biblioteca.BuscarPorTitulo(titulo);
    }

    static void BuscarPorAutor()
    {
        // Buscar por autor
        Console.Write("Autor: ");
        string autor = Console.ReadLine();
        biblioteca.BuscarPorAutor(autor);
    }

    static void EmprestarLivro()
    {
        // Emprestar um livro
        Console.Write("Título do Livro: ");
        string titulo = Console.ReadLine();
        var livro = biblioteca.FindByTitle(titulo) as Livro;
        
        if (livro != null)
        {
            livro.EmprestarLivro(); // Chama o método se o livro for encontrado
        }
        else
        {
            Console.WriteLine("Livro não encontrado ou inválido."); // Mensagem de erro se o livro não for encontrado
        }
    }

    static void DevolverLivro()
    {
        // Devolver um livro
        Console.Write("Título do Livro: ");
        string titulo = Console.ReadLine();
        var livro = biblioteca.FindByTitle(titulo) as Livro;
        
        if (livro != null)
        {
            livro.DevolverLivro(); // Chama o método se o livro for encontrado
        }
        else
        {
            Console.WriteLine("Livro não encontrado ou inválido."); // Mensagem de erro se o livro não for encontrado
        }
    }
}
