using System;

public class Tabuleiro
{
  public static string[,] _Tabua = new string[3,3];


  

  public static void PreencherTabuleiro()
  {
    for (int k=0; k<3 ; k++)
    {
      for (int ç=0; ç<3; ç++)
      {
        _Tabua[k,ç] = "0";
      }
    }

  }

  public static void ImprimirTabuleiro()
  {
    for (int k=0; k<3 ; k++)
    {
      for (int ç=0; ç<3; ç++)
      {
        _Tabua[k,ç] = "0";

        Console.Write(_Tabua[k,ç]);
      }

      Console.WriteLine(" ");
    }
  }

  // public static string PreencherTabuleiro(string any)
  // {
  //   if(i == 0 & j!=2)
  //   {     
  //     Console.Write(_Tabua[i,j]);
  //     Console.WriteLine("Doideira");
  //     return PreencherTabuleiro(i,j++);

  //   }else if (i==0 & j==2)
  //   {
  //     i++;
  //     j=0;
  //     Console.WriteLine(_Tabua[i,j]);
  //     Console.WriteLine("SeuCU");
  //     return PreencherTabuleiro(i,j);
  //   }else if (i==1 & j!=2)
  //   {
  //     Console.Write(_Tabua[i,j]);
  //     Console.WriteLine("Banana");
  //     return PreencherTabuleiro(i,j++);
  //   }else if (i==1 & j==2)
  //   {
  //     i++;
  //     j=0;
  //     Console.WriteLine(_Tabua[i,j]);
  //     Console.WriteLine("Aviao");
  //     return PreencherTabuleiro(i,j);
  //   }else if (i==2 & j!=2)
  //   {
  //     Console.Write(_Tabua[i,j]);
  //     Console.WriteLine("Duelo");
  //     return PreencherTabuleiro(i,j++);
  //   }  
  //   return 2;
    
  // }



}