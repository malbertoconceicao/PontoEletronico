using System;
using System.IO;

namespace PontoEletronico
{
  class Menus
  {
    public static void Login()
    {
      Console.Clear();
      Console.WriteLine("Tela de Login");
      Console.WriteLine("Digite seu Login:");
      var login = int.Parse(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("Senha:");
      var senha = int.Parse(Console.ReadLine());
      Funcionarios.Autentica(login, senha);
    }
    public static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Ponto Eletrônico");
      Console.WriteLine("1 - Bater o ponto");
      Console.WriteLine("2 - Ver Historico de marcações");
      Console.WriteLine("3 - Sair");
      var opcao = int.Parse(Console.ReadLine());

      var dataAtual = DateTime.Now;
      var data = String.Format("{0:dd/mm/yyy}", dataAtual);
      var hora = String.Format("{0:hh:mm:ss}", dataAtual);

      Console.WriteLine($"Ponto batido as {hora} em {data}");

      Editor.Salvar(hora, data);
    }
  }
}
