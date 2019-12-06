using System;

public class Tabuleiro
{
  public static string[,] _Tabua = new string[3,3];
  public static int       _contador= 0;   

  

 
  

  public static void ImprimirTabuleiro()
  {
    for (int k=0; k<3 ; k++)
    {
      for (int l=0; l<3; l++)
      {
        _contador++;
        _Tabua[k,l] = _contador.ToString();
        
      } 
    }  
  }

  public static void PreencherTabuleiro()
  {
    for (int k=0; k<3 ; k++)
    {
      for (int ç=0; ç<3; ç++)
      {
        if(ç==0)
        {
          Console.Write("                   ");
        }
        if(_Tabua[k,ç]== "X")
        {
          Console.ForegroundColor = ConsoleColor.Red;
        }
        if(_Tabua[k,ç]== "O")
        {
          Console.ForegroundColor = ConsoleColor.Blue;
        }
        Console.Write("{0} ",_Tabua[k,ç]);
        Console.ForegroundColor = ConsoleColor.White;
      }

      Console.WriteLine(" ");
    }
  }
}