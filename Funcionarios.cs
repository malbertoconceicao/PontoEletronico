using System;

namespace PontoEletronico
{
  public class Funcionarios
  {
    public static void Autentica(int login, int senha)
    {
      var func = new Funcionario[1];

      func[0] = new Funcionario()
      {
        Id = 1212,
        Nome = "Marcos",
        Login = 1212,
        Senha = 1234
      };
      if (login == func[0].Login && senha == func[0].Senha)
      {
        Menus.Menu();
      }
      else
      {
        Console.WriteLine("usuário ou senha incorreta!!!");
      }
    }
    public class Funcionario
    {
      public int Id { get; set; }
      public string Nome { get; set; }
      public int Login { get; set; }
      public int Senha { get; set; }
    }
  }
}
