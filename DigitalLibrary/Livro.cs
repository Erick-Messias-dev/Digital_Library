namespace DigitalLibrary;

internal abstract class Livro
{
    public Livro(string titulo, string autor, int anoPublicacao, int numeroPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        NumeroPaginas = numeroPaginas;
    }

    public string Titulo { get; }
    public string Autor { get; }
    public int AnoPublicacao { get; }
    public int NumeroPaginas { get; set; }

    public virtual void ExibirInformacao()
    {
        Console.WriteLine($"Titulo: {Titulo}\n" +
            $"Autor: {Autor}\n" +
            $"AnoPublicacao: {AnoPublicacao}\n" +
            $"Numero de páginas: {NumeroPaginas}");
    }
}
