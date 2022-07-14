using System;
using System.IO;

namespace PontoEletronico
{
  class Editor
  {
    public static void Salvar(int opcao)
    {
      var tipoDeEntrada = " ";
      switch (opcao)
      {
        case 1: tipoDeEntrada = "Entrada"; break;
        case 2: tipoDeEntrada = "Almoço"; break;
        case 3: tipoDeEntrada = "Volta almoço"; break;
        case 4: tipoDeEntrada = "Saída"; break;
        default: Console.WriteLine("Tipo de entrada errada!"); break;
      }
      var dataAtual = DateTime.Now;
      var data = String.Format("{0:dd/MM/yyy}", dataAtual);
      var hora = String.Format("{0:hh:mm:ss}", dataAtual);

      Console.Clear();

      Console.WriteLine($"{tipoDeEntrada} batida com sucesso as {hora} em {data}");

      using (var file = new StreamWriter(@"C:/dev/marcacao.txt", true))
      {

        file.WriteLine($"{tipoDeEntrada} as {hora} em {data}");
      }
      Menus.MenuVoltar();
    }

    public static void Visualizar()
    {

      using (var file = new StreamReader(@"C:/dev/marcacao.txt", true))
      {
        string marcacao;
        while ((marcacao = file.ReadLine()) != null)
        {
          Console.WriteLine(marcacao);
        }
        file.Close();
        Menus.MenuVoltar();
      }
    }
  }
}
