using System;

namespace GerenciamentoBiblioteca
{
    public class Livro : ItemBiblioteca
    {
    public bool Disponivel { get; private set; } = true;

    public Livro(int id, string titulo, string autor, int anoPublicacao)
        : base(id, titulo, autor, anoPublicacao) { }

    public void EmprestarLivro()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine($"Livro '{Titulo}' emprestado com sucesso!");
        }
        else
        {
            Console.WriteLine($"Livro '{Titulo}' já está emprestado.");
        }
    }

    public void DevolverLivro()
    {
        Disponivel = true;
        Console.WriteLine($"Livro '{Titulo}' devolvido com sucesso!");
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Livro: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}, Disponível: {Disponivel}");
    }
}
}