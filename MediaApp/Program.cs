using System;

namespace MediaApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double media = CalcularMedia(num1, num2);

            Console.WriteLine($"\nA média entre {num1} e {num2} é: {media}");
        }

        public static double CalcularMedia(double a, double b)
        {
            return (a + b) / 2.0;
        }
    }
}
