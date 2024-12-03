using System;

public abstract class ItemBiblioteca
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }

    public ItemBiblioteca(int id, string titulo, string autor, int anoPublicacao)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }

    public abstract void ExibirDetalhes();
}

public class Livro : ItemBiblioteca
{
    public bool Disponivel { get; set; }

    public Livro(int id, string titulo, string autor, int anoPublicacao) 
        : base(id, titulo, autor, anoPublicacao)
    {
        Disponivel = true;
    }

    public void EmprestarLivro()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine($"{Titulo} foi emprestado.");
        }
        else
        {
            Console.WriteLine($"{Titulo} já foi emprestado.");
        }
    }

    public void DevolverLivro()
    {
        if (!Disponivel)
        {
            Disponivel = true;
            Console.WriteLine($"{Titulo} foi devolvido.");
        }
        else
        {
            Console.WriteLine($"{Titulo} não foi emprestado.");
        }
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Livro: {Titulo} - {Autor} ({AnoPublicacao}) - {(Disponivel ? "Disponível" : "Indisponível")}");
    }
}

public class Revista : ItemBiblioteca
{
    public int Edicao { get; set; }

    public Revista(int id, string titulo, string autor, int anoPublicacao, int edicao)
        : base(id, titulo, autor, anoPublicacao)
    {
        Edicao = edicao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Revista: {Titulo} - {Autor} ({AnoPublicacao}) - Edição {Edicao}");
    }
}
