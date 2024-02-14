using System;

namespace ConhecendoSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funcionamento do Split: ");

            string s = Console.ReadLine();

            string[] vet = s.Split(',');
            string A = vet[0];
            string B = vet[1];
            string C = vet[2];

            string numeros = Console.ReadLine();

            string[] conjuntos = s.Split(' ');
            string zero = vet[0];
            string um = vet[1];
            string dois = vet[2];



            Console.WriteLine(s);
            Console.WriteLine(numeros);

            Console.ReadLine();
        }
    }
}
