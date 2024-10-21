public class Livro : ItemBiblioteca, IEmprestavel, IPesquisavel
{
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque--;
            Console.WriteLine($"{Titulo} foi emprestado para {usuario.Nome}.");
        }
        else
        {
            Console.WriteLine($"Sem exemplares disponíveis de {Titulo}.");
        }
    }

    public override void Devolver()
    {
        QuantidadeEmEstoque++;
        Console.WriteLine($"{Titulo} foi devolvido.");
    }

    public Livro PesquisarPorTitulo(string titulo)
    {
        return this.Titulo == titulo ? this : null;
    }

    public Livro PesquisarPorAutor(string autor)
    {
        return this.Autor == autor ? this : null;
    }

    public Livro PesquisarPorGenero(string genero)
    {
        return this.Genero == genero ? this : null;
    }
}
