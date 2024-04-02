public class Pessoa { 
    private string nome;
    private int idade;
    private string cpf;

    public Pessoa(string nome, int idade, string cpf)
       Nome = nome;
       Idade = idade;
       CPF = cpf
}
  public string nome {
    get{ return nome;}
    set {nome=value}
  }
public int Idade {
    get {return idade ; }
    set{ idade= value}
}
public string CPF {
    get{return cpf; }
    set {cpf=value;
    }
}

 public class Estudante :Pessoa {
     private string curso;
     
     public Estudante(string nome,int idade, string cpf, string curso,) :base(nome,idade,cpf) {
        curso = curso ;
     }

     public string curso{
        get{ return curso; }
        set  {curso = value;}
     }
 }