using System;

namespace RevisaoPOO_1
{
  public class MallardDuck : Duck, IQuackable, IFlyable
  {
    public void quack()
    {
      Console.WriteLine("\nClasse MallardDuck: Método Quack.");
      Console.WriteLine("Quack quack quack!!!\n");
    }
    public void fly()
    {
      Console.WriteLine("\nClasse MallardDuck: Método fly.");
      Console.WriteLine("Voando alto e longe!!!\n");
    }
    public override void display()
    {
      Console.WriteLine("\nClasse MallardDuck: Método display sobreescrito da classe Duck.");
      Console.WriteLine("IMPRIMINDO MallardDuck!!!\n");
    }
  }
}