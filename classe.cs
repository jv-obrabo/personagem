using System ;

public class personagem 
{
  // Atributos da classe Personagem
  private string nome;
  private int nivel;
  private double pontuacao;
  private double vida;
  private double forca;
  private double agilidade;
  private doble inteligencia;
  private string [] armasEquipamentos;


  // Contrutor da classe Personagem 
  public Personagem (string nome,int nivel,double pontuacao,double vida,double forca, double agilidade,double inteligencia,string[] armasEquipamentos)
  {
    this.nome = nome;
    this.nivel = nivel;
    this.pontuaçao = pontuacao;
    this.vida = vida;
    this.forca = forca;
    this.agilidade = agilidade;
    this.inteligencia = inteligencia;
    this.armasEquipamentos = armasEquipamentos; 
  }


// Getter pare o nome
public string getNome (){
    return nome ;
}
// Seter para o nome 
public void SetNome(string nome){
    this.nome = nome;
}
// getter para o nivel
 public int GetNivel(){
    return nivel;
 }
public void setNivel (int nivel){
    this.nivel = nivel;
}
 // Getter para o pontuacao 
  public double GetPontuacao () {
    return pontuacao;
  }
  // Setter para o puntuaçao 
  public void SetPontuacao (double pontuaçao){
    this.pontuaçao =pontuacao ;
  }
 // Getter para o vida 
 public double GetVida(){
    return vida ;
 }
 //setter para o vida 
 public void SetVide (double vida){
    this.vida = vida;
 }

 // Getter  para o forca
 public double GetForca(){
    return forca;
 }
 // Setter para o forca
   public void SetForca (double forca){
    this.forca = forca;
   }
   public double GetAgilidade(){
    return agilidade;
}

public void SetAgilidade(){
    return agilidade = agilidade;
}

public double GetIntelingencia(){
    return inteligencia;
}

public void SetInteligencia (double inteligencia){
    this.inteligencia = inteligencia;
}

public string[] GetArmasEquipamentos(){
    return armasEquipamentos;
}

public void SetArmasEquipamentos(string[] armasEquipamentos){
    this.armasEquipamentos = armasEquipamentos;
}

public void Mover(string direcao, double distancia){
    Console.WriteLine($"{GetNome()} esta se movendo na direcao {direcao} por {distancia} passos.");
}

public void Atacar (Personagem alvo){
    Console.WriteLine($"{GetNome()} esta atacando {alvo.GetNome}.");
}

public void ReceberDano(double dano){
    if (vida<= 0){
        Morrer();
    }else{
        console.WriteLine($"{GetNome()} recebeu {dano} de dano. Vida restante: {GetVida()}");
    }
}

// Metodo para usar uma habilidade
public void UsarHabilidade(string habilidade, Personagem alvo){
    Console.WriteLine($"{GetNome()}) subiu para o nivel {GetNivel()}!");
}
// Metodo para subir de nivel
public void Morrer(){
    Console.Writeline($"{GetNome()}) morreu.");
    /*Aqui voce pode adicionar logica adicional, como reiniciar o personagem, exibir uma mensagem de game over,etc.*/
}

class Program{
    static void Main(string[] args)
// Criando um objeto(batman) da classe Personagem
Personagem batman =new Personagem ("Batman", 1, 0, 100, 90, 80, 100, new string[] {
"Multi-Batarangue", "Lançador de de Gel", "Bomba de fumaça", "Ultra Bat-Garra", "Sintetizador de Voz" });
// Exibindo informações do personagem Batman
Console.WriteLine("Personagem Heroi");
Console WriteLine($ "Nome: (batman. GetNome())");
Console WriteLine($ "Nivel: (batman. GetNivel())");
Console WriteLine ($ "Pontuacao do Batman: (batman.GetPontuacao())");
Console WriteLine($ "Vida: batman.GetVida()");
Console WriteLine ($ "Forca: (batman.GetForca()t");
Console WriteLine($ "Agilidade: {batman.GetAgilidade()}");
Console WriteLine($ "Inteligencia: {batman GetInteligencia()})")
Console WriteLine($ "Armas e Equipamentos: {string.Join(", ", batman GetArmasEquipamentos())})";
Console WriteLine("")