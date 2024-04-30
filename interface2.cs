using System;
interface IAtacante {
    void Atacar() ;
}
public abstract class Heroi{

    private string nome;
    private int forca;
    private string poder;

    public Heroi(string nome,int forca,string poder){

        this.nome = nome;
        this.forca = forca;
        this.poder = poder;

    }
      
    public string GetNome(){
        return nome;
    }

    public void SetNome(string nome){
        this.nome = nome;
    }

    public int GetForca(){
        return forca;
    }

    public void SetForca(int forca){
        this.forca = forca;
    }
   public string GetPoder(){
        return poder = poder;
    }

    public void SetPoder(string  Poder){
        this.poder = poder;
   }
    public abstract void Especial();
}
class Hercules:Heroi,IAtacante{
     public Hercules(string nome,int forca,string poder ) :base(nome,forca,poder) {
     }
    public void Atacar() {
        Console.WriteLine("Hercules ataca com espada !");
    }
    public override void Especial()
    {
        Console.WriteLine("Hercules atacar com espada!");
    }
}
class Hades : Heroi,IAtacante{
     public Hades(string nome,int forca,string poder ) :base(nome,forca,poder) {
     }
    public void Atacar(){
        Console.WriteLine("Hades Lança bola de fogo!");
    } 
    public override void Especial()
    {
        Console.WriteLine("Hades lança bola de fogo!");
    }

}
class Zeus: Heroi,IAtacante{
    public Zeus(string nome,int forca,string poder ) :base(nome,forca,poder) {
     }
    public void Atacar(){
        Console.WriteLine("Zeus dispara flechas de raio !");
    }
     public override void Especial()
    {
        Console.WriteLine("Zeus dispara flechas de raio!");
    }
}
class Program{
    static void Main(string[]args) {
        Hercules hercules = new Hercules("hercules",5000,"super soco");
        Hades hades = new Hades("Hades",6000,"invisibilidade");
        Zeus zeus = new Zeus("Zeus",7000,"vira qualquer coisa");

        hercules.Atacar();
        hades.Atacar();
        zeus.Atacar();
    }
}    