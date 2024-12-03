using System;
using System.Collections.Generic;  // Adicione esta linha para usar List<T>

namespace GerenciamentoBiblioteca
{
    public class Biblioteca
    {
        private List<ItemBiblioteca> itens = new List<ItemBiblioteca>();  // Lista para armazenar os itens

        public void AdicionarItem(ItemBiblioteca item)
        {
            itens.Add(item);  // Adiciona o item à lista
            Console.WriteLine("Item adicionado!");
        }

        public void ListarItens()
        {
            foreach (var item in itens)
            {
                item.ExibirDetalhes();
            }
        }

        public ItemBiblioteca FindByTitle(string titulo)
        {
            return itens.Find(item => item.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        public void BuscarPorTitulo(string titulo)
        {
            var item = FindByTitle(titulo);
            if (item != null)
            {
                item.ExibirDetalhes();
            }
            else
            {
                Console.WriteLine("Item não encontrado!");
            }
        }

        public void BuscarPorAutor(string autor)
        {
            var itensPorAutor = itens.FindAll(item => item.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase));
            if (itensPorAutor.Count > 0)
            {
                foreach (var item in itensPorAutor)
                {
                    item.ExibirDetalhes();
                }
            }
            else
            {
                Console.WriteLine("Nenhum item encontrado para este autor.");
            }
        }

        public int Count => itens.Count;  // Propriedade Count para acessar o número de itens
    }
}
