using System;
using System.Media;

class MainClass {
  public static void Main (string[] args) 
  {  

    int option = 1;
    Console.Clear();
    
   
    
    
    Console.WriteLine("          Escolha seu Modo de Jogo");
    Console.WriteLine(" ");
    Console.WriteLine("              (1) 2 jogadores");
    Console.WriteLine(" ");
    Console.WriteLine("              (2) Versus PC");
    Console.WriteLine(" ");
    option = Convert.ToInt32(Console.ReadLine());

    if(option == 1)
    {
      
      Console.Clear();
      Tabuleiro.ImprimirTabuleiro();
      Tabuleiro. PreencherTabuleiro();
      Jogadas.Jogador1();
    }
    if(option == 2)
    {
      Console.Clear();
      Tabuleiro.ImprimirTabuleiro();
    }

    
    
  }
}