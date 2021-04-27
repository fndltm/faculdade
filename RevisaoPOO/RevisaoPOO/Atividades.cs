using System;
using System.Collections;
using System.Collections.Generic;
using RevisaoPOO_1;
using RevisaoPOO_2;

namespace RevisaoPOO
{
  public static class Atividades
  {
    public static void RevisaoPOO1()
    {
      Duck duck = new Duck();
      MallardDuck mallardDuck = new MallardDuck();
      RubberDuck rubberDuck = new RubberDuck();
      RedHeadDuck redHeadDuck = new RedHeadDuck();

      duck.display();
      duck.swim();

      mallardDuck.display();
      mallardDuck.quack();
      mallardDuck.fly();

      rubberDuck.display();
      rubberDuck.quack();

      redHeadDuck.display();
      redHeadDuck.fly();
      redHeadDuck.quack();
    }
    public static void RevisaoPOO2()
    {
      ArrayList animais = new ArrayList();

      // Instância 4 objetos do tipo Galinha para ser adicionado ao ArrayList.
      Galinha animal1 = new Galinha();
      animal1.SetNome("Galinha 1");
      Galinha animal2 = new Galinha();
      animal2.SetNome("Galinha 2");
      Galinha animal3 = new Galinha();
      animal3.SetNome("Galinha 3");
      Galinha animal4 = new Galinha();
      animal4.SetNome("Galinha 4");

      // Instância 6 objetos do tipo Morcego para ser adicionado ao ArrayList.
      Morcego animal5 = new Morcego();
      animal5.SetNome("Bat 1");
      Morcego animal6 = new Morcego();
      animal6.SetNome("Bat 2");
      Morcego animal7 = new Morcego();
      animal7.SetNome("Bat 3");
      Morcego animal8 = new Morcego();
      animal8.SetNome("Bat 4");
      Morcego animal9 = new Morcego();
      animal9.SetNome("Bat 5");
      Morcego animal10 = new Morcego();
      animal10.SetNome("Bat 6");

      // Adiciona os morcegos e galinhas ao ArrayList em ordem variada.
      animais.Add(animal1);
      animais.Add(animal2);
      animais.Add(animal5);
      animais.Add(animal3);
      animais.Add(animal6);
      animais.Add(animal4);
      animais.Add(animal7);
      animais.Add(animal9);
      animais.Add(animal8);
      animais.Add(animal10);

      // Itera cada Animal dentro de animais.
      foreach (Animal animal in animais)
      {
        // Para cada animal, escreve seu nome e executa a ação acordar e comer.
        Console.WriteLine("Animal: {0}", animal.GetNome());
        animal.Acordar();
        animal.Comer();

        // Se o animal for um morcego, faz o cast de Animal para Morcego e executa a ação voar.
        if (animal is Morcego)
        {
          ((Morcego)animal).voar();
        }
      }
    }
  }
}