using System;
using System.Collections.Generic;

namespace Soma_dos_Multiplos_de_3_ou_5
{
    class SomaMultiplos
    {
        public static void Main()
        {

            Console.WriteLine("SOMA DOS MULTIPLOS DE 3 E 5");
            Console.WriteLine("----------------------------\n");
            Console.WriteLine("INSIRA O NÚMERO QUE DESEJA CONHECER OS SOMATÓRIO DOS MÚLTIPLOS DE 3 OU 5");
            int numero = int.Parse(Console.ReadLine());

            int somaMult = somaMultiplos(numero);

            Console.WriteLine($"\nA soma dos multiplos de 3 e 5 entre 0 e {numero}, é: {somaMult}");


        }

        public static int somaMultiplos(int count)
        {
            int tres = 3;
            int cinco = 5;
            int somatorio = 0;
            List<int> multiplos = new List<int>();

            for (int i = 1; i < count; i++)
            {
                if (i % tres == 0 || i % cinco == 0)
                {
                    somatorio += i;
                    multiplos.Add(i);
                }
            }

            Console.WriteLine("\nOs múltiplos de 3 e 5 são: [{0}]", string.Join(", ", multiplos));

            return somatorio;
        }
    }
}
