namespace DigitalLibrary;

internal abstract class Livro : IEmprestravel
{
    //Garantindo que não possam ser feitas mudanças fora da classe
    private string _titulo;
    private string _autor;
    private int _anoPublicacao;
    private int _numeroPaginas;
    private bool _emprestado;

    //Verificações para que os dados inseridos não sejam nulos, negativos ou em branco
    public string Titulo
    {
        get => _titulo;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O titulo não pode ser vazio");
            _titulo = value;
        }
    }
    public string Autor { 
        get => _autor;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O autor não pode ser vazio.");
            _autor = value;
        }
    }

    public int AnoPublicacao 
    {
        get => _anoPublicacao;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("O ano de publicação deve ser maior que 0");
            }
             _anoPublicacao = value;

        }
    }
    public int NumeroPaginas 
    {
        get => _numeroPaginas;
        private set
        {
            _numeroPaginas = value;
            if (value <= 0)
            {
                throw new ArgumentException("O numero de páginas ten que ser maior que 0");
            }
            _numeroPaginas = value;
        }
     }

    public bool Emprestado => _emprestado;

    public bool EstaEmprestado => throw new NotImplementedException();

    //Garantindo que ninguem com exceção as classes filhas consigam inicializar os campos
    protected Livro(string titulo, string autor, int anoPublicacao, int numeroPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        NumeroPaginas = numeroPaginas;
    }

    public virtual void ExibirInformacao()
    {
        Console.WriteLine($"Titulo: {Titulo}\n" +
            $"Autor: {Autor}\n" +
            $"AnoPublicacao: {AnoPublicacao}\n" +
            $"Numero de páginas: {NumeroPaginas}");
    }

    public void Emprestar()
    {
        if (_emprestado)
        {
            Console.WriteLine($"O Livro{Titulo} já esta emprestado");
        }
        else
        {
            _emprestado = true;
            Console.WriteLine($"Você emprestou {Titulo}");
        }
    }

    public void Devolver()
    {
        if (!_emprestado)
            Console.WriteLine($"O Livro{Titulo} não estava emprestado.");
        else
        {
            _emprestado = false;
            Console.WriteLine($"Você vevolveu {Titulo}");
        }
    }
}
