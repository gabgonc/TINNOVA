using System;

namespace Fatorial
{
    public class Fatorial
    {
        public static void Main()
        {
            Console.WriteLine("CÁLCULO DE FATORIAL");
            Console.WriteLine("-------------------\n");
            Console.WriteLine("POR FAVOR INSIRA O NÚMERO A SER CALCULADO O FATORIAL: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero == 0)
            {
                Console.WriteLine($"O fatorial de 0 (zero) é 1!");
            }
            else
                Console.WriteLine($"O Fatorial de {numero} é: {fatorial(numero)}");

        }

        public static double fatorial(int fat)
        {
            double totalFat = fat;
            for (int i = fat-1; i >= 1; i--)
            {
                totalFat = totalFat * i;
            }

            return totalFat;
        }
    }
}
