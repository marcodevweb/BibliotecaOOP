public interface IEmprestavel
{
    void Emprestar(Usuario usuario);
    void Devolver();
}

public interface IPesquisavel
{
    Livro PesquisarPorTitulo(string titulo);
    Livro PesquisarPorAutor(string autor);
    Livro PesquisarPorGenero(string genero);
}
