public class Produto { 
    private string nome;
    private decimal preco;
    private string descricao;
    private string categoria;

    public Pessoa(string nome, decimal preco, string descriçao,string categoria)
       Nome = nome;
       Preco = preco;
     Descriçao= descriçao
}
  public string nome {
    get{ return nome;}
    set {nome=value}
  }
public int preco {
    get {return preco ; }
    set{ preco= value}
}
public int descriçao {
    get {return descriçao ; }
    set{ descriçao= value}
}
public int categoria {
    get {return categoria ; }
    set{ categoria= value}
}

public class ConsoleGame : Produto {
    private int capacidade;

    public ConsoleGame(string nome, decimal preco, string descricao, string categoria,int capacidade): base (nome, preco, descricao,categoria){
        Capacidade = capacidade
    } 


    public int Capacidade{
        get { return capacidade;}
        set { capacidade = value;}
    } 
}

public class Jogo : Produto {
    private string genero;

    public Jogo(string nome, decimal preco, string descricao, string categoria,string genero): base (nome, preco, descricao,categoria){
        genero = genero
    } 


    public string Genero{
        get { return genero;}
        set { genero = value;}
    } 
}

public class Acessorio : Produto {
    private string tipo;

    public Tipo(string nome, decimal preco, string descricao, string categoria,string tipo): base (nome, preco, descricao,categoria){
        Tipo = tipo
    } 


    public string Tipo{
        get { return tipo;}
        set { tipo = value;}
    } 
}

public class Colecionavel : Produto {
    private bool limitado;

    public Colecionavel(string nome, decimal preco, string descricao, string categoria,bool limitado): base (nome, preco, descricao,categoria){
        Limitado = limitado
    } 


    public bool Limitado{
        get { return limitado;}
        set { limitado = value;}
    } 
}

 public class Program {

public static void main (String[] args) {
 Produto produto;
produto = new ConsoleGame("PlayStation 5", 5.900, "Console de Vídeo Game PlayStation 5 SLim com 1 Tera de armazenamento", "Console", 1024000);

Jogo jogo = new Jogo("Marvel 3s Spiden-Man 2 PREMIUM", 299.2, "Jogo completo Marvels Spider-Man 2 para PS5.", "Jogo PS5", "Ação e Aventura") ;

Acessorio acessorio;
 acessorio= new Acessorio("fone",300,"fone de ouvido para ps5","acessorio","fone sem fio");

Colecionavel colecionavel;
colecionavel =new Colecionavel ("fone",300,"fone de ouvido para ps5","Console",true);
}