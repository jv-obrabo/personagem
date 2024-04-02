using System;

// Classe principal
public class Roupa
{
    // Atributos encapsulados
    private string Tipo { get; set; }
    private string Tamanho { get; set; }
    private string Cor { get; set; }

    // Construtor
    public Roupa(string tipo, string tamanho, string cor)
    {
        Tipo = tipo;
        Tamanho = tamanho;
        Cor = cor;
    }


    // Método público para exibir informações básicas da roupa
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Tipo: {Tipo}, Tamanho: {Tamanho}, Cor: {Cor}");
    }
}

// Subclasse 1
public class Camiseta : Roupa
{
    // Atributo específico de Camiseta
    public string Estampa { get; set; }

    // Construtor
    public Camiseta(string tipo, string tamanho, string cor, string estampa)
        : base(tipo, tamanho, cor)
    {
        Estampa = estampa;
    }

    // Método específico de Camiseta
    public void ExibirEstampa()
    {
        Console.WriteLine($"Estampa: {Estampa}");
    }
}

// Subclasse 2
public class Calca : Roupa
{
    // Atributo específico de Calça
    public string Material { get; set; }

    // Construtor
    public Calca(string tipo, string tamanho, string cor, string material)
        : base(tipo, tamanho, cor)
    {
        Material = material;
    }

    // Método específico de Calça
    public void ExibirMaterial()
    {
        Console.WriteLine($"Material: {Material}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instanciando um objeto da classe Camiseta
        Camiseta minhaCamiseta = new Camiseta("Camiseta", "M", "Branca", "Logo da banda");
        minhaCamiseta.ExibirInformacoes();
        minhaCamiseta.ExibirEstampa();

        Console.WriteLine();

        // Instanciando um objeto da classe Calça
        Calca minhaCalca = new Calca("Calça", "42", "Azul", "Jeans");
        minhaCalca.ExibirInformacoes();
        minhaCalca.ExibirMaterial();

        Console.ReadLine();
    }
}