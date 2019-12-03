using System;

public class Tabuleiro
{
  public static string[,] _Tabua = new string[3,3];
  public static int       _contador= 0;   

  

  public static void ImprimirTabuleiro()
  {
    for (int k=0; k<3 ; k++)
    {
      for (int ç=0; ç<3; ç++)
      {
        _contador++;
        _Tabua[k,ç] = _contador.ToString();
        
      } 
    }  
  }

  public static void PreencherTabuleiro()
  {
    for (int k=0; k<3 ; k++)
    {
      for (int ç=0; ç<3; ç++)
      {
        Console.Write("{0} ",_Tabua[k,ç]);
      }

      Console.WriteLine(" ");
    }
  }
}