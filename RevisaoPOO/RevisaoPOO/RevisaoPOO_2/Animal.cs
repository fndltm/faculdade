using System;

namespace RevisaoPOO_2
{
  public class Animal
  {
    private string nome;

    public string SetNome(string nome)
    {
      return this.nome = nome;
    }
    public string GetNome()
    {
      return this.nome;
    }
    public void Acordar()
    {
      Console.WriteLine("Classe Animal: Método acordar.");
      Console.WriteLine("ACORDANDO!!!\n");
    }
    public void Comer()
    {
      Console.WriteLine("Classe Animal: Método comer.");
      Console.WriteLine("COMENDO!!!\n");
    }
    public void Dormir()
    {
      Console.WriteLine("Classe Animal: Método dormir.");
      Console.WriteLine("DORMINDO!!!\n");
    }
  }
}