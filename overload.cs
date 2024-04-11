public class Personagem { 
    private string nome;
    private string poder;
    private string pontoVida;
    private string pontoAtaque;

    public Personagem(string nome, string poder, string pontoVida ,string pontoAtaque){
        Nome = nome;
        Poder = poder;
        PontoVida = pontoVida
        PontoAtaque =pontoAtaque
    }
    public string Nome {
        get{ return nome;}
        set {nome=value}
    }
    public int Poder {
        get {return poder ; }
        set{ poder= value}
    }
    public int PontoVida {
        get {return pontoVida ; }
        set{ pontoVida= value}
    }
    public int PontoAtaque {
        get {return pontoAtaque ; }
        set{ pontoAtaque= value}
    }

    public void Atacar(){
        Console.WriteLine("ataque rapido");
    }
    public void Atacar(string habilidade ){
        Console.WriteLine("ataque rapido"+habilidade);
    }
}

public class Goku: Personagem { 
    public Goku (string nome, string poder, string pontoVida ,string pontoAtaque){
        Nome = nome;
        Poder = poder;
        PontoVida = pontoVida
        PontoAtaque =pontoAtaque;
    }
    
    public void Atacar(){
        Console.WriteLine("correr");
    }
    public void Atacar(string habilidade ){
        Console.WriteLine("kamekamera"+ habilidade);
    }
}
public class Program {

    public static void Main(string[] args) {
        Goku goku = new Goku();
        
        //Sobrecarga
        goku.Atacar();//Chama o método Atacar() da classe derivada
        goku.Atacar("Investida!");//Chama o método Atacar(string) da classe base
        
    }
}
    


