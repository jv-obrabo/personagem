public abstract class Persoangens{
    public string Nome{get;set;} }
    public Personagem (string nome, int vida) {
        nome = nome;
        vida = vida
    }
    public abstract void Atacar();
    public void ReceberDano(int dano) {
        vida -= dano;
        console.WriteLine($"{nome} recebeu {dano}de dano e agora tem {vida} de vida");
        if (vida <=0) }
            Morrer();

        }
    }
    public void Morrer() {
        Console.WriteLine($"{nome} morreu!")
    }
}
public class Guerreiro : Persoangens {
    public Guerreiro (string nome,int vida) :base (nome,vida) {}
    public override void Atacar() {
        console.WriteLine($"{nome}ataca com sau espada!");
    }
}
public class Mago : personagem {
    public Mago(string nome,int vida) :base (nome,vida) {}

    public override void Atacar() {
        console.WriteLine($"{nome}lança um feitiço mágico!");
    }
}