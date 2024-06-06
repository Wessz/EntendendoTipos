using System;
using System.Collections.Generic;

namespace MinhaAnotacoesDeTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplos de tipos básicos
            int inteiro = 42;
            float flutuante = 3.14f;
            double duplo = 2.71828;
            decimal decimalNumero = 123.456m;
            char caractere = 'A';
            string texto = "Olá, Mundo!";
            bool booleano = true;
            //var variavel = 'valor variavel';
            // Exemplos de outros tipos numéricos
            short curto = 32000;
            ushort curtoSemSinal = 65000;
            long longo = 9223372036854775807;
            ulong longoSemSinal = 18446744073709551615;
            byte byteNumero = 255;
            sbyte byteNumeroSinal = -128;


            Console.WriteLine("\nTipos Básicos:");
            Console.WriteLine($"char: {caractere}");
            Console.WriteLine($"string: {texto}");
            Console.WriteLine($"bool: {booleano}");
            //Console.WriteLine($"var: {variavel}");

            Console.WriteLine("\nTipos inteiros:");
            Console.WriteLine($"int: {inteiro}");
            Console.WriteLine($"short: {curto}");
            Console.WriteLine($"ushort: {curtoSemSinal}");
            Console.WriteLine($"long: {longo}");
            Console.WriteLine($"ulong: {longoSemSinal}");
            Console.WriteLine($"byte: {byteNumero}");
            Console.WriteLine($"sbyte: {byteNumeroSinal}");

            Console.WriteLine("\nTipos inteiros reais:");
            Console.WriteLine($"float: {flutuante}");
            Console.WriteLine($"double: {duplo}");
            Console.WriteLine($"decimal: {decimalNumero}");




            // Exemplos de tipos complexos
            int[] arrayInteiros = { 1, 2, 3, 4, 5 };
            List<string> listaStrings = new List<string> { "um", "dois", "três" };
            Dictionary<string, int> dicionario = new Dictionary<string, int>
            {
                { "um", 1 },
                { "dois", 2 },
                { "três", 3 }
            };

            Console.WriteLine("\nTipos Complexos:");
            Console.WriteLine("Array de inteiros:");
            foreach (int num in arrayInteiros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nLista de strings:");
            foreach (string str in listaStrings)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\nDicionário:");
            foreach (var kvp in dicionario)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
