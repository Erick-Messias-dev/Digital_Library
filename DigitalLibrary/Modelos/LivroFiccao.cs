using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Modelos;

internal class LivroFiccao : Livro
{
    public LivroFiccao(string titulo, string autor, int anoPublicacao, int numeroPaginas, string descricao) : base(titulo, autor, anoPublicacao, numeroPaginas)
    {
        Descricao = descricao;
    }

    public string Descricao { get; }

    public override void ExibirInformacao()
    {
        base.ExibirInformacao();
        Console.WriteLine($"Descrição: {Descricao}");
    }
}
