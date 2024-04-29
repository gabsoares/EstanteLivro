int opcao = 0;
Livro livro = new Livro();
Livro[] estante = new Livro[livro.autores.Length];

Livro CadastroLivros()
{
    Livro l_temp = new Livro();

    Console.Write("Titulo: ");
    l_temp.DefinirTitulo(Console.ReadLine());

    for (int i = 0; i < (livro.autores).Length; i++)
    {
        Console.Write($"Autor {i + 1}: ");
        livro.autores[i] = Console.ReadLine();
    }
    l_temp.DefinirAutores(livro.autores);

    Console.Write("Data lancamento: ");
    l_temp.DefinirDataLancamento(DateOnly.Parse(Console.ReadLine()));

    Console.Write("Editora: ");
    l_temp.DefinirEditora(Console.ReadLine());

    Console.Write("Edicao: ");
    l_temp.DefinirEdicao(int.Parse(Console.ReadLine()));

    Console.Write("ISBN: ");
    l_temp.DefinirISBN(Console.ReadLine());

    Console.Write("Quantidade página: ");
    l_temp.DefinirQuantidadePagina(int.Parse(Console.ReadLine()));

    Console.WriteLine();

    return l_temp;
}

for (int i = 0; i < estante.Length; i++)
{
    estante[i] = CadastroLivros();
}

for (int i = 0; i < estante.Length; i++)
{
    estante[i].ImprimirLivro();
    Console.WriteLine();
}