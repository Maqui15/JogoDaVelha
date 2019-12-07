using System;
using System.Media;

public class Verifica : Jogadas
{
  public static void Verifica1()
  {
    SoundPlayer player = new  SoundPlayer(@"Sound.wav");
    try 
    {
      if(_Tabua[0,0] == "X" && _Tabua[0,1] == "X" && _Tabua[0,2] == "X")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 1 venceu!", erro_ocorrido.Message);
      PararCodigo();
    } 
    try 
    {
      if(_Tabua[1,0] == "X" && _Tabua[1,1] == "X" && _Tabua[1,2] == "X")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 1 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[2,0] == "X" && _Tabua[2,1] == "X" && _Tabua[2,2] == "X")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 1 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,0] == "X" && _Tabua[1,1] == "X" && _Tabua[2,2] == "X")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 1 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[2,0] == "X" && _Tabua[1,1] == "X" && _Tabua[0,2] == "X")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 1 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,0] == "X" && _Tabua[1,0] == "X" && _Tabua[2,0] == "X")
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 1 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,1] == "X" && _Tabua[1,1] == "X" && _Tabua[2,1] == "X")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 1 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,2] == "X" && _Tabua[1,2] == "X" && _Tabua[2,2] == "X")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 1 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
  }

  public static void Verifica2()
  {
    SoundPlayer player = new  SoundPlayer(@"Sound.wav");
    try
    {
      if(_Tabua[0,0] == "O" && _Tabua[0,1] == "O" && _Tabua[0,2] == "O")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 2 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[1,0] == "O" && _Tabua[1,1] == "O" && _Tabua[1,2] == "O")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 2 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[2,0] == "O" && _Tabua[2,1] == "O" && _Tabua[2,2] == "O")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 2 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,0] == "O" && _Tabua[1,1] == "O" && _Tabua[2,2] == "O")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 2 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[2,0] == "O" && _Tabua[1,1] == "O" && _Tabua[0,2] == "O")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 2 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,0] == "O" && _Tabua[1,0] == "O" && _Tabua[2,0] == "O")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 2 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,1] == "O" && _Tabua[1,1] == "O" && _Tabua[2,1] == "O")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 2 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,2] == "O" && _Tabua[1,2] == "O" && _Tabua[2,2] == "O")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Jogador 2 venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
  }

  public static void PararCodigo()
  {
    System.Environment.Exit(1);
  }

  public static void verifica3()
  {

    SoundPlayer player = new  SoundPlayer(@"Sound.wav");
    
    try
    {
      if(_Tabua[0,0] == "O" && _Tabua[0,1] == "O" && _Tabua[0,2] == "O")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Computador venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[1,0] == "O" && _Tabua[1,1] == "O" && _Tabua[1,2] == "O")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Computador venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[2,0] == "O" && _Tabua[2,1] == "O" && _Tabua[2,2] == "O")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Computador venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,0] == "O" && _Tabua[1,1] == "O" && _Tabua[2,2] == "O")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Computador venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[2,0] == "O" && _Tabua[1,1] == "O" && _Tabua[0,2] == "O")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Computador venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,0] == "O" && _Tabua[1,0] == "O" && _Tabua[2,0] == "O")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Computador venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,1] == "O" && _Tabua[1,1] == "O" && _Tabua[2,1] == "O")
      {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      player.Play();
      Console.ResetColor();
      throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Computador venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
    try
    {
      if(_Tabua[0,2] == "O" && _Tabua[1,2] == "O" && _Tabua[2,2] == "O")
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        player.Play();
        Console.ResetColor();
        throw new Exception();
      }
    }
    catch (Exception erro_ocorrido)
    {
      Console.WriteLine("Computador venceu!", erro_ocorrido.Message);
      PararCodigo();
    }
  }
}
