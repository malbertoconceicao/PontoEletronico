using System;
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
      switch (opcao)
      {
        case 1: MenuPonto(); break;
        case 2: Editor.Visualizar(); break;
        case 3: System.Environment.Exit(0); break;
        default: Menu(); break;
      }
    }
    public static void MenuVoltar()
    {
      Console.WriteLine("1 - Deseja sair?");
      Console.WriteLine("2 - Voltar ao menu");
      var opcaoVoltar = int.Parse(Console.ReadLine());
      switch (opcaoVoltar)
      {
        case 1: System.Environment.Exit(0); break;
        case 2: Menu(); break;
        default: MenuVoltar(); break;
      }
    }
    public static void MenuPonto()
    {
      Console.Clear();
      Console.WriteLine("1 - Entrada");
      Console.WriteLine("2 - Entrada Almoço");
      Console.WriteLine("3 - Saída Almoço");
      Console.WriteLine("4 - Saída");
      Console.WriteLine("5 - Voltar");
      var opcao = int.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1: Editor.Salvar(1); break;
        case 2: Editor.Salvar(2); break;
        case 3: Editor.Salvar(3); break;
        case 4: Editor.Salvar(4); break;
        case 5: Menu(); break;
        default: MenuPonto(); break;
      }
    }
  }
}
