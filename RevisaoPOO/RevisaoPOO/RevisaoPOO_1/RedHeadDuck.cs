using System;

namespace RevisaoPOO_1
{
  public class RedHeadDuck : Duck, IQuackable, IFlyable
  {
    public void quack()
    {
      Console.WriteLine("\nClasse RedHeadDuck: Método Quack.");
      Console.WriteLine("Quack quack quack!!!\n");
    }
    public void fly()
    {
      Console.WriteLine("\nClasse RedHeadDuck: Método fly.");
      Console.WriteLine("Voando alto e longe!!!\n");
    }
    public override void display()
    {
      Console.WriteLine("\nClasse RedHeadDuck: Método display sobreescrito da classe Duck.");
      Console.WriteLine("IMPRIMINDO RedHeadDuck!!!\n");
    }
  }
}