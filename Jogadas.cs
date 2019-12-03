using System;

public class Jogadas : Tabuleiro
{
  public static void Jogador1()
  {
    Console.WriteLine("Digite uma casa");
    string Valor = Console.ReadLine();
    for(int i=0; i<3; i++)
    {
      for(int j=0; j<3; j++)
      {
        if(Valor == _Tabua[i,j])
        {
          _Tabua[i,j] = "X";
        }
      }

      if(i == 2)
      {
        Console.Clear();
        Verifica.Verifica1();
        Tabuleiro.PreencherTabuleiro();
        Jogador2(); 
      }

      
    } 
  }

  public static void Jogador2()
  {
    Console.WriteLine("Digite uma casa");
    string Valor = Console.ReadLine();
    for(int i=0; i<3; i++)
    {
      for(int j=0; j<3; j++)
      {
        if(Valor == _Tabua[i,j])
        {
          _Tabua[i,j] = "O";
        }
      }

      if(i == 2)
      {
        Console.Clear();
        Verifica.Verifica2();
        Tabuleiro.PreencherTabuleiro();
        Jogador1(); 
      }

      
    } 
  }

}