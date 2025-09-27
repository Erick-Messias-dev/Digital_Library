using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Modelos;

internal class LivroTerror : Livro
{
    public LivroTerror(string titulo, string autor, int anoPublicacao, int numeroPaginas, string descricao) : base(titulo, autor, anoPublicacao, numeroPaginas)
    {
        Descricao = descricao;
    }
    public string Descricao { get; }

    public override void ExibirInformacao()
    {
        base.ExibirInformacao();
        Console.WriteLine("Qual sua idade?");
        int idade = int.Parse(Console.ReadLine()!);
        if (idade <= 0)
        {
            throw new Exception("A idade não pode ser negativa ou zero");
        }
        else if (idade >= 16 )
        {
            
            Console.WriteLine(Descricao);
        }
        else
        {
            Console.WriteLine($"Esse livro não é indicado pra alguem da sua idade\n");
        }
        
    }
}
