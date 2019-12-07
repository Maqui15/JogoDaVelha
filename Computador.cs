using System;

public class Computador : Tabuleiro
{

  public static string _Val;
  public static bool _PodeJogar;
  public static int Valor;
  public static void Player()
  {
    Console.WriteLine("Digite Uma casa para jogar.");
    _Val = Console.ReadLine();

    for(int i=0; i<3; i++)
    {
      for(int j=0; j<3; j++)
      {
        if(_Tabua[i,j] == _Val)
        {
          _Tabua[i,j] = "X";
          Console.Clear();
          PreencherTabuleiro();
          Verifica.Verifica1();
          Computa();
        }
      }
    }
  
  }

  public static void Computa()
  {
    Console.Clear();
    
    

    for(int i=0; i<3; i++)
    {
      for(int j=0; j<3; j++)
      {
        Random randomiza = new Random();
        Valor = randomiza.Next(1,9);
        if(_Tabua[i,j] == Valor.ToString())
        {
          _Tabua[i,j] = "O";
          PreencherTabuleiro();
          Verifica.verifica3();
          Player();
          
          
        }
      }
    }
    Computa();
  }


}