using System;

namespace CalculoMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            float Nota1 = 0;
            float Nota2 = 0;
            float Nota3 = 0;

            Console.WriteLine("Informe a nota 1");
            Nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota 2");
            Nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota 3");
            Nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("A média é: " + (Nota1 + Nota2 + Nota3) / 3);

        }
    }
}
