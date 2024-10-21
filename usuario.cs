public class Usuario
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }
    public List<Livro> HistoricoEmprestimos { get; set; }

    public Usuario()
    {
        HistoricoEmprestimos = new List<Livro>();
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, ID: {NumeroIdentificacao}, Contato: {Contato}");
    }

    public void ExibirHistorico()
    {
        Console.WriteLine($"Histórico de Empréstimos de {Nome}:");
        foreach (var livro in HistoricoEmprestimos)
        {
            Console.WriteLine($"- {livro.Titulo} ({livro.ISBN})");
        }
    }
}
