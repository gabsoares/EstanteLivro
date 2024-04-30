char opcao = 'i';
Livro livro = new Livro();
Console.WriteLine("Digite a quantidade de livros que quer guardar na estante: ");
Livro[] estante = new Livro[int.Parse(Console.ReadLine())];

Livro CadastroLivros()
{
    Livro l_temp = new Livro();

    Console.Write("Titulo: ");
    l_temp.DefinirTitulo(Console.ReadLine());

    for (int i = 0; i < (l_temp.autores).Length; i++)
    {
        Console.Write($"Autor {i + 1}: ");
        l_temp.autores[i] = Console.ReadLine();
    }
    l_temp.DefinirAutores(l_temp.autores);

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

while ((opcao != 'i' && opcao != 'I') || (opcao != 'g' && opcao != 'G'))
{
    Console.WriteLine("Digite I para consultar algum índice\nDigite G para consulta geral");
    opcao = char.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 'i':
        case 'I':
            Console.Write("Digite o índice para consultar o livro: ");
            Console.WriteLine();
            estante[int.Parse(Console.ReadLine())].ImprimirLivro();
            break;
        case 'g':
        case 'G':
            Console.WriteLine("Consulta do índice geral");
            for (int i = 0; i < estante.Length; i++)
            {
                estante[i].ImprimirLivro();
                Console.WriteLine();
            }
            break;
        default:
            Console.Write("Digite apenas um dos números citados: ");
            break;
    }
}



