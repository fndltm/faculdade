using System;

namespace RevisaoPOO_1
{
  public class RubberDuck : Duck, IQuackable
  {
    public void quack()
    {
      Console.WriteLine("\nClasse RubberDuck: Método Quack.");
      Console.WriteLine("Quack quack quack!!!\n");
    }
    public override void display()
    {
      Console.WriteLine("\nClasse RubberDuck: Método display sobreescrito da classe Duck.");
      Console.WriteLine("IMPRIMINDO RubberDuck!!!\n");
    }
  }
}