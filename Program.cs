using System;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --- Numeral por Extenso --- ");
            Console.Write("Digite o numero desejado: ");

            string numeroDigitado = Console.ReadLine();
            int numeroNovo = Convert.ToInt32(numeroDigitado);
            string exibirExtenso = numeroNovo.ToWords();
            string exibirRomano = numeroNovo.ToRoman();

            Console.WriteLine($"O numero digitado é: {exibirExtenso}");
            Console.WriteLine($"O numero digitado em algarismos romanos é: {exibirRomano} ");

            


        }
    }
}
