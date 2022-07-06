using System;

namespace PontoEletronico
{
    class Menus
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Ponto Eletrônico");
            Console.WriteLine("1 - Bater o ponto");
            Console.WriteLine("2 - Ver Historico de marcações");
            Console.WriteLine("3 - Sair");
            var opcao = int.Parse(Console.ReadLine());
        }
    }
}
