using System;

namespace Bubble_Sort
{
    public class BubbleSort
    {

        public static void Main()
        {
            Console.WriteLine("ALGORITMO DE ORDENAÇÃO BUBBLE SORT");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("POR FAVOR INSIRA A QUANTIDADE DE ITENS DO VETOR");
            int count = int.Parse(Console.ReadLine());
            int[] vet = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"POR FAVOR INSIRA O VALOR DA POSICAO {i} DO VETOR");
                vet[i] = int.Parse(Console.ReadLine());
            }

            int[] arrayOrdenado = metodoBubbleSort(vet);

            Console.WriteLine("O SER VETOR ORDENADO É: [{0}]", string.Join(", ", arrayOrdenado));

        }

        public static int[] metodoBubbleSort(int[] array)
        {
            int comprimento = array.Length;
            int contadorComparacoes = 0;
            int contadorTrocas = 0;

            for(int i = comprimento - 1; i >= 1; i--)
            {
                for(int j =0;j < i; j++)
                {
                    contadorComparacoes++;
                    if(array[j] > array[j + 1])
                    {
                        int aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                        contadorTrocas++;
                    }
                }
            }
            return array;
        }
    }
}
