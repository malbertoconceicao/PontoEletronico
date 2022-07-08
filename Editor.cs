using System;
using System.IO;

namespace PontoEletronico
{
  class Editor
  {
    public static void Salvar(string hora, string data)
    {
      var path = "C:/dev/marcacao.txt";
      using (var file = new StreamWriter(path))
      {
        file.WriteLine($"Ponto batido as {hora} em {data}");
      }
    }
  }
}
