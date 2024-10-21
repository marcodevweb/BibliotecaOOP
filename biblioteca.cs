public class Biblioteca
{
    public List<Livro> Livros { get; set; }
    public List<Usuario> Usuarios { get; set; }

    public Biblioteca()
    {
        Livros = new List<Livro>();
        Usuarios = new List<Usuario>();
    }

    public void CadastrarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"{livro.Titulo} cadastrado com sucesso.");
    }

    public void CadastrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuário {usuario.Nome} cadastrado com sucesso.");
    }

    public void ListarLivros()
    {
        Console.WriteLine("Livros disponíveis:");
        foreach (var livro in Livros)
        {
            Console.WriteLine($"- {livro.Titulo}, {livro.Autor} (Estoque: {livro.QuantidadeEmEstoque})");
        }
    }

    public void ListarUsuarios()
    {
        Console.WriteLine("Usuários cadastrados:");
        foreach (var usuario in Usuarios)
        {
            Console.WriteLine($"- {usuario.Nome} ({usuario.NumeroIdentificacao})");
        }
    }

    public void EmprestarLivro(string codigoLivro, string numeroUsuario)
    {
        var livro = Livros.FirstOrDefault(l => l.Codigo == codigoLivro);
        var usuario = Usuarios.FirstOrDefault(u => u.NumeroIdentificacao == numeroUsuario);

        if (livro != null && usuario != null)
        {
            livro.Emprestar(usuario);
            usuario.HistoricoEmprestimos.Add(livro);
        }
        else
        {
            Console.WriteLine("Livro ou usuário não encontrado.");
        }
    }

    public void DevolverLivro(string codigoLivro)
    {
        var livro = Livros.FirstOrDefault(l => l.Codigo == codigoLivro);
        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }
}
