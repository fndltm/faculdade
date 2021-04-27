using System;

namespace RevisaoPOO_1
{
  public class Duck
  {
    public void swim()
    {
      Console.WriteLine("Classe Duck: Método swim.");
      Console.WriteLine("NADANDO!!!\n");
    }
    public virtual void display()
    {
      Console.WriteLine("\nClasse Duck: Método display.");
      Console.WriteLine("IMPRIMINDO Duck!!!\n");
    }
  }
}