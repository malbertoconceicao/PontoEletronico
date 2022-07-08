using System;
using System.IO;

namespace PontoEletronico
{
  class Editor
  {
    public static void Salvar()
    {
      var dataAtual = DateTime.Now;
      var data = String.Format("{0:dd/mm/yyy}", dataAtual);
      var hora = String.Format("{0:hh:mm:ss}", dataAtual);

      Console.Clear();

      Console.WriteLine($"Ponto batido com sucesso as {hora} em {data}");

      using (var file = new StreamWriter("C:/dev/marcacao.txt"))
      {
        file.WriteLine($"Ponto batido as {hora} em {data}");
      }
      Menus.MenuVoltar();
    }
  }
}
