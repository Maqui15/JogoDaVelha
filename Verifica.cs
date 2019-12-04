using System;

public class Verifica : Jogadas
{
  public static void Verifica1()
  {
    if(_Tabua[0,0] == "X" && _Tabua[0,1] == "X" && _Tabua[0,2] == "X")
    {
     Console.WriteLine("Jogador 1 Venceu");
    }
    if(_Tabua[1,0] == "X" && _Tabua[1,1] == "X" && _Tabua[1,2] == "X")
    {
      Console.WriteLine("Jogador 1 Venceu");
    }
    if(_Tabua[2,0] == "X" && _Tabua[2,1] == "X" && _Tabua[2,2] == "X")
    {
     Console.WriteLine("Jogador 1 Venceu");
    }
    if(_Tabua[0,0] == "X" && _Tabua[1,1] == "X" && _Tabua[1,2] == "X")
    {
      Console.WriteLine("Jogador 1 Venceu");
    }
    if(_Tabua[2,0] == "X" && _Tabua[1,1] == "X" && _Tabua[0,2] == "X")
    {
     Console.WriteLine("Jogador 1 Venceu");
    }
    if(_Tabua[0,0] == "X" && _Tabua[1,0] == "X" && _Tabua[2,0] == "X")
    {
     Console.WriteLine("Jogador 1 Venceu");
    }
    if(_Tabua[0,1] == "X" && _Tabua[1,1] == "X" && _Tabua[2,1] == "X")
    {
     Console.WriteLine("Jogador 1 Venceu");
    }
    if(_Tabua[0,2] == "X" && _Tabua[1,2] == "X" && _Tabua[2,2] == "X")
    {
      Console.WriteLine("Jogador 1 Venceu");
    }
  }

  public static void Verifica2()
  {
    if(_Tabua[0,0] == "O" && _Tabua[0,1] == "O" && _Tabua[0,2] == "O")
    {
     Console.WriteLine("Jogador 2 Venceu");
    }
    if(_Tabua[1,0] == "O" && _Tabua[1,1] == "O" && _Tabua[1,2] == "XO")
    {
      Console.WriteLine("Jogador 2 Venceu");
    }
    if(_Tabua[2,0] == "O" && _Tabua[2,1] == "O" && _Tabua[2,2] == "O")
    {
     Console.WriteLine("Jogador 2 Venceu");
    }
    if(_Tabua[0,0] == "O" && _Tabua[1,1] == "O" && _Tabua[1,2] == "O")
    {
      Console.WriteLine("Jogador 2 Venceu");
    }
    if(_Tabua[2,0] == "O" && _Tabua[1,1] == "O" && _Tabua[0,2] == "O")
    {
     Console.WriteLine("Jogador 2 Venceu");
    }
    if(_Tabua[0,0] == "O" && _Tabua[1,0] == "O" && _Tabua[2,0] == "O")
    {
     Console.WriteLine("Jogador 2 Venceu");
    }
    if(_Tabua[0,1] == "O" && _Tabua[1,1] == "O" && _Tabua[2,1] == "O")
    {
     Console.WriteLine("Jogador 2 Venceu");
    }
    if(_Tabua[0,2] == "O" && _Tabua[1,2] == "O" && _Tabua[2,2] == "O")
    {
      Console.WriteLine("Jogador 2 Venceu");
    }
  }
}
