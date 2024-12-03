using System;

namespace GerenciamentoBiblioteca
{
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
        Console.WriteLine($"Revista: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}, Edição: {Edicao}");
    }
    }
}