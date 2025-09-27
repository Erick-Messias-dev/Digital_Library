
using DigitalLibrary;
using DigitalLibrary.Modelos;


List<Livro> livros = new List<Livro>()
{
      new LivroFiccao("As Crônicas de Nárnia", "C.S Lewis", 1949, 700, "Perfeito para você que gosta de viajar em uma história fantasiosa\n"),

      new LivroTerror("It a coisa", "Stephen King", 2014, 1024, "perfeito pra você que gosta de sentir um pouco de medo\n")
};

foreach (var livro in livros)
{
    //utilizando o polimorfismo para dar a descrição de cada novo livro instanciado
    livro.ExibirInformacao();
}


//Testes para verificar se método esta funcionando como esperado
Console.WriteLine("\n ----Tentnado Emprestar---- \n");
livros[0].Emprestar();
livros[0].Emprestar();
livros[0].Devolver();
livros[0].Devolver();


