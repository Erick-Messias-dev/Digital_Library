using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Modelos;

internal class LivroTerror : Livro
{
    public LivroTerror(string titulo, string autor, int anoPublicacao, int numeroPaginas, string descricao, int idade) : base(titulo, autor, anoPublicacao, numeroPaginas)
    {
        Descricao = descricao;
    }
    public string Descricao { get; }

    public override void ExibirInformacao()
    {
        base.ExibirInformacao();
        Console.WriteLine("Qual sua idade?");
        int idade = int.Parse(Console.ReadLine()!);
        if (idade >= 16 )
        {
            Console.WriteLine(Descricao);
        }
        else
        {
            Console.WriteLine($"Esse livro não é indicado pra alguem da sua idade");
        }
    }
}
