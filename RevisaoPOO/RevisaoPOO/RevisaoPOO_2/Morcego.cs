using System;

namespace RevisaoPOO_2
{
  public class Morcego : Mamifero, IVoador
  {
    public void voar()
    {
      Console.WriteLine("Classe Morcego: Método voar.");
      Console.WriteLine("VOANDO ALTO E LONGE!!!\n");
    }
  }
}