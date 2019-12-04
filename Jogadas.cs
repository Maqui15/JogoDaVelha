using System;

public class Jogadas : Tabuleiro
{
  public static void Jogador1()
  {
    Console.WriteLine("Jogador 1 digite uma casa");
    string Valor = Console.ReadLine();
    try 
    {
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
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 1 você deve selecionar uma casa livre. O erro foi {0}", erro_ocorrido.Message);
    }  
  }

  public static void Jogador2()
  {
    Console.WriteLine("Jogador 2 digite uma casa");
    string Valor = Console.ReadLine();
    try
    {
      for(int i=0; i<3; i++)
      {
        for(int j=0; j<3; j++)
        {
          if(Valor == _Tabua[i,j])
          {
            {
              _Tabua[i,j] = "O";
            }
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
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 2 você deve selecionar uma casa livre. O erro foi {0}", erro_ocorrido.Message);
    } 
  }
}