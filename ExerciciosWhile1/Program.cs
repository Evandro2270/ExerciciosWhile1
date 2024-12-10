using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Console.WriteLine("Digite a sua senha: ");
                int senha = int.Parse(Console.ReadLine());

                while (senha != 2270) {
                    Console.WriteLine("Senha Invalida: ");
                    senha = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Acesso permitido");

            }
        }
    }
}