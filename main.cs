public class Program
{
    public static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        Livro livro1 = new Livro { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", ISBN = "123456", Genero = "Fantasia", QuantidadeEmEstoque = 5, Codigo = "001" };
        Usuario usuario1 = new Usuario { Nome = "João Silva", NumeroIdentificacao = "1001", Endereco = "Rua A", Contato = "joao@gmail.com" };

        biblioteca.CadastrarLivro(livro1);
        biblioteca.CadastrarUsuario(usuario1);

        biblioteca.ListarLivros();
        biblioteca.ListarUsuarios();

        biblioteca.EmprestarLivro("001", "1001");
        biblioteca.ListarLivros();

        biblioteca.DevolverLivro("001");
        biblioteca.ListarLivros();
    }
}
