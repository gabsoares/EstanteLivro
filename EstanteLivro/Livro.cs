public class Livro
{
    public string titulo;
    public string[] autores = new string[2];
    public DateOnly dataLancamento;
    public string editora;
    public int edicao;
    public string ISBN;
    public int quantidadePagina;

    public Livro()
    {
    }

    public void DefinirTitulo(string t)
    {
        titulo = t;
    }

    public void DefinirAutores(string[] a)
    {
        autores = a;
    }

    public void DefinirDataLancamento(DateOnly d)
    {
        dataLancamento = d;
    }

    public void DefinirEditora(string e)
    {
        editora = e;
    }

    public void DefinirEdicao(int e)
    {
        edicao = e;
    }

    public void DefinirISBN(string i)
    {
        ISBN = i;
    }

    public void DefinirQuantidadePagina(int q)
    {
        quantidadePagina = q;
    }

    public void ImprimirLivro()
    {
        Console.Write("Titulo: " + this.titulo + "\n");
        for (int i = 0; i < this.autores.Length; i++)
        {
            Console.WriteLine($"Autor {i + 1}: {this.autores[i]}");
        }
        Console.Write("Data Lancamento: " + this.dataLancamento + "\n");
        Console.Write("Editora: " + this.editora + "\n");
        Console.Write("Edicao: " + this.edicao + "\n");
        Console.Write("ISBN: " + this.ISBN + "\n");
        Console.Write("Quantidade pagina: " + this.quantidadePagina + "\n");
    }
}

